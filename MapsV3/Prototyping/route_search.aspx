<%@ Page Language="C#" MasterPageFile="~/Shared/Main.Master" AutoEventWireup="true" CodeBehind="route_search.aspx.cs" Inherits="MapsV3.Prototyping.route_search" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Διαδρομή</title>
    <link href="styles/route_main.css" rel="stylesheet" type="text/css" />
    <link href="styles/route_car.css" rel="stylesheet" type="text/css" />
    <link href="styles/route_pedestrian.css" rel="stylesheet" type="text/css" />
    <link href="styles/route_mmm.css" rel="stylesheet" type="text/css" />
    <link href="styles/route_planner.css" rel="stylesheet" type="text/css" />
    

    <script src="scripts/main.js" type="text/javascript"></script>
    <script src="scripts/route-search.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="ContentTabArea" ContentPlaceHolderID="tabArea" runat="server">
    <%--<li><a href="#">
        <img src="../media/images/home-icon.png" />
    </a></li>
    <li><a href="#"><span>Επιχειρήσεις</span> </a></li>--%>
    <li>
        <asp:HyperLink ID="linkAddress" runat="server" NavigateUrl="~/address_search.aspx">
            <asp:Label ID="lblAddress" runat="server" Text="Διεύθυνση"></asp:Label>
        </asp:HyperLink>
    </li>
    <li class="map-tab-selected">
        <asp:HyperLink ID="linkRoute" runat="server" NavigateUrl="~/route_search.aspx">
            <asp:Label ID="lblRoute" runat="server" Text="Διαδρομή"></asp:Label>
        </asp:HyperLink>
    </li>
    <%--<li><a href="#"><span>Ακτοπλοϊκά Δρομολόγια</span> </a></li>
    <li><a href="#"><span>Σημεία Ενδιαφέροντος</span> </a></li>--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainArea" runat="server">
    <!-- SEARCH FORM SECTION [Begin] -->
    <%--<div style="border:solid 1px green; height:90%; width:100%">--%>
    <div id="search-container">
        <div id="search-form" style="border: solid 0px gray;">
            <div class="section-header">
                Σημεία Διαδρομής
            </div>
            <div id="search-from" style="border: solid 0px green;">
                <%--<div id="point-a" style="border:solid 0px gray">--%>
                <div style="float: left; border: solid 0px red; padding-right: 5px; padding-top: 1px;">
                    <img src="media/images/el/A.png" alt="" />
                </div>
                <div style="float: left; border: solid 0px green;">
                    <input name="from" type="text" id="from" style="color: silver;" value="Αφετερία" />
                </div>
                <%--<div style="float: left; border: solid 0px red; padding-left: 2px">
                    <img src="media/images/icon-22x22.png" alt="" />
                </div>--%>
                <div style="float: left; border: solid 0px red; padding-left: 4px; padding-top: 4px;">
                    <img src="media/images/icon-close-12x12.png" alt="" />
                </div>
                <%--</div>--%>
            </div>
            <div id="search-to" style="border: solid 0px red;">
                <%--<div id="point-b">--%>
                <div style="float: left; border: solid 0px green; padding-right: 5px;">
                    <img src="media/images/el/B.png" alt="" />
                </div>
                <div style="float: left; border: solid 0px red">
                    <input name="from" type="text" id="Text1" style="color: silver;" value="Προορισμός" />
                </div>
                <%--<div style="float: left; border: solid 0px red; padding-left: 2px">
                    <img src="media/images/icon-22x22.png" alt="" />
                </div>--%>
                <div style="float: left; border: solid 0px red; padding-left: 4px; padding-top: 4px;">
                    <img src="media/images/icon-close-12x12.png" alt="" />
                </div>
                <%--</div>--%>
            </div>
        </div>
        <!-- SEARCH OPTIONS [Begin] -->
        <div id="search-actions" style="border: solid 0px green;">
            <div class="option-item">
                <div class="option-element">
                    <img src="media/images/add-point.gif" alt="" />
                </div>
                <div class="option-element">
                    <a href="#"><span>Προσθήκη</span></a>
                </div>
            </div>
            <div class="option-item">
                <div class="option-element">
                    <img src="media/images/revert.gif" alt="" />
                </div>
                <div class="option-element">
                    <a href="#"><span>Αντιστροφή</span></a>
                </div>
            </div>
        </div>
        <!-- SEARCH OPTIONS [End] -->
        <asp:TabContainer ID="ContSearchOpts" runat="server" CssClass="gray" ActiveTabIndex="0">
            <asp:TabPanel ID="tabCar" runat="server">
                <contenttemplate>
                    <asp:TabContainer ID="tabCar_inner" runat="server" CssClass="gray">
                        <asp:TabPanel ID="car_opts" runat="server">
                            <HeaderTemplate>
                                Προτιμήσεις
                            </HeaderTemplate>
                            <ContentTemplate>
                                <asp:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlFrmOptsPOI"
                                        CollapsedSize="0" ExpandedSize="50" Collapsed="false" ExpandControlID="lblExpandCollapsePOI"
                                        CollapseControlID="lblExpandCollapsePOI" AutoCollapse="False" AutoExpand="False"
                                        ScrollContents="false" ImageControlID="imgExpandCollapsePOI" ExpandedImage="~/media/images/expanded-option.png"
                                        CollapsedImage="~/media/images/collapsed-option.png" ExpandDirection="Vertical" />
                                <asp:Panel ID="pnlFrmOptsPOITitle" runat="server">
                                    <asp:Image ID="imgExpandCollapsePOI" runat="server" />
                                    <asp:Label ID="lblExpandCollapsePOI" runat="server" Text="Σημεία ενδιαφέροντος κατά τη διαδρομή"></asp:Label>
                                </asp:Panel>
                                <asp:Panel ID="pnlFrmOptsPOI" runat="server">
                                    <asp:Repeater ID="rptPOICetagories" runat="server">
                                        <HeaderTemplate>
                                            <div style="border: solid 0px green; height: 55px;">
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <div style="float: left; width: 113px; border: solid 0px silver; margin-top: 5px;">
                                                <div style="float: left; border: solid 0px green; padding: 0px 1px 2px 0px;">
                                                    <asp:RadioButton ID="rbtnPoi" runat="server" GroupName="poi_group" />
                                                </div>
                                                <div style="float: left; border: solid 0px silver; padding:0px">
                                                    <asp:Image ID="imgPoiIcon" runat="server" Width="18px" Height="18px" ImageUrl="~/media/images/icon-16x16.png" />
                                                </div>
                                                <div style="float: left; border: solid 0px silver; padding: 2px 0px 0px 4px;">
                                                    <asp:Label ID="lblPoiName" CssClass="poi-categ-name" runat="server" Text='<%# Eval("PoiName") %>'></asp:Label>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            </div>
                                        </FooterTemplate>
                                    </asp:Repeater>
                                </asp:Panel>
                                <asp:UpdatePanel ID="upnlOptsDrv" runat="server">
                                    <ContentTemplate>
                                        <asp:CollapsiblePanelExtender ID="cpe2" runat="Server" TargetControlID="pnlFrmOptsDriving"
                                            CollapsedSize="0" ExpandedSize="120" Collapsed="True" ExpandControlID="lblExpandCollapseDrv"
                                            CollapseControlID="lblExpandCollapseDrv" AutoCollapse="False" AutoExpand="False"
                                            ScrollContents="false" ImageControlID="imgExpandCollapseDrv" ExpandedImage="~/media/images/expanded-option.png"
                                            CollapsedImage="~/media/images/collapsed-option.png" ExpandDirection="Vertical" />
                                        <asp:Panel ID="pnlOptsDrvTitle" runat="server">
                                            <asp:Image ID="imgExpandCollapseDrv" runat="server" />
                                            <asp:Label ID="lblExpandCollapseDrv" runat="server" Text="Προτιμήσεις διαδρομής"></asp:Label>
                                        </asp:Panel>
                                        <asp:Panel ID="pnlFrmOptsDriving" runat="server">
                                            <div class="driving-line1" style="">
                                                <div class="line1-part1">
                                                    <input name="quickly-root" type="radio" value="" style="" />
                                                </div>
                                                <div class="line1-part2">
                                                    <span style="">Γρηγορότερη</span>
                                                </div>
                                                <div class="line1-part3">
                                                    <input name="syntomoteri" type="radio" value="" />
                                                </div>
                                                <div class="line1-part4">
                                                    <span>Συντομότερη</span>
                                                </div>
                                            </div>
                                            <div class="driving-line2">
                                                <div class="line2-part1">
                                                    <input name="" type="checkbox" value="" />
                                                </div>
                                                <div class="line2-part2">
                                                    Αποφυγή δακτυλίου
                                                </div>
                                            </div>
                                            <div class="driving-line3">
                                                <div class="line3-part1">
                                                    <input name="" type="checkbox" value="" />
                                                </div>
                                                <div class="line3-part2">
                                                    Αποφυγή διοδίων
                                                </div>
                                            </div>
                                            <div class="driving-line4" style="">
                                                <div class="line4-part1">
                                                    <input name="" type="checkbox" value="" />
                                                </div>
                                                <div class="line4-part2">
                                                    Αποφυγή ferry boat
                                                </div>
                                            </div>
                                            <div class="driving-line5" style="">
                                                <ul>
                                                    <li class="part1"><span>Απόσταση σε:</span> </li>
                                                    <li class="part2">
                                                        <input name="quickly-root" type="radio" value="" style="padding-left: 15px;" /></li>
                                                    <li class="part3">Χιλιόμετρα (km)</li>
                                                    <li class="part4">
                                                        <input name="syntomoteri" type="radio" value="" /></li>
                                                    <li class="part5">Μίλια (mi)</li>
                                                </ul>
                                            </div>
                                        </asp:Panel>
                                        
                                        <asp:CollapsiblePanelExtender ID="cpe3" runat="Server" TargetControlID="pnlFrmOptsCost"
                                            CollapsedSize="0" Collapsed="True" ExpandControlID="lblExpandCollapseCost" CollapseControlID="lblExpandCollapseCost"
                                            AutoCollapse="False" AutoExpand="False" ScrollContents="false" ImageControlID="imgExpandCollapseCost"
                                            ExpandedImage="~/media/images/expanded-option.png" CollapsedImage="~/media/images/collapsed-option.png"
                                            ExpandDirection="Vertical" Enabled="false" />
                                        <asp:Panel ID="pnlOptsCostTitle" runat="server" Visible="false">
                                            <asp:Image ID="imgExpandCollapseCost" runat="server" />
                                            <asp:Label ID="lblExpandCollapseCost" runat="server" Text="Υπολογισμός κόστους"></asp:Label>
                                        </asp:Panel>
                                        <asp:Panel ID="pnlFrmOptsCost" runat="server" Visible="false">
                                            <div class="cost-containtainer">
                                                <div class="header">
                                                    Νόμισμα:
                                                </div>
                                                <div>
                                                    <asp:DropDownList ID="ddlCurrency" runat="server" Width="140px">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="cost-containtainer">
                                                <div class="header">
                                                    Τύπος αυτοκινήτου:
                                                </div>
                                                <div>
                                                    <asp:DropDownList ID="ddlCarType" runat="server" Width="140px">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="cost-containtainer">
                                                <div class="header">
                                                    Τύπος βενζίνης:
                                                </div>
                                                <div>
                                                    <asp:DropDownList ID="ddlGasType" runat="server" Width="140px">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="cost-containtainer">
                                                <div class="header">
                                                    Κατανάλωση (λίτρα/χλμ):
                                                </div>
                                                <div>
                                                    <asp:DropDownList ID="ddlFuelConsum" runat="server" Width="140px">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="cost-containtainer">
                                                <div class="header-2">
                                                    Τιμή βενζίνης:
                                                </div>
                                                <div>
                                                    <asp:TextBox ID="txtFuelPrice" runat="server" Width="136px"></asp:TextBox>
                                                </div>
                                            </div>
                                        </asp:Panel>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <div class="option-submit">
                                    <asp:ImageButton ID="btnSearchRouteCar" runat="server" ImageUrl="~/media/images/el/search-button.png" />
                                </div>
                            </ContentTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="car_results" runat="server" Visible="false">
                            <HeaderTemplate>Αποτελέσματα</HeaderTemplate>
                        </asp:TabPanel>
                    </asp:TabContainer>
                </contenttemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tabPedestrian" runat="server">
                <contenttemplate>
                    <asp:Panel ID="pnlOptsPedestrian" runat="server">
                        <span>Προτιμήσεις διαδρομής</span>
                        <div class="pedestrian-line1">
                            <div class="line1-part1">
                                <span style="">Απόσταση σε:</span>
                            </div>
                            <div class="line1-part2">
                                <input name="chkWeekdays" type="radio" value="" style="" />
                            </div>
                            <div class="line1-part3">
                                <span style="">Χιλιόμετρα (km)</span>
                            </div>
                            <div class="line1-part4">
                                <input name="chkWeekdays" type="radio" value="" style="" />
                            </div>
                            <div class="line1-part5">
                                <span style="">Mίλια (mi)</span>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="option-submit">
                        <asp:ImageButton ID="btnSearchRoutePedest" runat="server" ImageUrl="~/media/images/el/search-button.png" />
                    </div>
                </contenttemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tabMMM" runat="server">
                <contenttemplate>
                    <asp:Panel ID="pnlOptsMMM" runat="server">
                        <span>Προτιμήσεις διαδρομής</span>
                        <div class="mmm-line1">
                            <div class="line1-part1">
                                <input name="chkWeekdays" type="radio" value="" style="" />
                            </div>
                            <div class="line1-part2">
                                <span style="">Καθημερινή</span>
                            </div>
                            <div class="line1-part3">
                                <input name="chkSaturday" type="radio" value="" style="" />
                            </div>
                            <div class="line1-part4">
                                <span style="">Σάββατο</span>
                            </div>
                            <div class="line1-part5">
                                <input name="chkSunday" type="radio" value="" style="" />
                            </div>
                            <div class="line1-part6">
                                <span style="">Κυριακή</span>
                            </div>
                        </div>
                        <div class="mmm-line2" style="">
                            <div>
                                <div class="">
                                    <input name="quickly-root" type="checkbox" value="" style="" />
                                </div>
                                <div class="line2-part1">
                                    <span style="">Μετρό</span>
                                </div>
                            </div>
                            <div>
                                <div class="">
                                    <input name="quickly-root" type="checkbox" value="" style="" />
                                </div>
                                <div class="line2-part2">
                                    <span style="">Tράμ</span>
                                </div>
                            </div>
                            <div>
                                <div class="">
                                    <input name="quickly-root" type="checkbox" value="" style="" />
                                </div>
                                <div class="line2-part3">
                                    <span style="">Ηλεκτρικός</span>
                                </div>
                            </div>
                            <div>
                                <div class="">
                                    <input name="quickly-root" type="checkbox" value="" style="" />
                                </div>
                                <div class="line2-part4">
                                    <span style="">Τρόλλεϋ</span>
                                </div>
                            </div>
                            <div>
                                <div class="">
                                    <input name="quickly-root" type="checkbox" value="" style="" />
                                </div>
                                <div class="line2-part5">
                                    <span style="">Λεοφωρείο</span>
                                </div>
                            </div>
                            <div>
                                <div class="">
                                    <input name="quickly-root" type="checkbox" value="" style="" />
                                </div>
                                <div class="line2-part6">
                                    <span style="">Προαστιακός</span>
                                </div>
                            </div>
                        </div>
                        <div class="mmm-line3">
                            <div>
                                <div class="">
                                    <input name="quickly-root" type="checkbox" value="" style="" />
                                </div>
                                <div class="line3-part1">
                                    <span style="">Δεν θέλω να αλλάξω μέσο στη διαδρομή</span>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="option-submit">
                        <asp:ImageButton ID="btnSearchRouteMMM" runat="server" ImageUrl="~/media/images/el/search-button.png" />
                    </div>
                </contenttemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="tabTrip" runat="server" Visible="false">
                <ContentTemplate>
                    <asp:Panel ID="pnlOptsTrip" runat="server">
                        <span>Υπολογισμός κόστους</span>
                        <div class="trip-line">
                            <div class="trip-line-cont">
                                <div class="header">
                                    Ημερομηνία Αναχώρησης:
                                </div>
                                <div>
                                    <asp:TextBox ID="txtDepartDate" runat="server" Width="102px" Height="15px"></asp:TextBox>
                                </div>
                                <div>
                                    <img src="media/images/calendar.png" alt="" height="23px" />
                                </div>
                            </div>
                            <div class="trip-line-cont">
                                <div class="header">
                                    Ώρα Αναχώρησης (απο αφετερία):
                                </div>
                                <div style="padding-top:1px;">
                                    <asp:DropDownList ID="ddlDepartTime" runat="server" Width="143px" Height="20px">
                                        <asp:ListItem>
                                            Επιλέξτε Ώρα
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            10:00
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            11:00
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            12:00
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            13:00
                                        </asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="option-submit">
                        <asp:ImageButton ID="btnSearchTrip" runat="server" ImageUrl="~/media/images/el/search-button.png" />
                    </div>
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    </div>
    <%--</div>--%>
    <!-- SEARCH FORM SECTION [End] -->
</asp:Content>
