<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.master" AutoEventWireup="true" CodeFile="ManageContent.aspx.cs" Inherits="ManageContent" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <Cwx121:ManageContent runat="server" id="ManageContent1" />
</asp:Content>

