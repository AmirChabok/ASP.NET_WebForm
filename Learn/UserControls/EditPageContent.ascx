<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditPageContent.ascx.cs" Inherits="UserControls_EditPageContent" %>



<div class="container">

    <div id="divPageMessages" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessages" runat="server" />
    </div>

    <br />

    <div class="panel panel-primary">

        <div class="panel-heading">
            <asp:Literal ID="litLegend" runat="server" Text="<%$Resources:Captions,EditContent%>" />
        </div>

        <div class="panel-body">

            <div class="form-group">
                <asp:Label ID="lblFileName" runat="server" Text="<%$Resources:Captions,FileName %>" CssClass="col-md-2" />

                <div class="col-md-10">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="PageName" DataValueField="PageID" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:TextBox ID="txtFileName" runat="server" MaxLength="60" CssClass="form-control" />
                </div>

            </div>

            <div class="form-group">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataAccessLayer.Properties.Settings.Cwx121ConnectionString %>" SelectCommand="SELECT * FROM [Pages]"></asp:SqlDataSource>
                <br />
            </div>

            <div class="form-group">
                <asp:Label ID="lblEditContent" runat="server" Text="<%$Resources:Captions,EditContent %>" CssClass="col-md-2" />

                <div class="col-md-10" style="width: 100%">
                    <asp:TextBox ID="txtEditContent" runat="server" MaxLength="1000" TextMode="MultiLine" Rows="10" Columns="70" CssClass="form-control" />
                </div>

            </div>

            <div>
            </div>

        </div>

        <div class="panel" runat="server" align="center">

            <br />
            <asp:Button ID="btnOpen" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,Open %>" AccessKey="O" OnClick="btnOpen_Click" />
            &nbsp
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,Save %>" AccessKey="S" OnClick="btnSave_Click" />
            &nbsp
            <asp:LinkButton ID="lnbCancel" runat="server" CssClass="btn btn-success" Text="<%$Resources:Buttons,CancelAndGO %>" OnClick="lnbCancel_Click" />
            &nbsp
            <asp:LinkButton ID="lnbManagePages" runat="server" CssClass="btn btn-danger" Text="<%$Resources:Buttons,BackToManagePages %>" OnClick="lnbManagePages_Click" />
            <br />
        </div>

    </div>

</div>

<script src="../Scripts/tinymce/tiny_mce.js" type="text/javascript"></script>

<script src="../Scripts/tinymce/tinymce.min.js" type="text/javascript"></script>

<script type="text/javascript">
    tinymce.init({
        selector: "textarea",
        theme: "modern",
        plugins: [
            "advlist autolink lists link image charmap print preview hr anchor pagebreak",
            "searchreplace wordcount visualblocks visualchars code fullscreen",
            "insertdatetime media nonbreaking save table contextmenu directionality",
        ],
        toolbar1: "insertfile undo redo | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image",
        toolbar2: "print preview media | forecolor backcolor emoticons",
        image_advtab: true,
        templates: [
            { title: 'Test template 1', content: 'Test 1' },
            { title: 'Test template 2', content: 'Test 2' }
        ]
    });
</script>

