<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/Main.Master" AutoEventWireup="true" CodeBehind="address_search.aspx.cs" Inherits="MapsV3.Prototyping.address_search" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="server">
    <title>Διαδρομή</title>
    <link href="styles/address_main.css" rel="stylesheet" type="text/css" />
    <script src="scripts/main.js" type="text/javascript"></script>
    <script src="scripts/address-search.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="ContentTabArea" ContentPlaceHolderID="tabArea" runat="server">
    <%--<li><a href="#">
        <img src="../media/images/home-icon.png" />
    </a></li>
    <li><a href="#"><span>Επιχειρήσεις</span> </a></li>--%>
    <li class="map-tab-selected">
        <asp:HyperLink ID="linkAddress" runat="server" NavigateUrl="~/address_search.aspx">
            <asp:Label ID="lblAddress" runat="server" Text="Διεύθυνση"></asp:Label>
        </asp:HyperLink>
    </li>
    <li>
        <asp:HyperLink ID="linkRoute" runat="server" NavigateUrl="~/route_search.aspx">
            <asp:Label ID="lblRoute" runat="server" Text="Διαδρομή"></asp:Label>
        </asp:HyperLink>
    </li>
    <%--<li><a href="#"><span>Ακτοπλοϊκά Δρομολόγια</span> </a></li>
    <li><a href="#"><span>Σημεία Ενδιαφέροντος</span> </a></li>--%>
</asp:Content>

<asp:Content ID="ContentMainArea" ContentPlaceHolderID="mainArea" runat="server">
<div id="search-container">
    <div id="search-form">
        <div class="section-header">
            Εντοπισμός Διεύθυνσης
        </div>
        <div id="search-from" style="border: solid 0px green;">
            <div class="address-header">
                <asp:Label ID="lblAddressHeader" runat="server" Text="Πού;" CssClass="search-from-where"></asp:Label>
            </div>
            <div style="border: solid 0px green;">
                <asp:TextBox ID="txt" runat="server" Text="Οδός Αριθμός Πόλη ΤΚ"></asp:TextBox>
            </div>
        </div>
    </div>
    <!-- SEARCH OPTIONS [Begin] -->
    <div id="search-actions" style="border: solid 0px green;">
        <div class="option-submit">
            <asp:ImageButton ID="btnSearchRouteCar" runat="server" ImageUrl="~/media/images/el/search-button.png" />
        </div>
    </div>
</div>
</asp:Content>