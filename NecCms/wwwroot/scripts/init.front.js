/**
 *
 *  Front Initializer
 *
 */




window.addEvent('domready', function () {

    initFront();
    Fil.renderFront();
});

/**
 * sayfayı logical işlemlerle tekrar render eder. Ajax ile content yükleyince tekrar tekrar çağırılabilir.
 */
Fil.renderFront = function () {

    //MOBİL UYUM: tablo ve img elementleri width - height style içine al
    $$('.stage img,.stage table').each(function(el){

        var atrw=el.getAttribute("width");
        var atrh=el.getAttribute("height"); 
       
        if(atrw && !el.style.width){
             el.setStyle("width",parseInt(atrw)+  ((atrw.indexOf("%") > -1) ? "%" : "px") );
            el.removeAttribute("width");
        }
        if(atrh && !el.style.height){
            if(!Fil.isMobile()){
                el.setStyle("height",parseInt(atrh)+"px");
            }
            
            el.removeAttribute("height");
        }
        //mobilde table display block olduğu için height kaldırılır
        if(Fil.isMobile() && el.get('tag')=="table"){
            el.setStyle("height","");
        }
    });
    //   tıklama ile büyüyecek resimleri ayarla---------------------
    if ($$('IMG[rel=fwShowBigImg],IMG[data-showLarge=true]').pick()) {
        // popup box yüklene
        var loadLightBoxFiles = true;
        var i = 0;
        var mediaStorage = [];
        $$('IMG[rel=fwShowBigImg],IMG[data-showLarge=true]').each(function (el) {
            el.mediaIndex = i;
            mediaStorage[i] = [el.get('src').replace(/(.*)(\.[0-9]*px)(\.[a-z]{1,}$)/gi, '$1$3'), el.get('alt')];
            i++;
        });
        $$('IMG[rel=fwShowBigImg],IMG[data-showLarge=true]').addEvent('click', function (e) {
            e.stop();
            Mediabox.open(mediaStorage, this.mediaIndex);
        });
        $$('IMG[rel=fwShowBigImg],IMG[data-showLarge=true]').setStyle('cursor', 'pointer');
    }
    if (loadLightBoxFiles || document.getElement('a[rel*=lightbox]')) {
        // popup box yüklene
        if (typeof Mediabox == 'undefined') {
            new Asset.javascript(window.baseUrl + '/../scripts/mediabox/mediaboxAdv.js?c=r4u75f');
            var theme= (Fil.isMobile())? "mediaboxAdv-Mobile.css" :"mediaboxAdv-Light.css";
            new Asset.css(window.baseUrl + '/../scripts/mediabox/'+theme);
        } else {
            Mediabox.scanPage()
        }

    }

    //popOver varsa başlat
    if ($(document.body).getElement('*[data-action=popOver]')) {
        // new Asset.javascript(Fil.scriptBase+'/Fil/popOvers.js');
        Fil.loadScriptAssets([Fil.scriptBase + '/fil/popOvers.js'], function () {
            Fil.popOvers()
        });

    }
    //bazı elemanlar için gerekli wrapper -----------------------------------------------
    $(document.body).getElement('.stage-0').getElements('.body > table,.body > ul,.body > ol').each(function (el) {
        var wra = new Element('div', {'class': 'columns'})
            .inject(new Element('section')
                .inject(el, 'before'));
        el.inject(wra);
    });

    //TinyMCE sekme (tabs) varsa render et
    var tabs=[];
    var contents=[];
    $$('.mce-tab-item').each(function(tab){
        tabs.push(tab.getElement('.h'));
        contents.push(tab.getElement('.c'));

    });
    if(tabs.length > 0){
        var ID=Fil.randomDomId();
        var tabHolder=new Element('div',{'class':'mootabs','id':ID});
        var titles=new Element('ul',{'class':'mootabs_title'}).inject(tabHolder);
        for(i=0;i<tabs.length;i++){
            var tabDomid=ID +'-t'+i;
            new Element('li',{'html':tabs[i].get('html'),'title':tabDomid}).inject(titles);
            new Element('div',{'html':contents[i].get('html'),'id':tabDomid,'class':'mootabs_panel'}).inject(tabHolder);
        }
        tabHolder.inject($$('.mce-tab-item').pick(),'before');
        $$('.mce-tab-item').dispose();
        //şimdi gerekli css ve js yükleyelim
        new Asset.css(window.baseUrl+"/../scripts/mootabs/mootabs1.2.css");
        Fil.loadScriptAssets([window.baseUrl + '/../scripts/mootabs/mootabs1.2.js'],function(){
            new mootabs(ID, { width: 'auto'});
        })

    }

    //shareMenu için gerekli script yüklensin
    if ($(document.body).getElement('*[data-component=shareMenu]')) {
        Fil.loadScriptAssets([Fil.scriptBase + '/fil/shareMenu.js'], function () {
            Fil.initShareMenus();
        });

    }


    //element aspect ratio  align
    Fil.aspectRatio($$("*[data-aspect-ratio]"));

    //element vertical align
    Fil.verticalAlign($$("*[data-vertical-align]"));

    // auto tooltips
    $$('.tip').each(function(el){
        if(el.title){
            el.filTips();
        }
    });


    //menu ve sayfa listesi ikonlarında svg image dosyaları gömülü svg yapalım.

    var svgStorage=Fil.storage.get("savedSvg");
    $$("li a img[src*=.svg]").each(function ($img){

        var imgID = $img.get('id');
        var imgClass = $img.get('class');
        var imgURL = $img.get('src');

        function replaceImg(data ){

            if(!data) {
                console.warn("No svg data. IF-RIMG-01");
                return;
            }
            var ele=new Element( 'div', { html: data });

            var $svg = ele.getElement('svg');

            if(typeof imgID !== 'undefined') {
                $svg.set('id', imgID);
            }
            //svg için addClass kullanamadık: I.E.
            var svgClass="replaced-svg";
            if(typeof imgClass !== 'undefined' &&  imgClass!=null ) {
                svgClass +=" "+imgClass;
            }

            $svg.setAttribute("class", svgClass);

            // Remove any invalid XML tags as per http://validator.w3.org
            $svg.removeAttribute('xmlns:a');

            // Check if the viewport is set, else we gonna set it if we can.
            if(!$svg.getAttribute('viewBox') && $svg.getAttribute('height') && $svg.getAttribute('width')) {
                $svg.setAttribute('viewBox', '0 0 ' + $svg.getAttribute('height') + ' ' + $svg.getAttribute('width'))
            }
            // Replace image with new SVG
            $svg.replaces($img);


            if(!svgStorage || typeof svgStorage  !== 'object'){
                svgStorage={};
            }

            svgStorage[imgURL]=data;
            Fil.storage.set("savedSvg",svgStorage);


        }

        var svgData=(svgStorage && svgStorage[imgURL])? svgStorage[imgURL]: null;
        if(svgData){
            replaceImg(svgData);
        }else {

            var myRequest = new Request({
                url: imgURL,
                onComplete: replaceImg
            });
            myRequest.send();
        }

    });
};


function initFront() {
    Fil.scriptBase = window.baseUrl + '/../scripts';

    //init search box -----------------------------------------------
    var inpEle = $$('.site-search input.text');
    if (inpEle.length != 0) {
        var searchText = inpEle[0].value;
        inpEle.addEvent('focus', function () {
            if (this.value == searchText) {
                this.value = "";
            }
        });
        inpEle.addEvent('blur', function () {
            if (this.value == "") {
                this.value = searchText;
            }
        });
        $$('.site-search form').addEvent('submit', function (e) {
            var searchBox = this.getParent('.site-search');
            var searchType = searchBox.getProperty('data-type');
            if (searchType == "google") {
                var inp = searchBox.getElement('.text');
                inp.value = "site:" + document.domain + window.baseUrl + " " + inp.value;
            }
        });
    }
    //auto load parallax script
    if ($$('.parallaxbox').length > 0) {
        $$('.parallaxbox').setStyle("transition", "background-position 2s ease-out");
        Asset.javascript(window.baseUrl + '/../scripts/fil/parallax.js');
    }

    //tüm script/style taglerini documnet sonuna alıyor. CSS selector'lara takılabiliyor
    $$("body script,body style").inject($$("body").pick(),"after");



}




