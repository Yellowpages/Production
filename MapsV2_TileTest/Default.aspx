<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>InfoteMapNew</title>
    
    <link href="resources/styles/StyleSheet.css" rel="stylesheet" type="text/css" />
    
    <script language="javascript" src="resources/js/browserdetect_lite.js" type="text/javascript"></script>
    <script language="javascript" src="resources/js/opacityOb.js" type="text/javascript"></script>
    <script language="javascript" src="resources/js/jquery-1.2.2.pack.js" type="text/javascript"></script>
    <script language="javascript" src="resources/js/jQuery_mousewheel_plugin.js" type="text/javascript"></script>
    <script language="javascript" src="resources/js/CacheParamsOb.js" type="text/javascript"></script>
    <script language="javascript" src="resources/js/PoiPinParams.js" type="text/javascript"></script>
    <script language="javascript" src="resources/js/PoiPinParams.js" type="text/javascript"></script>
    <script language="javascript" src="resources/js/mapOb.js" type="text/javascript"></script>
    <!--[if IE]><script type="text/javascript" src="resources/js/excanvas-compressed.js"></script><![endif]-->
</head>
<body onload="MyInit();">
    <form id="form1" runat="server">
    <div>
        <div id="MainMap"></div>
        <div id="OverviewMap"></div>
				<div id="myZoom"></div>
        <div id="debug" style="display:none;"></div>
    </div>
    </form>
	
	
    <script type="text/javascript" language="javascript">
    // Με true σερβίρουμε tiles οι ίδιοι, με false από roadexplorer
    /////////////////////////////////////////////////////////////////////////
    handlers_url="http://map.xo.gr/ypnewera/";

    function MyInit()
    {
    
        // 5 Υποχρεωτικές γραμμές 
        /////////////////////////////////////////////////////////////////////////
        var n;
        var MinZoomOut=5; //Όσο πιό μικρό τόσο πιο πολύ zoom out μπορεί να κάνει ο χρήστης. Τιμές 0-13
        //myMap = new GV_Map('MainMap',MinZoomOut, 0 , true, false,n,false, false);
		myMap = new GV_Map('MainMap',MinZoomOut, 0 , true, false,n,false, false,n,n, "myZoom");				
		myOverviewMap = new GV_Map('OverviewMap',0, 0 , true, true, myMap);
        myMap.MyOverview = myOverviewMap;
        
        
        // Έτσι ζουμάρουμε
        /////////////////////////////////////////////////////////////////////////
        //myMap.Zoom(4);
       
        // Έτσι panάρουμε
        /////////////////////////////////////////////////////////////////////////
        //var WithAnimation=false; //Προσοχή, αν έχουμε ζουμάρει με κώδικα πριν πρέπει να βάλουμε WithAnimation=false
        //myMap.CenterAtCoords(477639, 4202596,0,0,WithAnimation);
        
        
        // Έτσι βάζουμε pin (και κεντράρουμε εάν WithAnimation=true)
        /////////////////////////////////////////////////////////////////////////
        var WithAnimation=false;
		
				var myaddr = 'Πίνδου 10 Παπάγος Αττικής' ;

		
		
		var co_html='<div id=\"text\"><b>Βρίσκεστε εδώ : </b>' + myaddr + '<p style=\"margin-top:3px;\">Επιλέξτε ένα από τα σημεία που σημειώνονται στο χάρτη για περισσότερες πληροφορίες σχετικά με την επιχείρηση.</p></div>';
//		var co_html1='<b>SCANNER FM 102,2</b><br/><span class="address">ΛΑΡΙΣΗΣ 15<br/>ΑΜΠΕΛΩΝΑΣ, 40400 <br/>ΤΥΡΝΑΒΟΣ ΛΑΡΙΣΗΣ <br/>Τηλ. :2492031404 <hr/></span><b>SCANNER FM 102,2</b><br/><span class="address">ΛΑΡΙΣΗΣ 15<br/>ΑΜΠΕΛΩΝΑΣ, 40400 <br/>ΤΥΡΝΑΒΟΣ ΛΑΡΙΣΗΣ <br/>Τηλ. :2492031404 </span>';
//		var co_html2='<b>SCANNER FM 102,2</b><br/><span class="address">ΛΑΡΙΣΗΣ 15<br/>ΑΜΠΕΛΩΝΑΣ, 40400 <br/>ΤΥΡΝΑΒΟΣ ΛΑΡΙΣΗΣ <br/>Τηλ. :2492031404 </span>';		
		myMap.InsertPinInfote(482423.0,4204560.0,co_html,'myid',1);
myMap.InsertPoiPinInfote(482600,4204518,'<div id="text"><b>ΚΑΡΥΩΤΑΚΗΣ ΕΠΑΜΕΙΝΩΝΔΑΣ Γ.</b><br/><span class="address">ΑΝΑΤΟΛΗΣ 19<br/>155 62<br/>ΧΟΛΑΡΓΟΣ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106524475</span></div>',1,'id14113580',1);
myMap.InsertPoiPinInfote(482162,4204705,'<div id="text"><b>ΚΥΤΕΑΣ ΚΩΝΣΤΑΝΤΙΝΟΣ</b><br/><span class="address">25ΗΣ ΜΑΡΤΙΟΥ 31<br/>155 62<br/>ΧΟΛΑΡΓΟΣ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106546537</span></div>',1,'id14113770',1);
myMap.InsertPoiPinInfote(482389,4204739,'<div id="text"><b>ΜΑΤΘΑΙΟΥ ΠΕΡΙΚΛΗΣ</b><br/><span class="address">ΣΑΡΑΝΤΑΠΟΡΟΥ 128<br/>ΠΑΠΑΓΟΥ 156 69<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106510443</span></div>',1,'id23916754',1);
myMap.InsertPoiPinInfote(482203,4204743,'<div id="text"><b>ΜΑΚΡΗΣ ΑΝΤΩΝΙΟΣ</b><br/><span class="address">25ης Μαρτίου 2<br/>Χολαργός 155 61<br/>Χολαργού Αθηνών <br/>Τηλ. :2106542238</span></div>',2,'id41709971',1);
myMap.InsertPoiPinInfote(482497,4204854,'<div id="text"><b>ΝΙΚΟΛΗ-ΚΩΝΣΤΑΝΤΑΤΟΥ ΝΙΚΟΛΕΤΤΑ</b><br/><span class="address">ΜΠΟΥΜΠΟΥΛΙΝΑΣ 5<br/>ΧΟΛΑΡΓΟΣ 155 62<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106523780</span></div>',1,'id23916773',1);
myMap.InsertPoiPinInfote(480207,4204856,'<div id="text"><b>ΜΟΥΣΚΟΥ ΣΤΕΛΛΑ</b><br/><span class="address">Λ. ΜΕΣΟΓΕΙΩΝ 177<br/>ΑΘΗΝΑ 115 25<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106547801</span></div>',1,'id23916792',1);
myMap.InsertPoiPinInfote(480207,4204856,'<div id="text"><b>ΒΑΡΑΚΗΣ ΓΕΩΡΓΙΟΣ Ν.</b><br/><span class="address">ΜΕΣΟΓΕΙΩΝ ΛΕΩΦ. 177<br/>115 25<br/>ΑΘΗΝΑ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106742427</span></div>',1,'id41619892',1);
myMap.InsertPoiPinInfote(481868,4204908,'<div id="text"><b>ΜΟΥΡΤΖΟΠΟΥΛΟΥ ΑΙΚΑΤΕΡΙΝΗ</b><br/><span class="address">ΕΡΑΤΟΥΣ 4<br/>ΠΑΠΑΓΟΥ 156 69<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106528740</span></div>',1,'id23916780',1);
myMap.InsertPoiPinInfote(482546,4205168,'<div id="text"><b>ΠΑΥΛΟΠΟΥΛΟΥ ΙΩΑΝΝΑ</b><br/><span class="address">ΑΘ ΔΙΑΚΟΥ 2<br/>ΧΟΛΑΡΓΟΣ 155 62<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106549551</span></div>',1,'id23916796',1);
myMap.InsertPoiPinInfote(483088,4205234,'<div id="text"><b>ΣΑΡΙΦΙ-ΧΑΤΖΗΠΑΜΟΓ ΦΑΡΙΜΠΑ</b><br/><span class="address">ΔΟΙΡΑΝΗΣ 11<br/>ΧΟΛΑΡΓΟΣ 155 62<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106534488</span></div>',1,'id23916783',1);
myMap.InsertPoiPinInfote(482977,4205246,'<div id="text"><b>ΦΩΤΟΠΟΥΛΟΣ ΣΠΥΡ. I.</b><br/><span class="address">ΓΡΕΒΕΝΩΝ 4<br/>155 62<br/>ΧΟΛΑΡΓΟΣ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106512195</span></div>',1,'id14092118',1);
myMap.InsertPoiPinInfote(481676,4205485,'<div id="text"><b>ΜΠΑΙΜΠΑΣ ΕΥΣΤΑΘΙΟΣ</b><br/><span class="address">ΕΛ ΒΕΝ/ΛΟΥ 50<br/>ΧΟΛΑΡΓΟΣ 155 61<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106522273</span></div>',1,'id23916769',1);
myMap.InsertPoiPinInfote(483250,4205511,'<div id="text"><b>ΤΖΑΝΑΚΑΚΗΣ ΜΙΧΑΗΛ</b><br/><span class="address">ΚΥΚΛΑΔΩΝ 90<br/>ΑΓ.ΠΑΡΑΣΚΕΥΗ 153 41<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2107665928</span></div>',1,'id23917140',1);
myMap.InsertPoiPinInfote(482079,4205532,'<div id="text"><b>ΒΑΛΑΒΑΝΗ-ΚΑΡΑΜΙΙΧΑ ΜΑΡΙΑ</b><br/><span class="address">ΠΕΡΙΚΛΕΟΥΣ 42<br/>ΧΟΛΑΡΓΟΣ 155 61<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106528356</span></div>',1,'id23916779',1);
myMap.InsertPoiPinInfote(483944,4205598,'<div id="text"><b>ΤΣΕΛΙΦΗΣ ΘΩΜΑΣ</b><br/><span class="address">ΠΡ.ΗΛΙΑ 26<br/>ΑΓ.ΠΑΡΑΣΚΕΥΗ 153 43<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106549155</span></div>',1,'id23916795',1);
myMap.InsertPoiPinInfote(482012,4205632,'<div id="text"><b>ΚΑΡΑΜΑΝΤΖΑΝΗΣ ΙΩΑΝΝΗΣ</b><br/><span class="address">ΠΕΡΙΚΛΕΟΥΣ 29<br/>155 61<br/>ΧΟΛΑΡΓΟΣ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106545330</span></div>',1,'id14108567',1);
myMap.InsertPoiPinInfote(480179,4205647,'<div id="text"><b>ΦΡΕΤΖΑΓΙΑΣ ΑΝΔΡΕΑΣ</b><br/><span class="address">ΣΙΚΕΛΙΑΝΟΥ 8<br/>ΝΕΟ ΨΥΧΙΚΟ 115 25<br/>ΑΘΗΝΑ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106726996</span></div>',1,'id41641418',1);
myMap.InsertPoiPinInfote(480602,4205711,'<div id="text"><b>ΤΕΡΖΙΔΗΣ ΑΓΗΣ</b><br/><span class="address">ΣΙΚΕΛΙΑΝΟΥ 44<br/>ΑΘΗΝΑ, Ν. ΨΥΧΙΚΟ 154 51<br/>ΝΕΟ ΨΥΧΙΚΟ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106755832</span></div>',2,'id41683941',1);
myMap.InsertPoiPinInfote(481622,4205739,'<div id="text"><b>ΔΗΜΗΤΡΑΚΟΠΟΥΛΟΣ ΑΠΟΣΤ.</b><br/><span class="address">ΜΕΤΩΝΟΣ 70<br/>155 61<br/>ΧΟΛΑΡΓΟΣ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106535934</span></div>',1,'id14112852',1);
myMap.InsertPoiPinInfote(484077,4205814,'<div id="text"><b>ΣΕΡΒΙΤΖΟΓΛΟΥ ΜΑΡΙΝΑ</b><br/><span class="address">ΠΕΛΟΠΟΝΗΣΟΥ 45<br/>ΑΓ.ΠΑΡΑΣΚΕΥΗ 153 41<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :null</span></div>',1,'id23915780',1);
myMap.InsertPoiPinInfote(481738,4205922,'<div id="text"><b>ΜΑΖΑΝΗΣ ΣΠΥΡΙΔΩΝ</b><br/><span class="address">ΠΕΡΙΚΛΕΟΥΣ 3<br/>ΧΟΛΑΡΓΟΣ 155 61<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106515905</span></div>',1,'id23916763',1);
myMap.InsertPoiPinInfote(481702,4205927,'<div id="text"><b>ΤΣΑΓΓΑΡΗΣ ΓΕΩΡΓ. Ε.</b><br/><span class="address">ΠΕΡΙΚΛΕΟΥΣ ΛΕΩΦ. 2<br/>ΑΘΗΝΑ 155 61<br/>ΧΟΛΑΡΓΟΣ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106514740</span></div>',1,'id41623765',1);
myMap.InsertPoiPinInfote(481438,4205928,'<div id="text"><b>ΟΙΚΟΝΟΜΟΥ ΣΤΑΥΡΟΥΛΑ</b><br/><span class="address">ΞΑΝΘΟΥ 33Β<br/>Ν.ΨΥΧΙΚΟ 154 51<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106716603</span></div>',1,'id23916834',1);
myMap.InsertPoiPinInfote(481959,4205960,'<div id="text"><b>ΤΡΥΦΩΝΟΠΟΥΛΟΥ ΧΡΙΣΤΙΝΑ</b><br/><span class="address">ΒΟΥΤΣΙΝΑ 93<br/>ΧΟΛΑΡΓΟΣ 155 61<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106519758</span></div>',1,'id23916767',1);
myMap.InsertPoiPinInfote(481245,4206034,'<div id="text"><b>ΑΝΤΩΝΙΑΔΟΥ-ΚΟΥΜ ΙΩΑΝΝΑ</b><br/><span class="address">ΥΨΗΛΑΝΤΟΥ 35<br/>Ν.ΨΥΧΙΚΟ 154 51<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106723240</span></div>',1,'id23916843',1);
myMap.InsertPoiPinInfote(481080,4206091,'<div id="text"><b>ΜΙΧΑΛΟΔΗΜΗΤΡΑΚΗΣ ΔΗΜΗΤΡΙΟΣ</b><br/><span class="address">ΦΕΡΑΙΟΥ ΡΗΓΑ 9Β<br/>ΑΘΗΝΑ 154 51<br/>ΝΕΟ ΨΥΧΙΚΟ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106716493</span></div>',1,'id41645089',1);
myMap.InsertPoiPinInfote(482544,4206104,'<div id="text"><b>ΚΟΚΚΑΛΑ ΑΝΑΣΤΑΣΙΑ</b><br/><span class="address">17ΗΣ ΝΟΕΜΒΡΙΟΥ 26-30<br/>ΧΟΛΑΡΓΟΣ 155 62<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106538051</span></div>',1,'id23916786',1);
myMap.InsertPoiPinInfote(482035,4206115,'<div id="text"><b>ΚΑΦΡΙΤΣΑ ΠΑΝΑΓΙΩΤΑ</b><br/><span class="address">ΑΓΑΜΕΜΝΩΝΟΣ 13<br/>ΧΟΛΑΡΓΟΣ 155 61<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106544280</span></div>',1,'id23916790',1);
myMap.InsertPoiPinInfote(482141,4206141,'<div id="text"><b>ΡΑΠΤΗ ΕΛΕΝΗ</b><br/><span class="address">ΜΙΛΤΙΑΔΟΥ 6<br/><br/>ΧΟΛΑΡΓΟΣ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106518710</span></div>',1,'id23954462',1);
myMap.InsertPoiPinInfote(481758,4206158,'<div id="text"><b>ΧΡΙΣΤΟΠΟΥΛΟΣ ΣΠΥΡΟΣ</b><br/><span class="address">ΓΥΘΕΙΟΥ 21<br/>ΑΘΗΝΑ, ΧΑΛΑΝΔΡΙ 152 31<br/>ΧΑΛΑΝΔΡΙ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106717082</span></div>',1,'id41620797',1);
myMap.InsertPoiPinInfote(481972,4206168,'<div id="text"><b>ΔΕΔΟΥΚΟΥ ΞΑΝΘΗ</b><br/><span class="address">ΛΕΩΦ. ΜΕΣΟΓΕΙΩΝ 248<br/>155 61<br/>ΧΟΛΑΡΓΟΣ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106522134</span></div>',1,'id14113265',1);
myMap.InsertPoiPinInfote(480541,4206199,'<div id="text"><b>ΛΑΓΚΩΝΑ-ΣΤΑΘΗ ΕΥΑΓΓΕΛΙΑ</b><br/><span class="address">ΠΑΠΑΝΑΣΤΑΣΙΟΥ ΑΛΕΞ. 32<br/><br/>ΝΕΟ ΨΥΧΙΚΟ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106743078</span></div>',1,'id23955340',1);
myMap.InsertPoiPinInfote(481081,4206239,'<div id="text"><b>ΚΑΡΑΝΤΖΑ ΜΑΡΙΑ</b><br/><span class="address">25ΗΣ ΜΑΡΤΙΟΥ 38-40<br/>Ν.ΨΥΧΙΚΟ 154 71<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :null</span></div>',1,'id23915193',1);
myMap.InsertPoiPinInfote(481470,4206241,'<div id="text"><b>ΤΡΑΓΟΜΑΛΟΣ ΠΑΝΑΓΙΩΤΗΣ</b><br/><span class="address">ΚΑΛΑΜΑΤΑΣ 17<br/>ΧΑΛΑΝΔΡΙ 152 31<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106721380</span></div>',1,'id23916841',1);
myMap.InsertPoiPinInfote(481308,4206251,'<div id="text"><b>ΧΑΡΙΤΟΥ ΑΝΤΩΝΙΑ</b><br/><span class="address">ΤΖΑΒΕΛΛΑ 33<br/>ΧΑΛΑΝΔΡΙ 152 31<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106747177</span></div>',1,'id23916855',1);
myMap.InsertPoiPinInfote(482523,4206257,'<div id="text"><b>ΚΟΝΤΕ ΒΑΣΙΛΕΙΑ</b><br/><span class="address">ΧΙΟΥ 28<br/>ΧΟΛΑΡΓΟΣ 155 62<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106512004</span></div>',1,'id23916759',1);
myMap.InsertPoiPinInfote(481115,4206332,'<div id="text"><b>ΑΓΓΕΛΟΠΟΥΛΟΣ ΔΗΜΗΤΡΗΣ</b><br/><span class="address">25ΗΣ ΜΑΡΤΙΟΥ 71<br/>152 34<br/>ΝΕΟ ΨΥΧΙΚΟ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106726840</span></div>',1,'id14113206',1);
myMap.InsertPoiPinInfote(483372,4206540,'<div id="text"><b>ΣΩΤΗΡΟΠΟΥΛΟΥ ΦΩΤΕΙΝΗ</b><br/><span class="address">ΒΕΝΙΖΕΛΟΥ ΕΛ. 14<br/>ΑΘΗΝΑ 153 41<br/>ΑΓΙΑ ΠΑΡΑΣΚΕΥΗ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106535400</span></div>',1,'id41624304',1);
myMap.InsertPoiPinInfote(481407,4206597,'<div id="text"><b>ΒΑΣΙΛΕΙΟΥ ΚΑΛΛΙΡΟΗ</b><br/><span class="address">ΑΡΚΑΔΙΟΥ 20<br/>152 31<br/>ΧΑΛΑΝΔΡΙ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106749985</span></div>',1,'id14103722',1);
myMap.InsertPoiPinInfote(482885,4206954,'<div id="text"><b>ΠΕΡΒΑΝΙΔΟΥ ΠΑΝΑΓΙΩΤΑ</b><br/><span class="address">ΧΑΡΑΥΓΗΣ 26<br/>ΧΑΛΑΝΔΡΙ 159 32<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106833936</span></div>',1,'id23916900',1);
myMap.InsertPoiPinInfote(480207,4204856,'<div id="text"><b>ΒΑΡΑΚΗΣ ΓΕΩΡΓΙΟΣ Ν.</b><br/><br/><span class="address">ΜΕΣΟΓΕΙΩΝ ΛΕΩΦ. 177<br/>115 25<br/>ΑΘΗΝΑ ΑΤΤΙΚΗΣ <br/>Τηλ. :2106742427</span><br /><hr/><b>ΜΟΥΣΚΟΥ ΣΤΕΛΛΑ</b><br/><br/><span class="address">Λ. ΜΕΣΟΓΕΙΩΝ 177<br/>ΑΘΗΝΑ 115 25<br/> ΑΤΤΙΚΗΣ <br/>Τηλ. :2106547801</span><br /><hr/></div>',3,'x_id23916792',2);
//Map.ZoomToExtentWithCenter(482423.0,4204560.0,482600,4204518,482079,4205532);
//myMap.ZoomToExtentWithCenter(482423.0,4204560.0,481868,4204518,483088,4205246);		
myMap.ZoomToExtentWithCenter(482423.0,4204560.0,482600,4204518,481868,4204908);		
		
		
		
		
		/*
		//var co_html='<b class="here">Βρίσκεστε εδώ.</b><p>Επιλέξτε ένα από τα γύρω σημεία <img src="resources/images/png/1.png"/> για να πάρετε περισσότερες πληροφορίες.</p>';
		var co_html='<b>SCANNER FM 102,2</b><br/><span class="address">ΛΑΡΙΣΗΣ 15<br/>ΑΜΠΕΛΩΝΑΣ, 40400 <br/>ΤΥΡΝΑΒΟΣ ΛΑΡΙΣΗΣ <br/>Τηλ. :2492031404 <hr/></span><b>SCANNER FM 102,2</b><br/><span class="address">ΛΑΡΙΣΗΣ 15<br/>ΑΜΠΕΛΩΝΑΣ, 40400 <br/>ΤΥΡΝΑΒΟΣ ΛΑΡΙΣΗΣ <br/>Τηλ. :2492031404 </span>';

        myMap.InsertPinInfote(477639, 4202396, co_html,"myid",2);        
        myMap.InsertPoiPinInfote(477619, 4202596,"<div id=\"text\"><b>SCANNER FM 102,2</b><br/><span class=\"address\">ΛΑΡΙΣΗΣ 15<br/>ΑΜΠΕΛΩΝΑΣ, 40400 <br/>ΤΥΡΝΑΒΟΣ ΛΑΡΙΣΗΣ <br/>Τηλ. :2492031404 </div>", 1,"a1",1);          myMap.InsertPoiPinInfote(477929, 4202696,"good bye",1,"a2",1);
        myMap.InsertPoiPinInfote(477939, 4202796,"",2,"a3",1);
        myMap.InsertPoiPinInfote(477919, 4202096,"",2,"a4",1);
        myMap.InsertPoiPinInfote(477629, 4202096,"",2,"a5",1);
        myMap.InsertPoiPinInfote(477539, 4202096,"",2,"a6",1);
        myMap.InsertPoiPinInfote(477619, 4202196,"",2,"a7",1);
        myMap.InsertPoiPinInfote(477429, 4202196,"",2,"a8",1);
        myMap.InsertPoiPinInfote(477409, 4202196,"",2,"a9",1);
        myMap.InsertPoiPinInfote(477379, 4202196,"",3,"a10",1);
		

		//myMap.OpenCalloutById("a1");
		//myMap.ZoomToExtent(477409, 4202096,477939, 4202796);
		//myMap.ZoomToExtent(477639, 4203296,477639, 4202596);
        //myMap.InsertPinInfote(477629, 4202596, '',"myid",WithAnimation);        
        // Έτσι βάζουμε proximity pin
        /////////////////////////////////////////////////////////////////////////
       
        myMap.InsertPoiPinInfote(477629, 4202596,1,"a1");
        myMap.InsertPoiPinInfote(477629, 4202696,2,"a2");
        myMap.InsertPoiPinInfote(477629, 4202796,3,"a3");
        myMap.InsertPoiPinInfote(477629, 4202896,4,"a4");
        myMap.InsertPoiPinInfote(477629, 4202996,5,"a5");
        myMap.InsertPoiPinInfote(477629, 4203096,6,"a6");
        myMap.InsertPoiPinInfote(477629, 4203196,7,"a7");
        myMap.InsertPoiPinInfote(477629, 4203296,8,"a8");
        myMap.InsertPoiPinInfote(477629, 4203296,9,"a9");
        myMap.InsertPoiPinInfote(477629, 4203296,10,"a10");

        myMap.InsertPoiPinInfote(477739, 4202596,1,"a11");
        myMap.InsertPoiPinInfote(477639, 4202696,2,"a12");
        myMap.InsertPoiPinInfote(477639, 4202796,3,"a13");
        myMap.InsertPoiPinInfote(477639, 4202896,4,"a14");
        myMap.InsertPoiPinInfote(477639, 4202996,5,"a15");
        myMap.InsertPoiPinInfote(477639, 4203096,6,"a16");
        myMap.InsertPoiPinInfote(477639, 4203196,7,"a17");
        myMap.InsertPoiPinInfote(477639, 4203296,8,"a18");
        myMap.InsertPoiPinInfote(477639, 4203296,9,"a19");
        myMap.InsertPoiPinInfote(477639, 4203296,10,"a20");
        
        myMap.InsertPoiPinInfote(477649, 4202596,1,"a21");
        myMap.InsertPoiPinInfote(477649, 4202696,2,"a22");
        myMap.InsertPoiPinInfote(477649, 4202796,3,"a23");
        myMap.InsertPoiPinInfote(477649, 4202896,4,"a24");
        myMap.InsertPoiPinInfote(477649, 4202996,5,"a25");
        myMap.InsertPoiPinInfote(477649, 4203096,6,"a26");
        myMap.InsertPoiPinInfote(477649, 4203196,7,"a27");
        myMap.InsertPoiPinInfote(477649, 4203296,8,"a28");
        myMap.InsertPoiPinInfote(477649, 4203296,9,"a29");
        myMap.InsertPoiPinInfote(477649, 4203296,10,"a30");        
        
        myMap.InsertPoiPinInfote(477659, 4202596,1,"a31");
        myMap.InsertPoiPinInfote(477659, 4202696,2,"a32");
        myMap.InsertPoiPinInfote(477659, 4202796,3,"a33");
        myMap.InsertPoiPinInfote(477659, 4202896,4,"a34");
        myMap.InsertPoiPinInfote(477659, 4202996,5,"a35");
        myMap.InsertPoiPinInfote(477659, 4203096,6,"a36");
        myMap.InsertPoiPinInfote(477659, 4203196,7,"a37");
        myMap.InsertPoiPinInfote(477659, 4203296,8,"a38");
        myMap.InsertPoiPinInfote(477659, 4203296,9,"a39");
        myMap.InsertPoiPinInfote(477659, 4203296,10,"a40");
        
        myMap.InsertPoiPinInfote(477669, 4202596,1,"a41");
        myMap.InsertPoiPinInfote(477669, 4202696,2,"a42");
        myMap.InsertPoiPinInfote(477669, 4202796,3,"a43");
        myMap.InsertPoiPinInfote(477669, 4202896,4,"a44");
        myMap.InsertPoiPinInfote(477669, 4202996,5,"a45");
        myMap.InsertPoiPinInfote(477669, 4203096,6,"a46");
        myMap.InsertPoiPinInfote(477669, 4203196,7,"a47");
        myMap.InsertPoiPinInfote(477669, 4203296,8,"a48");
        myMap.InsertPoiPinInfote(477669, 4203296,9,"a49");
        myMap.InsertPoiPinInfote(477669, 4203296,10,"a50");
        
        myMap.InsertPoiPinInfote(477679, 4202596,"",1,"a51",1);
        myMap.InsertPoiPinInfote(477679, 4202696,"",2,"a52",1);
        myMap.InsertPoiPinInfote(477679, 4202796,"",1,"a53",1);
        myMap.InsertPoiPinInfote(477679, 4202896,"",2,"a54",1);
        myMap.InsertPoiPinInfote(477679, 4202996,"",1,"a55",1);
        myMap.InsertPoiPinInfote(477679, 4203096,"",2,"a56",1);
        myMap.InsertPoiPinInfote(477679, 4203196,"",3,"a57",1);
        myMap.InsertPoiPinInfote(477679, 4203296,"",1,"a58",1);
        myMap.InsertPoiPinInfote(477679, 4203296,"",2,"a59",1);
        myMap.InsertPoiPinInfote(477679, 4203296,"",1,"a60",1);
        
        myMap.InsertPoiPinInfote(477689, 4202596,"",1,"a61",1);
        myMap.InsertPoiPinInfote(477689, 4202696,"",1,"a62",1);
        myMap.InsertPoiPinInfote(477689, 4202796,"",1,"a63",1);
        myMap.InsertPoiPinInfote(477689, 4202896,"",2,"a64",1);
        myMap.InsertPoiPinInfote(477689, 4202996,"",2,"a65",1);
        myMap.InsertPoiPinInfote(477689, 4203096,"",1,"a66",1);
        myMap.InsertPoiPinInfote(477689, 4203196,"",3,"a67",1);
        myMap.InsertPoiPinInfote(477689, 4203296,"",2,"a68",1);
        myMap.InsertPoiPinInfote(477689, 4203296,"",1,"a69",1);
        myMap.InsertPoiPinInfote(477689, 4203296,"",1,"a70",1);
        
        myMap.InsertPoiPinInfote(477699, 4202596,"",1,"a71",1);
        myMap.InsertPoiPinInfote(477699, 4202696,"",2,"a72",1);
        myMap.InsertPoiPinInfote(477699, 4202796,"",1,"a73",1);
        myMap.InsertPoiPinInfote(477699, 4202896,"",1,"a74",1);
        myMap.InsertPoiPinInfote(477699, 4202996,"",2,"a75",1);
        myMap.InsertPoiPinInfote(477699, 4203096,"",2,"a76",1);
        myMap.InsertPoiPinInfote(477699, 4203196,"",2,"a77",1);
        myMap.InsertPoiPinInfote(477699, 4203296,"",1,"a78",1);
        myMap.InsertPoiPinInfote(477699, 4203296,"",1,"a79",1);
        myMap.InsertPoiPinInfote(477699, 4203296,"",1,"a80",1);                                
*/        
   
        // Έτσι ζουμάρουμε σε extent
        /////////////////////////////////////////////////////////////////////////
		//myMap.ZoomToExtentWithCenter(477639, 4202396, 477379, 4202096,477939, 4202796);
		//myMap.OpenCalloutById("a1");
        //myMap.ZoomToExtent(477639, 4203296,477639, 4202596);
    }

</script>
</body>
</html>
