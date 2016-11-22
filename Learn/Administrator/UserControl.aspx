<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.master" AutoEventWireup="true" CodeFile="UserControl.aspx.cs" Inherits="Administrators_UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" Runat="Server">
    <Cwx121:ManageUsers04 runat="server" id="ManageUsers04" />
</asp:Content>

