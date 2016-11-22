<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.master" AutoEventWireup="true" CodeFile="CreateNews.aspx.cs" Inherits="Administrators_CreateNews" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <Cwx121:CreateNewsletter runat="server" ID="CreateNewsletter" />
</asp:Content>

