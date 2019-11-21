
window.addEvent('domready',function(){

    Fil.responsive();

});


/**
 * events: mobMenuReady
 * @returns {boolean}
 */
Fil.responsive =function () {

    var Button=$('mobMenuButton');
    if(!Button) return false;
    var MenuWrap =  $$('.navi-wrap').pick();
    var MobMenu =  $('mobMenuContainer');
    var mainWrapper=$('wrapper');
    var LoginBox= $$('.box_login_s').pick();
    var SearchBox=$$('.search').pick();
    if(SearchBox){
        var SearchBoxMarker= new Element('span').inject(SearchBox,'before');
    }
    var OutClick;
    var VersionMenu;
    var $initialMenuNav;

    var cloneSiteMenu=function(){
        //menu DOM manüpüle edilmeden önce kaydedelim
        $initialMenuNav=$$(".navi-wrap").getElement("nav").pick().clone(true,false);
        $initialMenuNav.getElement("ul").removeClass("site-navi").addClass("mob-navi");
    };

    var generateMobMenu=function (){

        //menu oluşmuşsa bir daha oluşturma
        if(MobMenu.getElement('ul')){
            return true;
        }
         var menuHtml=$initialMenuNav.get('html');

        var MobMenuUl=new Element('ul')
            .set('html',menuHtml)
            .inject(MobMenu);


        MobMenu.hide();
        MobMenu.inject(document.body);

        MobMenu.getElements('ul > li > ul').each(function(el){
            el.hide();
            var anchor=el.getParent('li').getElement('a');
            var subHandle=new Element('span',{'class':'handle icon-arrow-down5'})
                .inject(anchor);
            subHandle.addEvent('click',function(e){
                e.stop();
                this.getParent('li').getElement('ul').toggle();
            })

        });
        //login box;
        if(LoginBox){
        MobLoginBox=new Element('div',{'html':LoginBox.get('html'),'class':'mob-login'})
            .inject(MobMenu,'top');
            MobLoginBox.getElements('a').addClass('button')
        }
        //mobile version switc
        VersionMenu=new Element('div',{'class':'layout-switch'});
        new Element('a',{'href':window.baseUrl+'/Home/set-display/version/desktop/?c='+Math.random(),'class':'desktop' }).inject(VersionMenu);
        VersionMenu.inject(MobMenu);

        //kapanması için outclick
        OutClick=new Element('div',{'style':'position:fixed;z-index:100000;left:0;top:0;width:100%;height:100%;'})
            .inject(mainWrapper,'top')
            .addEvent('click',toggleMobMenu)
            .hide();
        window.fireEvent("mobMenuReady");
    };


    var toggleMobMenu=function (force){
        var shift = 0;
        if(MobMenu.isVisible() || force == 'hide'){
            if(!MobMenu.isVisible() ) return false;
            MobMenu.hide();
            if(OutClick) OutClick.hide();
            document.body.setStyle('overflow-x','inherit');
            document.body.removeClass("mob-menu-open")
        }else if(!MobMenu.isVisible() || force == 'show'){
            VersionMenu.hide();
            shift = -1 * MobMenu.measure(function(){
                return this.getSize().x;
            });
            var scrollH=document.getScrollSize().y;
            MobMenu.show();
            MobMenu.setStyle('min-height',scrollH);

           document.body.setStyle('overflow-x','hidden');
            (function(){
                //menü hızlı açılsın diye bazı işlemleri menü açıldıktan sonraya yapalım
                VersionMenu.show();
                OutClick.show();
                OutClick.setStyle('width',document.getSize().x - MobMenu.getSize().x);
            }).delay(100);

            document.body.addClass("mob-menu-open");
        }
        mainWrapper.setStyles({
            'position':'relative',
            'left': shift
        });
        if($('top').getStyle('position')=='fixed'){
            $('top').setStyles({
                'left': shift || null,
                'right': shift ? (-1 *  shift):null
            });
        }

    };



    var switchMode=function (){
        var winWidth=window.document.getSize().x;

        if(this.lastWinWidth==winWidth){
            return false;
        }
        this.lastWinWidth = winWidth;

        if(winWidth < 1024){
            MenuWrap.hide();
            Button.show();
            if(SearchBox)
            SearchBox.inject(MobMenu,'top').show();
            generateMobMenu();
        }else{
            MenuWrap.show();
            toggleMobMenu('hide');
            Button.hide();
            if(SearchBoxMarker)
            SearchBox.inject(SearchBoxMarker,'after');
        }
        toggleMobMenu('hide');
    };


    cloneSiteMenu();

    Button.addEvent('click',toggleMobMenu);

    window.addEvent('resize',function(){
        switchMode();
    });

	switchMode();
	//dopdov menu oluşumunu bozuyor:
   //disabled:  switchMode.delay(100);

};

