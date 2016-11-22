<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.master" AutoEventWireup="true" CodeFile="CreateEvent.aspx.cs" Inherits="Administrators_CreateEvent"  ValidateRequest="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <Cwx121:CreateEvent runat="server" ID="CreateEvent" />
</asp:Content>

