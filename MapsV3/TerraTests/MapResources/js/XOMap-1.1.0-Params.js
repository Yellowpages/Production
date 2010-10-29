


////////////////////////////////////////////////////////////
// Parameters File
////
////
var zoomCounter = 0;
function onZoom(l) {
    ; //$("#debug").html(l + ":" + (zoomCounter++) );
}

function onChangeMapType(mt) { 
    //alert(mt);
}

////////////////////////////////
// Multiple Maps
//
//Comments:
//      Νέο στη version 1.1.0

var XO_MapParams =
{
    MinZoom: 3,
    MaxZoom: 14, 
    InitialZoomLevel: undefined,
    InitialCenter: undefined, // 530620,4217490
    InitialExtent: undefined,// [92777, 4624355, 914300, 3846678],
    resizable:true,
    hasOverview:true,
    overviewWidth: 100,
    overviewHeight: 100,
    overviewBorderStyle: "1px solid yellow",
    DoubleClickActive: true,
    isForPrint: false,
    calloutScrollMarginLeft: 75,
    calloutScrollMarginTop: 30,
    zoomCallback: onZoom,
    changeMapTypeCallback: onChangeMapType,
    failedIdentifyText: "ooo",
    
    
    ZoomControl:
    {
        id: undefined,          // When the id is undefined, the Zoom control lives inside the map
                                // otherwise it lives inside the div specified by the id
        left: 20,               // left of ZoomControl in div - if id undefined left in Map
        top: 20,                // top of ZoomControl in div - if id undefined top in Map
        orientation: "vertical", // Can also be "horizontal"
        iconWidth:17,
        iconHeight: 17,
        hasPanButtons: true, 
        hasRecenterButton: true,
        hasLevels: true
    },
    ScaleBar:
    {
        //left: "5px",
        //bottom: "5px",
        levels: [
            [],// Level 0: not visible!
            [],// Level 1: not visible!
            [],// Level 2: not visible!
            ["100 km", 100000, "100 mi", 160934], // Level 3: first visible!
            ["100 km", 100000,  "50 mi",  80467], // Level 4
            [ "50 km",  50000,  "20 mi",  32186], // Level 5
            [ "20 km",  20000,  "10 mi",  16093], // Level 6
            [ "10 km",  10000,   "5 mi",   8046], // Level 7
            [  "5 km",   5000,   "2 mi",   3218], // Level 8
            [  "2 km",   2000,   "2 mi",   3218], // Level 9
            [  "1 km",   1000,   "1 mi",   1609], // Level 10
            [ "500 m",    500, "500 yd",    457], // Level 11
            [ "200 m",    200, "200 yd",    184], // Level 12
            [ "100 m",    100, "100 yd",     92], // Level 13
            [  "50 m",     50,  "50 yd",     46], // Level 14
        ]
    },
//    ScaleBar:
//    {
//        levels: [
//            [],// Level 0: not visible!
//            [],// Level 1: not visible!
//            [],// Level 2: not visible!
//            ["100 km", 100000], // Level 3: first visible!
//            ["100 km", 100000], // Level 4
//            [ "50 km",  50000], // Level 5
//            [ "20 km",  20000], // Level 6
//            [ "10 km",  10000], // Level 7
//            [  "5 km",   5000], // Level 8
//            [  "2 km",   2000], // Level 9
//            [  "1 km",   1000], // Level 10
//            [ "500 m",    500], // Level 11
//            [ "200 m",    200], // Level 12
//            [ "100 m",    100], // Level 13
//            [  "50 m",     50], // Level 14
//        ]
//    },
    XOMapTypes:
    [
        {
            id: "Map",
            type: 0,
            text: "Χάρτης",
            width: 50,
            right: 170,
            top:10,
            selected: true,
            //url: ['http://mt0.xo.gr/GR','http://mt1.xo.gr/GR'],
            url: ['http://mapsrv3-1.terra.gr/TestCache','http://mapsrv3-2.terra.gr/TestCache'],


            //url: 'http://maptiles.xo.gr/GR/',
            //url: 'http://localhost/TestCache/',
            //urlOfBlanc: 'http://maptiles.xo.gr/GR/Layers/_alllayers/blanc.gif',
            urlOfBlanc: 'http://localhost:3807/MapResources/images/blanc.gif'
        },
        {
            id: "Topo",
            type: 0,
            text: "Τοπογραφικός",
            width: 90,
            right: 70,
            top:10,
            zindex:10000
        },
        {
            id: "3d",
            type: 0,
            text: "<img src='οτι γουστάρεις'/>3D",
            width: 50,
            right: 10,
            top: 10,
            zindex: 10000
        }
        ,
        {
            id: "Traffic",
            type: 1,
            url: 'http://mapsrv.xo.gr/ArcGIS/rest/services/FortoiTelenavis220210/MapServer/',
            url_attrs: "layers=show:0,1,2",
            identifyable: true,
            url_attrs_identify: "layers=all:0&tolerance=18",
            identify_maptip_layer: "0",
            identify_maptip_fields: "name,description",
            layerName: "TerraDemo.DBO.SYMBANTA_Telenavis",
            identify_condition: null,
            identify_attrs: ["category", "type", "description", "name", "municipality", "region", "startDate", "validTo"],
            identify_attrs_labels: ["", "", "", "", "", "", "", "από ", "έως "],
            identify_attrs_placeholders: ["%@%T", "", "", "", "", "", "", "", ""],
            minLevel: 3,
            maxLevel: 14,
            text: "<img src='MapResources/images/close_grey.png' />Κίνηση",
            width: 90,
            right: 270,
            top: 10,
            visible: false, 
            //eventClicked: TrafficEventClicked,
            //calloutHTMLAppend: "<span>Νίκο, οι συντεταγμένες εδώ είναι %@%X  και %@%Y και ο τίτλος %@%T (δες τα placeholders!!!)<br/>---------------------------------------------------------------------------------------------------------------------------------------</span>"
        }
        ,
        {
            id: "pharma",
            type: 1,
            url: 'http://mapsrv.xo.gr/ArcGIS/rest/services/xo_efimerebonta/MapServer/',
            url_attrs: "layers=show:0,2", /*&layerDefs=0:efActive>0*/
            identifyable: true,
            url_attrs_identify: "layers=all:0&tolerance=10",
            identify_maptip_layer: "0",
            identify_maptip_fields: "efName,efHmeres",
            layerName: "TerraDemo.DBO.EFIMEREBONTA",
            //identify_condition: ["efActive", ">0"],
            identify_attrs: ["efName", "efAddress", "efTel", "efDate","efHmeres"],
            identify_attrs_labels: ["", "", "Τηλ. ", "", ""],
            identify_attrs_placeholders: ["%@%T", "%@%A", "", "", ""],
            //identify_callback: function (){alert("lala")},
            minLevel: 3,
            maxLevel: 14,
            minIdentifyLevel: 7,
            text: "Εφημερεύοντα Φαρμακεία",
            width: 170,
            right: 370,
            top: 10,
            visible: false,
            calloutHTMLAppend: "<span>Νίκο, οι συντεταγμένες εδώ είναι %@%X  και %@%Y και ο τίτλος %@%T (δες τα placeholders!!!)<br/>Ημερομηνία: <br\>Να και η διεύθυνση: %@%A</span>"
        },
        {
            id: "noso",
            type: 1,
            url: 'http://mapsrv.xo.gr/ArcGIS/rest/services/xo_efimerebonta/MapServer/',
            url_attrs: "layers=show:1,3", /*&layerDefs=1:efActive>0*/
            identifyable: true,
            url_attrs_identify: "layers=all:1&tolerance=10",
            identify_maptip_layer: "1",
            identify_maptip_fields: "efName,efEidikotita",
            layerName: "TerraDemo.DBO.EFIMEREBONTA_NOSOK",
            //identify_condition: ["efActive", ">0"],
            identify_attrs: ["efName", "efAddress", "efTel","efEidikotita","efStart1","efEnd1","efStart2","efEnd2"],
            identify_attrs_labels: ["", "", "Τηλ. ", ""," από "," έως "," και από "," έως"],
            identify_attrs_placeholders: ["%@%T", "%@%A","", "", "","","","",""],
            identify_group_by: [[3,4,5,6],0,"Κλινικές: <br/>"],
            minLevel: 3,
            maxLevel: 14,
            minIdentifyLevel: 7,
            text: "Εφημερεύοντα Νοσοκομεία",
            width: 170,
            right: 550,
            top: 10,
            visible: false,
            calloutHTMLAppend: "<span>Νίκο, οι συντεταγμένες εδώ είναι %@%X  και %@%Y και ο τίτλος %@%T (δες τα placeholders!!!)<br/>---------------------------------------------------------------------------------------------------------------------------------------</span>"
        }

    ],
    CalloutTypes:
    [
        {
            id: "CalloutType1",
            mode: "2_state", // "1_state", "2_state",
            width: 250,
            height: 201,
            width2: 550,
            height2: 401,
            toggleModeImg_1_to_2: "MapResources/images/maximize.png",
            toggleModeImg_2_to_1: "MapResources/images/minimize.png",
            closeImg: "MapResources/images/close_grey.png"
        },
        {
            id: "CalloutType2",
            mode: "2_state", // "1_state", "2_state",
            width: 250,
            height: 201,
            width2: 300,
            height2: 401,
            toggleModeImg_1_to_2: "MapResources/images/maximize.png",
            toggleModeImg_2_to_1: "MapResources/images/minimize.png",
            closeImg: "MapResources/images/close_grey.png"
        }

    ]
}
;

////////////////////////////////
// Context menu
var ContextMenuItemHeight = 15;

////////////////////////////////
// Drag'n'Drop
var DragDropPinEfect = 15;



////////////////////////////////
// Pins
var XOPinWidth = 37;
var XOPinHeight = 34;
var XOPinCenterX = 12;
var XOPinCenterY = 34;

var PoiPinWidth1 = 28;
var PoiPinHeight1 = 36;
var PoiPinCenterX1 = 11;
var PoiPinCenterY1 = 36;

var PoiPinWidth2 = 32;
var PoiPinHeight2 = 45;
var PoiPinCenterX2 = 11;
var PoiPinCenterY2 = 43;

var PoiPinWidth3 = 32;
var PoiPinHeight3 = 45;
var PoiPinCenterX3 = 12;
var PoiPinCenterY3 = 42;

////////////////////////////////
// Callouts
var CalloutWidth1 = 219;
var CalloutHeight1 = 184;
var CalloutCenterX1 = 175;
var CalloutCenterY1 = 184;

var CalloutWidth2 = 238;
var CalloutHeight2 = 237;
var CalloutCenterX2 = 189;
var CalloutCenterY2 = 238;


var CalloutCloseLeft1 = 200;
var CalloutCloseTop1 = 8;
var CalloutCloseImg1 = "MapResources/images/close_grey.png";


var CalloutCloseLeft2 = 218;
var CalloutCloseTop2 = 6;
var CalloutCloseImg2 = "MapResources/images/close_grey.png";

var CalloutDivLeft1 = 25;
var CalloutDivTop1 = 25;

var CalloutDivLeft2 = 21;
var CalloutDivTop2 = 22;

var CalloutWidthMap = 400;
var CalloutHeightMap = 300;
//var CalloutCenterXMap = 191;
//var CalloutCenterYMap = 238;

var CalloutCloseLeftMap = 275;
var CalloutCloseTopMap = 5;
var CalloutImgMap       = "MapResources/images/balloon_300x300_2.png";
var CalloutCloseImgMap  = "MapResources/images/close_grey.png";
var CalloutDivLeftMap = 10;
var CalloutDivTopMap = 10;

var VisibleExtentBufferTop=184;
var VisibleExtentBufferBottom=90;
var VisibleExtentBufferLeft=10;
var VisibleExtentBufferRight=90;

var CalloutLinkLeft1 = 125;
var CalloutLinkTop1 = 8;
var CalloutLinkImg1 = "MapResources/images/drive.png";

var CalloutLinkLeft2 = 140;
var CalloutLinkTop2 = 6;
var CalloutLinkImg2 = "MapResources/images/drive.png";



// Identify Callout & pin
var PoiPinWidth_Identify = 28;
var PoiPinHeight_Identify = 36;
var PoiPinCenterX_Identify = 11;
var PoiPinCenterY_Identify = 36;

var CalloutWidth_Identify = 219;
var CalloutHeight_Identify = 184;
var CalloutCenterX_Identify = 175;
var CalloutCenterY_Identify = 184;

var CalloutDivLeft_Identify = 25;
var CalloutDivTop_Identify = 25;

var CalloutLinkLeft_Identify = 125;
var CalloutLinkTop_Identify = 8;
var CalloutLinkImg_Identify = "MapResources/images/drive.png";

var CalloutCloseLeft_Identify = 200;
var CalloutCloseTop_Identify = 8;
var CalloutCloseImg_Identify = "MapResources/images/close_grey.png";



/////////////////////

function EventAfterCalculateRoute() {

}


////////////////////////////////
// NEW Callouts!!!
var NewCalloutWidth_Identify_Big = 550;
var NewCalloutHeight_Identify_Big = 401;
var NewCalloutWidth_Identify_Small = 250;
var NewCalloutHeight_Identify_Small = 201;


var CalloutToggleModeImg_Identify = "MapResources/images/close_grey.png";
var CalloutToggleModeImg_Identify_Minimize = "MapResources/images/minimize.png";
var CalloutToggleModeImg_Identify_Maximize = "MapResources/images/maximize.png";

