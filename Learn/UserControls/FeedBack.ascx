<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FeedBack.ascx.cs" Inherits="UserControls_FeedBack" %>
<div id="divPageMessage" runat="server" class="panel panel-info">
    <asp:Literal ID="litPageMessage" runat="server" />
</div>

<div id="menu-feedback" class="block-content block-padding fullwidth">

    <h2 class="block-title center">بازخورد</h2>

    <p class="center slogan mb50">
        نظرات و پیشنهادات خود را از این طریق برای ما ارسال کنید.
                                <br>
        درخواست های خود را از طریق ایمیل برای ما ارسال کنید.
    </p>

    <div>

        <div class="row">

            <div class="form-group col-sm-6">
                <asp:TextBox ID="txtName" CssClass="form-control" runat="server" placeholder="نام" MaxLength="50" />

                <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtName"
                    CssClass="danger" EnableClientScript="true" Text="*"
                    ErrorMessage="*" />
            </div>

            <!-- /.form-group -->
            <div class="form-group col-sm-6">
            <asp:TextBox ID="txtMail" runat="server" CssClass="form-control" placeholder="ایمیل" MaxLength="50" />

            <asp:RequiredFieldValidator ID="rfvMail" runat="server" ControlToValidate="txtMail"
                CssClass="danger" EnableClientScript="true" Text="*"
                ErrorMessage="*" />
                </div>

            <!-- /.form-group -->
        </div>

        <div class="form-group">

            <div class="row">

                <div class="col-sm-12">
                    <asp:TextBox ID="txtComment" runat="server" CssClass="form-control" placeholder="پیغام" MaxLength="1210" TextMode="MultiLine" />

                    <asp:RequiredFieldValidator ID="rfvComment" runat="server" ControlToValidate="txtComment"
                        CssClass="danger" EnableClientScript="true" Text="*"
                        ErrorMessage="*" />

                </div>

            </div>

            <!-- /.row -->
        </div>

        <!-- /.form-group -->
        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="ارسال" OnClick="btnSubmit_Click" />
    </div>
</div>
