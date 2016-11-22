<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CreateNewsletter.ascx.cs" Inherits="UserControls_CreateNewsletter" %>
<div class="container">

    <div id="divPageMessage" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessages" runat="server" />
    </div>

    <asp:ValidationSummary ID="myValidationSummary" runat="server" CssClass="panel panel-danger" EnableClientScript="true"
        DisplayMode="BulletList" HeaderText="<%$Resources:Messages,ErrorMessage007 %>" ShowSummary="true" ShowMessageBox="false" />


    <div class="panel panel-primary">

        <div class="panel-heading">
            <asp:Literal ID="litLegend" runat="server" Text="<%$Resources:Captions,SendNewPost %>" />
        </div>

        <div class="panel-body">

            <div class="form-group">
                <asp:Label ID="lblSubject" runat="server" Text="<%$Resources:Captions,Subject %>" CssClass="col-md-2" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtSubject" runat="server" MaxLength="100" CssClass="form-control" Columns="56" />

                    <asp:RequiredFieldValidator ID="rfvSubject" runat="server" ControlToValidate="txtSubject"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="true"
                        CssClass="validator" Text="*" />
                </div>

            </div>

            <br />

            <div class="col-md-10" style="width: 100%">
                <asp:TextBox ID="txtPost" runat="server" TextMode="MultiLine" Rows="10" Columns="67" CssClass="form-control" MaxLength="10000" />

                <asp:RequiredFieldValidator ID="rfvPost" runat="server" ControlToValidate="txtPost"
                    Display="Dynamic" SetFocusOnError="true" EnableClientScript="true"
                    CssClass="validator" Text="*" />
            </div>

            <br />
 
        </div>

    </div>

    <div class="panel">
        <asp:Button ID="btnCreateNewsletter" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Captions,CreateNews%>" OnClick="btnCreateNewsletter_Click"/>
        &nbsp
    </div>

</div>


<script src="../Scripts/tinymce/tiny_mce.js" type="text/javascript"></script>

<script src="../Scripts/tinymce/tinymce.min.js" type="text/javascript"></script>

<script type="text/javascript" src="<your installation path>/tinymce/tinymce.min.js"></script>
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



