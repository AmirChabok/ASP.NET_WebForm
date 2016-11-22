<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Register.ascx.cs" Inherits="UserControls_WebUserControl" %>

<div class="container">

    <div id="divPageMessage" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessage" runat="server" />
    </div>

    <asp:ValidationSummary ID="myValidationSummary" runat="server" CssClass="panel panel-danger" EnableClientScript="true"
        DisplayMode="BulletList" HeaderText="<%$Resources:Messages,ErrorMessage007 %>" ShowSummary="true" ShowMessageBox="false" />

    <br />

    <div class="panel panel-success">

        <div class="panel-heading">
            <asp:Literal ID="litLegend" runat="server" Text="<%$Resources:Captions,Register%>" />
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
                <asp:Label ID="lblPassword" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,Password%>" />


                <div class="col-md-10">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" MaxLength="20" TextMode="Password" placeholder="<%$Resources:Captions,Password%>" />

                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                        CssClass="danger" EnableClientScript="true" Text="*"
                        SetFocusOnError="true" Display="Dynamic" />

                    <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="true"
                        CssClass="danger" Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage009 %>"
                        ValidationExpression="[a-zA-Z0-9]{6,20}" />
                </div>

            </div>



            <div class="form-group">

                <asp:Label ID="lblConfirmPassword" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,ConfirmPassword%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="form-control" MaxLength="30" TextMode="Password" placeholder="<%$Resources:Captions,ConfirmPassword%>" />

                    <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server"
                        ControlToValidate="txtConfirmPassword" CssClass="danger"
                        Display="Dynamic" EnableClientScript="true"
                        SetFocusOnError="true" Text="*" />

                    <asp:CompareValidator ID="cmvConfirmPassword" runat="server"
                        ControlToValidate="txtConfirmPassword" CssClass="danger"
                        Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                        Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage011 %>"
                        Type="String" CultureInvariantValues="true" ControlToCompare="txtPassword"
                        Operator="Equal" />
                </div>

            </div>

            <br />

            <div class="form-group">

                <asp:Label ID="lblEmail" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,Email%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" MaxLength="30" placeholder="<%$Resources:Captions,Email%>" />

                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                        ControlToValidate="txtEmail" CssClass="danger"
                        Display="Dynamic" EnableClientScript="true"
                        SetFocusOnError="true" Text="*" />
                    <asp:RegularExpressionValidator ID="revEmail" runat="server"
                        ControlToValidate="txtEmail" CssClass="danger"
                        Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                        Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage010%>"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                </div>

            </div>

            <br />

            <div class="form-group">

                <asp:Label ID="lblMobile" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,Mobile%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" MaxLength="30" placeholder="<%$Resources:Captions,Mobile%>" />

                    <asp:RequiredFieldValidator ID="rfvMobile" runat="server"
                        ControlToValidate="txtMobile" CssClass="danger"
                        Display="Dynamic" EnableClientScript="true"
                        SetFocusOnError="true" Text="*" />
                    <asp:RegularExpressionValidator ID="revMobile" runat="server"
                        ControlToValidate="txtMobile" CssClass="danger"
                        Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                        Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage025%>"
                        ValidationExpression="[0-9]{11,11}" />
                </div>

            </div>

        </div>

        <br />

    </div>

    <div class="panel">
        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-warning" Text="<%$Resources:Buttons,Submit %>" OnClick="btnSubmit_Click" />

    </div>

</div>



