<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ForgetPassword.ascx.cs" Inherits="UserControls_ForgetPassword" %>

<div class="container">

    <div id="divPageMessage" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessage" runat="server" />
    </div>

    <asp:ValidationSummary ID="myForgetPasswordValidation" runat="server"
        EnableClientScript="true" CssClass="panel panel-danger" DisplayMode="BulletList"
        ShowSummary="true" ShowMessageBox="false" HeaderText="<%$Resources:Messages,ErrorMessage007 %>"
        ValidationGroup="ForgetPassword" />

    <div class="panel panel-primary">

        <div class="panel-heading">
            <asp:Literal ID="litLegend" runat="server" Text="<%$Resources:Captions,FPU%>" />
        </div>

        <div class="panel-body">

            <div class="form-group">

                <asp:Label ID="lblForgetPassword" runat="server" Text="<%$Resources:Captions,Username%>" CssClass="col-md-2" />


                <div class="col-md-10">
                    <asp:TextBox ID="txtForgetPassword" runat="server" MaxLength="40" CssClass="form-control" placeholder="<%$Resources:Captions,Username%>" />
                    <asp:RequiredFieldValidator ID="rfvForgetPassword" runat="server" CssClass="danger"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="true" Text="*"
                        ErrorMessage="<%$Resources:Messages,ErrorMessage012 %>" ControlToValidate="txtForgetPassword"
                        ValidationGroup="ForgetPassword" />

                    <asp:RegularExpressionValidator ID="revForgetPassword" runat="server" ControlToValidate="txtForgetPassword"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="true"
                        CssClass="danger" Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage008 %>"
                        ValidationExpression="[a-zA-Z0-9]{4,20}" ValidationGroup="ForgetPassword" />
                </div>

            </div>

        </div>

        <br />
    </div>

    <div class="panel">
        <asp:Button ID="btnForgetPassword" CssClass="btn btn-primary" runat="server" Text="<%$Resources:Buttons,Submit %>" AccessKey="S" ValidationGroup="ForgetPassword" OnClick="btnForgetPassword_Click" />
    </div>

</div>

<br />

<div class="container">

    <asp:ValidationSummary ID="myForgetPasswordValidation1" runat="server"
        EnableClientScript="true" CssClass="panel panel-danger" DisplayMode="BulletList"
        ShowSummary="true" ShowMessageBox="false" HeaderText="<%$Resources:Messages,ErrorMessage007 %>"
        ValidationGroup="ForgetPassword2" />

    <div class="panel panel-primary">

        <div class="panel-heading">
            <asp:Literal ID="litLegend2" runat="server" Text="<%$Resources:Captions,FPE%>" />
        </div>

        <div class="panel-body">

            <div class="form-group">


                <div class="lable">
                    <asp:Label ID="lblEmail" runat="server" Text="<%$Resources:Captions,Email%>" CssClass="col-md-2" />
                </div>

                <div class="col-md-10">
                    <asp:TextBox ID="txtEmail" runat="server" MaxLength="40" CssClass="form-control" placeholder="<%$Resources:Captions,Email%>" />

                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" CssClass="danger"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="true" Text="*"
                        ErrorMessage="<%$Resources:Messages,ErrorMessage012 %>" ControlToValidate="txtEmail"
                        ValidationGroup="ForgetPassword2" />

                    <asp:RegularExpressionValidator ID="revEmail" runat="server"
                        ControlToValidate="txtEmail" CssClass="danger"
                        Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                        Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage010%>"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ValidationGroup="ForgetPassword2" />
                </div>

            </div>

        </div>

        <br />
    </div>

    <div class="panel">
        <asp:Button ID="btnForgetPassword2" CssClass="btn btn-primary" runat="server" Text="<%$Resources:Buttons,Submit %>" AccessKey="S" ValidationGroup="ForgetPassword2" OnClick="btnForgetPassword2_Click" />
    </div>

</div>






