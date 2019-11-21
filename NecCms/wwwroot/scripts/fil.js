/**
 *
 * Fil Utility Class
 *
 * v: 1.0.0
 *
 */

/* JAVASCRİPT PROTOTOYPING   */

String.prototype.turkishToUpper = function () {
    var string = this;
    var letters = {"i": "İ", "ş": "Ş", "ğ": "Ğ", "ü": "Ü", "ö": "Ö", "ç": "Ç", "ı": "I"};
    string = string.replace(/(([iışğüçö]))/g, function (letter) {
        return letters[letter];
    });
    return string.toUpperCase();
};

String.prototype.turkishToLower = function () {
    var string = this;
    var letters = {"İ": "i", "I": "ı", "Ş": "ş", "Ğ": "ğ", "Ü": "ü", "Ö": "ö", "Ç": "ç"};
    string = string.replace(/(([İIŞĞÜÇÖ]))/g, function (letter) {
        return letters[letter];
    });
    return string.toLowerCase();
};

/* /JAVASCRİPT PROTOTOYPING   */

var Fil = {};

//layz componenet loader
Fil.load = function (component, complete) {
    var base = window.baseUrl.replace(new RegExp("(/idare)?/([a-z]{2})$"), "");
    Fil.loadScriptAssets([base + "/scripts/fil/" + component + ".js"], complete)

};

Fil.isArray = function (input) {
    return typeof(input) == 'object' && (input instanceof Array);
};


Fil.escapeHtml = function (string) {
    var htmlEscapes = {'&': '&amp;', '<': '&lt;', '>': '&gt;', '"': '&quot;', "'": '&#x27;', '/': '&#x2F;'};
    var htmlEscaper = /[&<>"'\/]/g;

    return ('' + string).replace(htmlEscaper, function (match) {
        return htmlEscapes[match];
    });

};



Fil.randomDomId = function (len) {
    if (!len) len = 8;
    var text = "";
    var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    for (var i = 0; i < (len); i++)
        text += possible.charAt(Math.floor(Math.random() * possible.length));
    text = 'RDI_' + text;
    return text;
};

Fil.copyToClipboard=function(str){
    var el = document.createElement('textarea');
    el.value = str;
    el.setAttribute('readonly', '');
    el.style.position = 'absolute';
    el.style.left = '-9999px';
    document.body.appendChild(el);
    el.select();
    document.execCommand('copy');
    document.body.removeChild(el);
};

Fil.isMobile = function () {
    //if (Browser.Platform.android || Browser.Platform.ios || Browser.Platform.webos)
    if (Browser.platform == "android" || Browser.platform == "ios")
        return true;
    else
        return false;

};


Fil.isTouchDevice = function isTouchDevice() {
    return 'ontouchstart' in document.documentElement;
};

/**
 * Aray halinde verilen js dosyalarını sıra ile yükler ve bitince "complete" fn fire edilir.
 * @param scriptsArray js dosya adresleri
 * @param complete onComplete function
 * @return loaded scripts
 */
Fil.loadScriptAssets = function (scriptsArray, complete) {
    //(S)tarted yada (C)omplated işaretlerini taşır
    if (!window._fwlapnd) window._fwlapnd = [];

    var files = [];
    if (typeof scriptsArray == "string") {
        scriptsArray = [scriptsArray]
    }

    function loadScript(i) {
        var filepath = scriptsArray[i];
        if ("undefined" !== typeof(filepath)) {

            if (window._fwlapnd[filepath] == "C") {
                loadScript(i + 1);
            } else {
                var type = filepath.match(/\.([^\./\?\#]+)($|\?|#)/)[1];
                var onloadFunc = function () {
                    //C: Complete
                    window._fwlapnd[filepath] = "C";
                    loadScript(i + 1);
                };

                //File eklenmiş ancak henüz yüklemesi bitmemişse onload ekleyelim

                if (window._fwlapnd[filepath] == "S") {
                    var fileInDom = document.querySelector('link[href*="' + filepath + '"],script[src*="' + filepath + '"]');
                    var oldOnload = fileInDom.onload;
                    fileInDom.onload = function () {
                        if (oldOnload) oldOnload();
                        onloadFunc()
                    }
                } else {
                    //dosya yüklenmiş olarak işaretli değil ve henüz eklenmemiş. Ekleyelim.
                    //S: Started
                    window._fwlapnd[filepath] = "S";

                    if (type == "css") {
                        files[i] = new Asset.css(filepath, {
                            onLoad: onloadFunc
                        });
                    } else if (type == "js") {
                        files[i] = new Asset.javascript(filepath, {
                            onLoad: onloadFunc
                        });
                    }
                }
            }
        } else {
            //alert(scripts)
            if (complete)
                complete(files);
        }
    }


    loadScript(0);
};


/**
 * formun datasını url ile gönderilebilecek şekilde serialize eder
 * @param form
 * @returns {string}
 */
Fil.serializeForm = function (form) {

    form = $(form);
    var params = '';
    var formData = form.toQueryString().parseQueryString();
    var piece = "";

    for (var key in formData) {

        if (formData[key]) {

            if (Fil.isArray(formData[key])) {

                formData[key] = formData[key].join("|");
            }

            params += ((piece) ? piece : key) + "/" + (encodeURIComponent(formData[key].replace('/', ' '))) + "/";

            piece = null;
        }
    }

    return params;
};

Fil.urlGetHash = function () {
    return window.location.hash.substring(1);
};

/**
 * @deprecated
 *
 * Use: new URLSearchParams(queryString).get("paramName");
 *
 * @param queryString
 * @returns {any}
 */

Fil.queryToJSON = function (queryString) {


    var pairs = queryString.replace(/\&amp\;/g, '&').replace(/^&+|&$/g, '').split('&');

    var result = {};
    pairs.forEach(function (pair) {
        pair = pair.split('=');
        result[pair[0]] = decodeURIComponent(pair[1] || '');
    });

    return JSON.parse(JSON.stringify(result));
};
/**
 *
 * mouse tekerleğini durdurup smoothScrol ile daha düzgün bir kaydırma yapar
 */
Fil.mouseScroll = function () {
    var self = this;
    document.addEvent('mousewheel', function (event) {
        if (!self.mouseScrollSpeed) {
            self.mouseScrollSpeed = 0;
        }
        if (!document.scrollFx) {
            document.scrollFx = new Fx.Scroll(document, {
                link: 'cancel',
                'duration': 1000,
                'transition': Fx.Transitions.easeOut,
                fps: 100,
                wheelStops: false,
                onComplete: function () {
                    self.mouseScrollSpeed = 0
                }
            });
        }
        event.stop();

        var speedMultiplier = 0;
        var roundedAbs = Math.round(Math.abs(event.wheel));
        switch (roundedAbs) {
            case 0:
                speedMultiplier = 1;
                break;
            case 1:
                speedMultiplier = 2;
                break;
            case 3:
                speedMultiplier = 3;
                break;
            default:
                speedMultiplier = 4;
        }

        if (speedMultiplier > self.mouseScrollSpeed) {
            self.mouseScrollSpeed = speedMultiplier;
        } else {
            return;
        }

        if (event.wheel > 0) {
            var delta = -1 * speedMultiplier * 200;
        } else {
            var delta = speedMultiplier * 200;
        }
        document.scrollFx.start(window.getScroll().y, window.getScroll().y + delta);

    });
};

/**
 * Kullanım
 * A) Fil.notiyf('hello world',2)
 * B) Fil.notiyf('loading')
 * C) Fil.notiyf().close()
 *
 * sayfa üstünden kayarak mesaj gösterir
 * @param message
 * @param timeout  saniye
 */
Fil.notify = function (message, timeout) {
    var self = this;

    if (message === null || message === undefined) {
        return this;
    }

    if (!window.filNotifierBox) {
        var b = window.filNotifierBox = new Element('div', {'class': 'notifierBox'}).inject(document.body, 'top');
        b.loadAnim = new Element('div', {'class': 'loading'}).inject(b);
        b.setStyles({'position': 'fixed'});
        b.Fx = new Fx.Morph(b, {duration: 500, transition: Fx.Transitions.easeIn, link: 'chain'});
        new Element('div', {'html': '×', "style": "position:absolute;top:6px;right:5px;font-size:30px;cursor:pointer"})
            .inject(b)
            .addEvent('click', function () {
                self.close();
            });
        b.content = new Element('div', {'class': 'c'}).inject(b);
    }

    var b = window.filNotifierBox;
    //Kapanmakta olan pencereye yeni mesaj gelirse iptal et
    if (this.closeFx && this.closeFx.isRunning()) {
        this.closeFx.cancel();
        //kapanırken yeni mesaj gelmiş. Eskisini sil.
        b.content.set('html', '');
    }

    b.removeClass('error');

    b.loadAnim.hide();
    clearTimeout(b.hto);
    var say = message;
    if (message == 'loading') {
        if (b.isOpen) {
            return this;
        }
        say = "İşlem gerçekleştiriliyor. Lütfen Bekleyin...";
        b.stateLoading = true;
        b.loadAnim.show();
        timeout = 0;
    }
    say = '<div>' + say + '</div>';

    if (!b.stateLoading && b.getStyle('visibility') != 'hidden') {
        //yeni gelen mesajı ekle
        say = b.content.get('html') + '<div>' + message + '</div>';
    }

    if (say) b.content.set('html', say);
    if (message != 'loading') b.stateLoading = 0;

    //position
    var delta = (window.getSize().x - b.getSize().x) / 2;
    if (message) {
        b.setStyles({
            'top': b.getSize().y * -1,
            'left': delta + 'px',
            'opacity': 1,
            'visibility': 'visible'
        });
        b.Fx.start({'top': 0});
    }

    if (timeout === undefined) timeout = 5;
    else if (timeout === 0) timeout = 999999;
    timeout = timeout * 1000;

    b.hto = (function () {
        self.close();
    }).delay(timeout);


    b.isOpen = true;
    this.close = function () {

        if (!this.closeFx) {
            this.closeFx = new Fx.Morph(b, {
                duration: 2000,
                onComplete: function () {
                    b.setStyle("visibility", "hidden");
                }
            });
        }
        this.closeFx.start({'opacity': [1, 0]});

        clearTimeout(window.filNotifierBox.hto);
        window.filNotifierBox.hto = null;
        b.isOpen = false;
        return false;
    };
    this.error = function () {
        var b = window.filNotifierBox;
        window.filNotifierBox.content.getElement('div:last-child').addClass('error');
        // b.addClass('error');
        return this;
    };


    return this;
};

/**
 *
 * @param element
 * @param method  fade|roll
 */
Fil.dispose = function (element, method) {
    if (!method) method = 'fade';

    var el = $(element);
    el.set('tween', {
        onComplete: function () {
            el.dispose();
        }
    });

    if (method == 'fade') {
        var prop = 'opacity'
    } else {
        var prop = 'height';
        el.setStyle('overflow', 'hidden')
    }

    el.tween(prop, '0');

};

/**
 * textarea gibi alanlar yazdıkça genişler
 * @param el
 */
Fil.elementAutoExpand = function (el) {

    var el = $(el);
    var resize = function () {
        if (el.getSize().y < el.scrollHeight) {
            el.setStyle('height', (el.scrollHeight + 5) + 'px')
        }
        return this;
    };
    resize();
    el.addEvent('keyup', function () {
            resize();
        }
    );

};

/**
 * @deprecated
 * Element'a bağlı tips
 * @param title [optional]
 * @param text [optional]
 * @param position [optional]
 */
Element.prototype.filTips = function (title, text, position) {
    var a = this;
    if (position == "bottom") {
       var rp = "centerBottom",
        re = "centerTop",
        ro = {x: 0, y: 10},
        tipClass = "bot",
        fxm = [5, 0];
    } else {
        var rp = "centerTop",
        re = "centerBottom",
        ro = {x: 0, y: -10},
        tipClass = "top",
        fxm = [-5, 0];
    }

    this.filTip = new Tips(this, {
        fixed: true,
        showDelay: 550,
        className: 'tip-wrap fw-tip ' + tipClass,
        onShow: function () {
            var T = this.tip;
            T.setStyle("display", "none");
            T.set('morph', {duration: 100, transition: 'quad:in'});
            T.morph({'margin-top': fxm, 'opacity': [0, 1]});
            var self = this;
            (function () {
                T.position({
                    relativeTo: a,
                    position: rp,
                    edge: re,
                    offset: ro
                });
                T.setStyle("display", "block");
            }).delay(50);
        }
    });
    if (title) this.store('tip:title', title);
    this.store('tip:text', text);
    a.addEvents({
        "mousedown": function () {
            this.filTip.hide();
        },
        "click": function () {
            this.filTip.hide();
        }
    })

};

/**
 * @deprecated
 * DOM nesnelerini vertical olarak align etmeye çalışır.
 * data-vertical-align varsa Fil.RenderFront otomatik çağırır
 * data-vertical-align tagi içinde gelen seçeneklere göre işlem yapar
 * ÖRN: data-vertical-align="parent:div,x=y,i=j"
 * data-vertical-align.parent: align edilecek nesne için parent selector. null ise ilk parent alınır
 * @param elements
 * @param container
 */
Fil.verticalAlign = function (elements, container) {


    function align(elements, container) {
        //tek element
        if (!elements.length) {
            elements = $$([elements]);
        }

        elements.each(function (el) {
            var Options = {};
            var optionsStr = (el.getAttribute("data-vertical-align"));
            if (optionsStr) {
                var optionsParts = optionsStr.split(",");
                //data tag ile gelen seçenekleri oluşturalım

                optionsParts.each(function (part) {
                    var data = part.split(":");
                    Options[data[0]] = data[1];
                })

            }
            var parentSelector = (Options.parent) ? Options.parent : "*";
            var parent = (container) ? container : el.getParent(parentSelector);

            var elH = el.getSize().y;
            var parentH = parent.getSize().y;
            var delta = (parentH - elH) / 2;
            el.setStyle("margin-top", delta);
        })
    }

    align(elements, container);
    (function () {
        align(elements, container)
    }).delay(100);
    window.addEvents({
        "resize": function () {
            align(elements, container)
        },
        "load": function () {
            align(elements, container)
        }
    })

};

/**
 * @deprecated
 * verilen aspect ratio ile genişlik baz alınarak göre elementlere height tanımlar
 */
Fil.aspectRatio = function (elements) {

    if (elements == undefined) {
        elements = $$("*[data-aspect-ratio]");
    }

    function resize(elements) {
//tek element
        if (!elements.length) {
            elements = $$([elements]);
        }

        elements.each(function (el) {
            var aspectR = (el.getAttribute("data-aspect-ratio"));
            var w = el.getSize().x;
            el.setStyle("height", w * aspectR + "px");

        });
    }

    resize(elements);
    if (!window._methodFilAspectRatioInit) {

        window._methodFilAspectRatioInit = true;

        window.addEvent("resize", function () {
            resize(elements)
        });
    }

};


Fil.dialog = function () {
    //ES6 import modülü yaygınlaşınca implement edilecek
    console.warn("Fil.dialog not implemented");
};


Fil.fullscreen = function () {
    /**ScreenFull v4.0.1 - 2019-02-18  https://github.com/sindresorhus/screenfull.js  */

    /** props: enabled | isFullscreen | element  | raw */
    /** methods: request | exit | toggle | on | off | onChange | onError  */
    /** events: change  */
    var module={exports:true};

    !function () {
        "use strict";
        var u = "undefined" != typeof window && void 0 !== window.document ? window.document : {}, e = "undefined" != typeof module && module.exports,
            t = "undefined" != typeof Element && "ALLOW_KEYBOARD_INPUT" in Element, c = function () {
                for (var e, n = [["requestFullscreen", "exitFullscreen", "fullscreenElement", "fullscreenEnabled", "fullscreenchange", "fullscreenerror"], ["webkitRequestFullscreen", "webkitExitFullscreen", "webkitFullscreenElement", "webkitFullscreenEnabled", "webkitfullscreenchange", "webkitfullscreenerror"], ["webkitRequestFullScreen", "webkitCancelFullScreen", "webkitCurrentFullScreenElement", "webkitCancelFullScreen", "webkitfullscreenchange", "webkitfullscreenerror"], ["mozRequestFullScreen", "mozCancelFullScreen", "mozFullScreenElement", "mozFullScreenEnabled", "mozfullscreenchange", "mozfullscreenerror"], ["msRequestFullscreen", "msExitFullscreen", "msFullscreenElement", "msFullscreenEnabled", "MSFullscreenChange", "MSFullscreenError"]], l = 0, r = n.length, t = {}; l < r; l++) if ((e = n[l]) && e[1] in u) {
                    for (l = 0; l < e.length; l++) t[n[0][l]] = e[l];
                    return t
                }
                return !1
            }(), r = {change: c.fullscreenchange, error: c.fullscreenerror}, n = {
                request: function (r) {
                    return new Promise(function (e) {
                        var n = c.requestFullscreen, l = function () {
                            this.off("change", l), e()
                        }.bind(this);
                        r = r || u.documentElement, / Version\/5\.1(?:\.\d+)? Safari\//.test(navigator.userAgent) ? r[n]() : r[n](t ? Element.ALLOW_KEYBOARD_INPUT : {}), this.on("change", l)
                    }.bind(this))
                }, exit: function () {
                    return new Promise(function (e) {
                        if (this.isFullscreen) {
                            var n = function () {
                                this.off("change", n), e()
                            }.bind(this);
                            u[c.exitFullscreen](), this.on("change", n)
                        } else e()
                    }.bind(this))
                }, toggle: function (e) {
                    return this.isFullscreen ? this.exit() : this.request(e)
                }, onchange: function (e) {
                    this.on("change", e)
                }, onerror: function (e) {
                    this.on("error", e)
                }, on: function (e, n) {
                    var l = r[e];
                    l && u.addEventListener(l, n, !1)
                }, off: function (e, n) {
                    var l = r[e];
                    l && u.removeEventListener(l, n, !1)
                }, raw: c
            };
        c ? (Object.defineProperties(n, {
            isFullscreen: {
                get: function () {
                    return Boolean(u[c.fullscreenElement])
                }
            }, element: {
                enumerable: !0, get: function () {
                    return u[c.fullscreenElement]
                }
            }, enabled: {
                enumerable: !0, get: function () {
                    return Boolean(u[c.fullscreenEnabled])
                }
            }
        }), e ? module.exports = n : window.screenfull = n) : e ? module.exports = !1 : window.screenfull = !1;

    }();

    return module.exports;
}


/**
 * Fil.storage
 */
;(function (root, factory) {

    Fil.storage = factory(root, {});


}(this, function (root, FS) {


    /**
     * Bir unixtimestamp ile veriyi kaydeder
     * @param key
     * @param value
     */
    FS.set = function (key, value) {
        var pkey = this._getPrefixedKey(key);

        try {
            localStorage.setItem(pkey, JSON.stringify({"data": value, "timeSaved": Date.now()}));
        } catch (e) {
            if (console) console.warn("Fil.storage '{" + key + ": " + value + "}' kaydını yapamadı.");
        }
    };

    FS.get = function (key, encapsulated) {
        var pkey = this._getPrefixedKey(key),
            value;

        try {
            value = JSON.parse(localStorage.getItem(pkey));
        } catch (e) {
            if (localStorage[pkey]) {
                value = {data: localStorage.getItem(pkey)};
            } else {
                value = null;
            }
        }
        if (typeof value === 'object' && value && typeof value.data !== 'undefined') {
            if (!encapsulated)
                return value.data;
            else
                return value;
        } else {
            return undefined;
        }
    };

    FS.delete = function (key) {
        var pkey = this._getPrefixedKey(key);
        localStorage.removeItem(pkey);
    };

    FS.getTimeSaved = function (key,deltaSeconds) {
        var data = this.get(key, true);
        if (typeof data === 'object' && data && typeof data.timeSaved !== 'undefined') {
            return  (deltaSeconds) ? ((Date.now() - data.timeSaved)/1000) : data.timeSaved
        } else {
            return 0;
        }
    };

    FS._getPrefixedKey = function (key) {
        return "_fs_" + key;
    };
    return FS;
}));

