<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.ascx.cs" Inherits="UserControls_ChangePassword" %>

<div class="container">

    <div id="divPageMessages" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessages" runat="server" />
    </div>


    <asp:ValidationSummary ID="myValidationSummary" runat="server" CssClass="panel panel-danger" EnableClientScript="true"
        DisplayMode="BulletList" HeaderText="<%$Resources:Messages,ErrorMessage007 %>" ShowSummary="true" ShowMessageBox="false" />

    <br />


    <div class="panel panel-primary">

        <div class="panel-heading">
            <asp:Literal ID="litLegend" runat="server" Text="<%$Resources:Buttons,ChangePassword%>" />
        </div>

        <div class="panel-body">

            <div class="form-group">
                <asp:Label ID="lblUsername" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,Username%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" MaxLength="20" placeholder="<%$Resources:Captions,Username%>" />

                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername"
                        CssClass="danger" EnableClientScript="true" Text="*"
                        SetFocusOnError="true" Display="Dynamic" />

                    <asp:RegularExpressionValidator ID="revUsername" runat="server" ControlToValidate="txtUsername"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="true"
                        CssClass="danger" Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage008 %>"
                        ValidationExpression="[a-zA-Z0-9]{4,20}" />
                </div>

            </div>


            <br />


            <div class="form-group">
                <asp:Label ID="lblPassword" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,NewPassword%>" />


                <div class="col-md-10">
                    <asp:TextBox ID="txtNewPassword" runat="server" CssClass="form-control" MaxLength="20" TextMode="Password" placeholder="<%$Resources:Captions,NewPassword%>" />

                    <asp:RequiredFieldValidator ID="rfvNewPassword" runat="server" ControlToValidate="txtNewPassword"
                        CssClass="danger" EnableClientScript="true" Text="*"
                        SetFocusOnError="true" Display="Dynamic" />

                    <asp:RegularExpressionValidator ID="revNewPassword" runat="server" ControlToValidate="txtNewPassword"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="true"
                        CssClass="danger" Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage009 %>"
                        ValidationExpression="[a-zA-Z0-9]{6,20}" />
                </div>

            </div>



        </div>

    </div>



    <div class="panel">
        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,ChangePassword %>" OnClick="btnSubmit_Click" />

    </div>



</div>



