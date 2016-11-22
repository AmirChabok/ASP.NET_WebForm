<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UpdateProfile.ascx.cs" Inherits="UserControls_UpdateProfile" %>

<div class="container">

    <div id="divPageMessages" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessages2" runat="server" />
    </div>

    <div id="divAvatarMessage" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessages" runat="server" />
    </div>

    <br />

    <div class="col-md-2">

        <div id="divImageOfAvatar" runat="server">

            <div id="divShowAvatar" runat="server">
                <asp:Image ID="imgAvatar" runat="server" />
            </div>

        </div>

    </div>

    <div class="col-md-10">

        <div class="panel panel-success">

            <div class="panel-heading">
                <asp:Label ID="lblLegend" runat="server" Text="<%$Resources:Captions,Upload%>" />
            </div>

            <br />

            <div class="panel-body">

                <div class="form-group">
                    <asp:Label ID="lblAvatarFileName" runat="server" Text="<%$Resources:Captions,AvatarName%>" CssClass="col-md-2" />


                    <div class="col-md-10">


                        <div class="form-group">
                            <asp:FileUpload ID="myFileUpload" runat="server" CssClass="form-control" />
                        </div>

                    </div>

                </div>

            </div>

            <br />
        </div>

        <div class="panel">
            <asp:Button ID="btnUpload" runat="server" Text="<%$Resources:Captions,Upload%>" CssClass="btn btn-success" AccessKey="U" OnClick="btnSubmit2_Click" />
            &nbsp
       <asp:Button ID="btnDelete" runat="server" Text="<%$Resources:Captions,DeleteAvatar%>" CssClass="btn btn-success" AccessKey="R" OnClick="btnDelete_Click" />

        </div>

    </div>

    <br />


</div>

<div class="container">

    <div class="panel panel-info">

        <div class="panel-heading">
            <asp:Literal ID="litLegend" runat="server" Text="<%$Resources:Captions,UpdateProfile%>" />
        </div>

        <div class="panel-body">

            <div class="form-group">
                <asp:Label ID="lblFullName" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,FullName%>" />


                <div class="col-md-10">
                    <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" MaxLength="40" />
                </div>

            </div>

            <br />
            <br />

            <div class="form-group">

                <asp:Label ID="lblDescription" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,Description%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control"
                        MaxLength="10000" TextMode="MultiLine" Rows="10" placeholder="<%$Resources:Captions,Description%>" />
                </div>

            </div>

        </div>

    </div>

    <div class="panel">
        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-info" Text="<%$Resources:Buttons,Submit %>" OnClick="btnSubmit_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-info" Text="<%$Resources:Buttons,Cansel %>" />
    </div>

</div>

<br />
<div class="container">
     <asp:HyperLink ID="lnkFP" runat="server" NavigateUrl="~/ForgetPassword.aspx" Text="<%$Resources:Captions,ChangePassword%>"></asp:HyperLink>
</div>



