<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultMenu.ascx.cs" Inherits="UserControls_DefaultMenu" %>
<ul class="nav navbar-nav">
    <li id="liHome" runat="server" class="navbar-item active"><a href="#menu-home" class="navbar-item-target">صفحه اصلی</a></li>
    <%--<li id="liProduct" runat="server" class="navbar-item"><a href="#menu-works" class="navbar-item-target">محصولات</a></li>--%>
    <%--<li id="liPrice" runat="server" class="navbar-item"><a href="#menu-pricing" class="navbar-item-target">جدول قیمت ها</a></li>--%>
    <li id="liBlog" runat="server" class="navbar-item"><a href="#menu-about" class="navbar-item-target">درباره ما</a></li>
    <li id="liContact" runat="server" class="navbar-item"><a href="#menu-contact" class="navbar-item-target">اطلاعات تماس</a></li>
        <li id="li1" runat="server" class="navbar-item"><a href="#menu-feedback" class="navbar-item-target">ارتباط با ما</a></li>
    <li id="liMember" runat="server" class="navbar-item"><a href="Register.aspx" class="navbar-item-target">ورود / عضویت </a></li>
    <li id="liAdmin" runat="server" class="navbar-item"><a href="../Administrator/HomePage.aspx" class="navbar-item-target">راهبر </a></li>
    <li id="liProfile" runat="server" class="navbar-item"><a href="../Users/UpdateProfile.aspx" class="navbar-item-target">پروفایل </a></li>
    <li id="liLogout" runat="server" class="navbar-item"><a href="Logout.aspx" class="navbar-item-target">خروج</a></li>
</ul>
