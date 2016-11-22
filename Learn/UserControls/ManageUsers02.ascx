<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageUsers02.ascx.cs" Inherits="Administrator_UserControls_MangeUsers02" %>

<div class="container">

    <div id="divPageMessage" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessage" runat="server" />
    </div>

    <asp:ValidationSummary ID="myValidationSummary" runat="server" CssClass="panel panel-danger" EnableClientScript="true"
        DisplayMode="BulletList" HeaderText="<%$Resources:Messages,ErrorMessage007 %>" ShowSummary="true" ShowMessageBox="false" />

    <br />

    <div class="panel panel-primary">

        <div class="panel-heading">
            <asp:Literal ID="litLegend" runat="server" Text="<%$Resources:Captions,UserManagment%>" />
        </div>


        <br />

        <div class="panel-body">

            <div class="form-group">
                <asp:Label ID="lblUserID" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,UserID%>" />

                <div class="col-md-10">

                    <asp:TextBox ID="txtUserID" runat="server" CssClass="form-control" MaxLength="30" placeholder="<%$Resources:Captions,UserID%>" />
                </div>

            </div>


            <br />

            <div class="form-group">
                <asp:Label ID="lblRole" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,RoleName%>" />

                <div class="col-md-10">
                    <asp:DropDownList ID="ddlRoleId" runat="server" CssClass="form-control" AutoPostBack="True">
                        <asp:ListItem Value="200">Administrator</asp:ListItem>
                        <asp:ListItem Value="300">Editor</asp:ListItem>
                        <asp:ListItem Value="400">SuperUser</asp:ListItem>
                        <asp:ListItem Value="500">Manager</asp:ListItem>
                        <asp:ListItem Value="600">Supervisor</asp:ListItem>
                        <asp:ListItem Value="700">Reporter</asp:ListItem>
                        <asp:ListItem Value="900">User</asp:ListItem>
                    </asp:DropDownList>
                </div>

            </div>

            <br />

            <div class="form-group">

                <asp:Label ID="lblRoleID" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,RoleID%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtRoleID" runat="server" CssClass="form-control" MaxLength="30" placeholder="<%$Resources:Captions,RoleID%>" />

                    <asp:RequiredFieldValidator ID="rfvRoleID" runat="server" ControlToValidate="txtRoleID"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />
                </div>

            </div>

            <br />

            <div class="form-group">
                <asp:Label ID="lblUsername" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,Username%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" MaxLength="30" placeholder="<%$Resources:Captions,Username%>" />

                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />

                    <asp:RegularExpressionValidator ID="revUsername" runat="server" ControlToValidate="txtUsername"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="true"
                        CssClass="validator" Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage008 %>"
                        ValidationExpression="[0-9a-zA-Z0-9]{4,20}" />
                </div>

            </div>

            <br />

            <div class="form-group">
                <asp:Label ID="lblPassword" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,Password%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" MaxLength="40" placeholder="<%$Resources:Captions,Password%>" />

                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />

                    <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="true"
                        CssClass="validator" Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage009 %>"
                        ValidationExpression="[a-zA-Z0-9]{6,40}" />
                </div>

            </div>

            <br />

            <div class="form-group">
                <asp:Label ID="lblEmail" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,Email%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" MaxLength="30" placeholder="<%$Resources:Captions,Email%>" />

                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                        ControlToValidate="txtEmail" CssClass="validator"
                        Display="Dynamic" EnableClientScript="false"
                        SetFocusOnError="true" Text="*" />
                    <asp:RegularExpressionValidator ID="revEmail" runat="server"
                        ControlToValidate="txtEmail" CssClass="validator"
                        Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                        Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage010%>"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                </div>

            </div>

            <div class="form-group">

                <asp:Label ID="lblMobile" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,Mobile%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" MaxLength="30" placeholder="<%$Resources:Captions,Mobile%>" />

                    <asp:RequiredFieldValidator ID="rfvMobile" runat="server"
                        ControlToValidate="txtMobile" CssClass="danger"
                        Display="Dynamic" EnableClientScript="false"
                        SetFocusOnError="true" Text="*" />
                    <asp:RegularExpressionValidator ID="revMobile" runat="server"
                        ControlToValidate="txtMobile" CssClass="danger"
                        Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                        Text="*" ErrorMessage="<%$Resources:Messages,ErrorMessage025%>"
                        ValidationExpression="[0-9]{11,11}" />
                </div>

            </div>

            <br />

            <div class="form-group">

                <div class="col-md-12">
                    <asp:CheckBox ID="chkUserActive" runat="server" Text="<%$Resources:Captions,UserActive%>" />
                    <br />
                    <asp:CheckBox ID="chkEmailVerified" runat="server" Text="<%$Resources:Captions,EmailVerified%>" />
                </div>

            </div>



            <div class="panel">
                <br />
                <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,Edit %>" OnClick="btnEdit_Click" />
                &nbsp
            <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,Clear %>" OnClick="btnCancel_Click" />
                &nbsp
            <asp:Button ID="btnCreateUser" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,CreateUser %>" OnClick="btnCreateUser_Click" />
                &nbsp
            <asp:Button ID="btnDeleteUser" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,DeleteUser %>" OnClick="btnDeleteUser_Click" />
                &nbsp
              <br />
                <asp:LinkButton ID="lnbManageUsers" runat="server" CssClass="link2" Text="<%$Resources:Buttons,BackToManageUsers %>" OnClick="lnbManageUsers_Click" />
            </div>

        </div>

    </div>

</div>




