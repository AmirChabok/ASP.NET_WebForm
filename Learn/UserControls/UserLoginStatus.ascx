<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserLoginStatus.ascx.cs" Inherits="UserControls_UserLoginStatus" %>

<ul class="top-menu">

    <li id="liLogin" runat="server">
        <asp:HyperLink ID="lnkLogin" runat="server" Text="ورود"
            NavigateUrl="~/Login.aspx" />&nbsp
    </li>


    <li id="liProfile" runat="server" style="color:ghostwhite">
        <asp:Label ID="lblWelcome" runat="server" />&nbsp

        <asp:HyperLink ID="lnkProfile" runat="server" Text="پروفایل"
            NavigateUrl="~/Users/UpdateProfile.aspx" />&nbsp
    </li>

    <li id="liAdmin" runat="server">
        <asp:HyperLink ID="lnkAdmin" runat="server" Text="صفحه مدیریت راهبر "
            NavigateUrl="~/Administrator/HomePage.aspx" />&nbsp
    </li>

    <li id="liRegister" runat="server">
        <asp:HyperLink ID="lnkRegister" runat="server" Text="ثبت نام"
            NavigateUrl="~/Register.aspx" />&nbsp
    </li>

    <li id="liLogout" runat="server">
        <asp:HyperLink ID="lnkLogout" runat="server" Text="خروج"
            NavigateUrl="~/Logout.aspx" />&nbsp
       
    </li>

    <li id="liCulture" runat="server">
        <asp:HyperLink ID="lnkculture" runat="server" Text="English "
            NavigateUrl="~/ChangeCulture.aspx?Culture=en-US" />&nbsp
    </li>




</ul>
