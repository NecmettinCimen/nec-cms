/**
 * @no-mootools
 * @vanilla
 *
 *  * TODO: marker gruplama

 */

var openLayersMapBuilder = function () {
    this.options = {
        id: null,
        height: "350",
        mapData: {}

<<<<<<< HEAD
    };
=======
    }
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6

    /**
     * http://leaflet-extras.github.io/leaflet-providers/preview/
     */
    this.tileServers = {
        'Varsayılan': 'https://{a-c}.tile.openstreetmap.org/{z}/{x}/{y}.png',
        'Klasik': 'https://tile-c.openstreetmap.fr/hot/{z}/{x}/{y}.png',
        'Solgun': 'https://c.tile.openstreetmap.se/hydda/full/{z}/{x}/{y}.png',
        'Wikimedia': "https://maps.wikimedia.org/osm-intl/{z}/{x}/{y}.png",
        'Carto Açık': "http://{a-c}.basemaps.cartocdn.com/light_all/{z}/{x}/{y}.png",
        'Carto Karanlık': "http://{a-c}.basemaps.cartocdn.com/dark_all/{z}/{x}/{y}.png",
        'Carto Seyahat': "https://b.basemaps.cartocdn.com/rastertiles/voyager/{z}/{x}/{y}.png",
        'Carto Antik': "https://cartocdn_{a-c}.global.ssl.fastly.net/base-antique/{z}/{x}/{y}.png",
        'Topografik': "https://a.tile.opentopomap.org/{z}/{x}/{y}.png",
        'Esri': "https://server.arcgisonline.com/ArcGIS/rest/services/World_Topo_Map/MapServer/tile/{z}/{y}/{x}",
        'Esri Uydu': "https://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}",
        'Suluboya': "http://{a-c}.tile.stamen.com/watercolor/{z}/{x}/{y}.png"
<<<<<<< HEAD
    };
=======
    }
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6

    this.$map = null;
    this.Map = null;
    this.MapLayers = {};

    this.loadAPI = function (callback) {
<<<<<<< HEAD
        Fil.loadScriptAssets(['https://cdn.rawgit.com/openlayers/openlayers.github.io/master/en/v5.3.0/build/ol.js'], callback);
        Fil.loadScriptAssets(['https://cdn.rawgit.com/openlayers/openlayers.github.io/master/en/v5.3.0/css/ol.css']);

    };
=======
        Fil.loadScriptAssets(['https://cdn.rawgit.com/openlayers/openlayers.github.io/master/en/v5.3.0/build/ol.js'], callback)
        Fil.loadScriptAssets(['https://cdn.rawgit.com/openlayers/openlayers.github.io/master/en/v5.3.0/css/ol.css']);

    }
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6

    this.init = function (options) {

        this.loadAPI(function () {
<<<<<<< HEAD
            this.setOptions(options);
=======
            this.setOptions(options)
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6
            this.$map = $(options.id);
            this.setHeight(options.height);
            this.setMapData(options.mapData);
            this.drawMap();
            this.triggerEvent(window, 'eklentiOLMapInit', {element: this.$map, map: this.Map});

            //mobil scrol için görünmez div;
            var mobScroller = document.createElement("div");
            mobScroller.setAttribute("class", 'olmap-mob-handle');
            this.$map.appendChild(mobScroller)

        }.bind(this))


<<<<<<< HEAD
    };
=======
    }
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6


    this.drawMap = function () {
        var MapData = this.options.mapData;

        var map = this.Map = new ol.Map({
            target: this.$map,
            interactions: ol.interaction.defaults({mouseWheelZoom: false, altShiftDragRotate: false, pinchRotate: false}),

            layers: [
                new ol.layer.Tile({
                    source: new ol.source.OSM({
                        "url": this.tileServers[this.options.mapData.tileServerName || 'Klasik'],
                        "crossOrigin": null,
                        "attributions": ['&copy; <a href="http://www.openstreetmap.org/copyright" target="_blank">OSM</a>']
                    }),


                })
            ],
            view: new ol.View({
                center: ol.proj.fromLonLat([MapData.center.lng, MapData.center.lat]),
                zoom: MapData.zoom
            })
        });
        this.$map.OLMap = this.Map;


        for (var i = 0; i < MapData.points.length; i++) {
            var item = MapData.points[i];
            this.addMarker(item);
        }

        this.initMarkerPopup();
        map.updateSize();
        //window.addEventListener("DOMContentLoaded", map.updateSize.bind(map));
        window.addEvent("domready", map.updateSize.bind(map));
        window.addEventListener("load", map.updateSize.bind(map));


<<<<<<< HEAD
    };
=======
    }
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6

    this.initMarkerPopup = function () {

        var map = this.Map;


        if (!this.$mapPopup) {
            this.$mapPopup = document.createElement("div");
<<<<<<< HEAD
            this.$map.appendChild(this.$mapPopup);
=======
            this.$map.appendChild(this.$mapPopup)
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6
            this.$mapPopup.setAttribute("class", "ol-infowin");
            this.$mapPopup.style.position = "relative";

        }

        var popup = new ol.Overlay({
            element: this.$mapPopup,
            positioning: 'bottom-center',
            stopEvent: false
        });
        map.addOverlay(popup);
        map.on('click', function (evt) {

            var feature = map.forEachFeatureAtPixel(evt.pixel, function (feature, layer) {
                return feature;
            });


            var $popup = popup.getElement();
            if (feature) {
<<<<<<< HEAD
                $popup.style.display = "block";
                var coord = feature.getGeometry().getCoordinates();
                console.log("F", coord);
=======
                $popup.style.display = "block"
                var coord = feature.getGeometry().getCoordinates();
                console.log("F", coord)
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6


                var props = feature.getProperties();
                $popup.innerHTML = '';
                var infoElement = document.createElement("div");
                infoElement.setAttribute("class", 'iwin');
                infoElement.innerHTML = '<div class="t"></div><div class="c"></div>';

                infoElement.querySelector(".t").innerHTML = props.title;
                infoElement.querySelector(".c").innerHTML = props.desc;

<<<<<<< HEAD
                $popup.appendChild(infoElement);
=======
                $popup.appendChild(infoElement)
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6
                popup.setPosition(coord);

                //icon ebatına göre shift et;
                var iconImage = feature.getStyle().getImage();
                if (iconImage) {
                    var height = iconImage.getImageSize()[1];
                    $popup.style.top = (-1 * height) + "px";
                }

            } else {
                $popup.style.display = "none"
            }


        })
<<<<<<< HEAD
    };
=======
    }
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6

    this.addMarker = function (markerData) {
        if (!this.MapLayers.Markers) {
            //boş source ekle
            var vectorSource = new ol.source.Vector({
                features: []
            });
            //vector layer aç
            this.MapLayers.Markers = new ol.layer.Vector({
                source: vectorSource
            });
            this.Map.addLayer(this.MapLayers.Markers);
        }
        var iconFeature = new ol.Feature({
            geometry: new ol.geom.Point(ol.proj.fromLonLat([markerData.lng, markerData.lat])),
            title: markerData.title,
            desc: markerData.desc
        });

        //create style for your feature...
        var iconStyle = new ol.style.Style({
            image: new ol.style.Icon(({
                anchor: [0.5, 0],
                anchorOrigin: "bottom-left",
                src: this.getIconPath(markerData.icon)
            }))
        });

        iconFeature.setStyle(iconStyle);
        this.MapLayers.Markers.getSource().addFeatures([iconFeature]);

        /*
         var dragInteraction = new ol.interaction.Modify({
            features: new ol.Collection([iconFeature]),
            style: null
        });

        this.Map.addInteraction(dragInteraction);
        iconFeature.on('change', function () {
            console.log('Feature Moved To:' + this.getGeometry().getCoordinates());
        }, iconFeature);*/

<<<<<<< HEAD
    };
    this.getIconPath = function (path) {
        if (!path) path = window.baseUrl + "/../styles/Eklenti/images/map/00default.png";
        return path
    };
    this.setMapData = function (data) {
        this.mapData = data;

    };
=======
    }
    this.getIconPath = function (path) {
        if (!path) path = window.baseUrl + "/../styles/Eklenti/images/map/00default.png";
        return path
    }
    this.setMapData = function (data) {
        this.mapData = data;

    }
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6
    this.setHeight = function (height) {
        this.$map.setStyle('height', height);
        //todo: google.maps.event.trigger(this.map, 'resize');
        return this;
<<<<<<< HEAD
    };
=======
    }
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6
    this.setOptions = function (options) {
        var objectConstructor = {}.constructor;

        function simpleMerge(newP, defP) {
            var merged = defP || {};
            for (var prop in newP) {
                if (newP.hasOwnProperty(prop)) {
                    if (newP[prop] && newP[prop].constructor === objectConstructor) {
                        merged[prop] = simpleMerge(newP[prop], merged[prop]);
                    } else {
                        merged[prop] = newP[prop];
                    }
                }
            }
            return merged;
        }

        this.options = simpleMerge(options, this.options);
        return this.options;
<<<<<<< HEAD
    };
    this.triggerEvent = function (element, eventName, params) {
        element.dispatchEvent(new CustomEvent(eventName, params));
    }
};
=======
    }
    this.triggerEvent = function (element, eventName, params) {
        element.dispatchEvent(new CustomEvent(eventName, params));
    }
}
>>>>>>> 7899e80702cea993dd3d3d649b173e1502ac6eb6



