<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.master" AutoEventWireup="true" CodeFile="ManageNews.aspx.cs" Inherits="Administrators_ManageNews" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <Cwx121:ManageNewses runat="server" ID="ManageNewses" />
</asp:Content>

