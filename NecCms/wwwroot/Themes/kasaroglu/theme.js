var viewPortSize;
var toTopCont;
var toTopHideTimer;


window.addEvent('scroll', function (e) {
    if (Fil.isMobile()) {
        return;
    }
    if (window.getScroll().y > 150) {
        $('top').addClass('fixed');
    } else {
        $('top').removeClass('fixed');
    }
});
window.addEvent('domready', function () {
	  
    $$('.navi li').addEvent('mouseover', function (e) {
        $('top').addClass('opak');
    })
    $$('.navi li').addEvent('mouseleave', function (e) {
        $('top').removeClass('opak');
    })
    window.addEvent('scroll', function () {
        siteMainMenu.hideAllSubMenusNow()
    })
});


window.addEvent('domready', function () {
    //fix: mobile table max-width: 100%
    if (!Fil.isMobile())
        return;
    //max-width:100% verilen tabloların width'i 100% yap
    $$('table').each(function (ele) {
        if (ele.getStyle("max-width") == "100%") {
            ele.setStyle("width", "100%")
        }
    })



});

 
 
