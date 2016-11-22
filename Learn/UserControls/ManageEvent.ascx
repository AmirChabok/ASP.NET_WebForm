<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageEvent.ascx.cs" Inherits="UserControls_ManageEvents" %>

<div class="container">

    <div id="divPageMessage" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessage" runat="server" />
    </div>

    <asp:ValidationSummary ID="myValidationSummary" runat="server" CssClass="panel panel-danger" EnableClientScript="true"
        DisplayMode="BulletList" HeaderText="<%$Resources:Messages,ErrorMessage007 %>" ShowSummary="true" ShowMessageBox="false" />

    <br />



    <div class="panel panel-primary">

        <div class="panel-heading">
            <asp:Literal ID="litLegend" runat="server" Text="<%$Resources:Captions,EditContent %>" />
        </div>

        <div class="panel-body">

            <div class="form-group">
                <asp:Label ID="lblTitle" runat="server" CssClass="col-md-2" Text="<%$Resources:GridView,Title%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control" MaxLength="100" />

                    <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />
                </div>

            </div>

            <br />

            <div class="form-group">
                <asp:Label ID="lblUserID" runat="server" CssClass="col-md-2" Text="<%$Resources:Captions,PostID%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtUserID" runat="server" CssClass="form-control" MaxLength="30" />
                </div>

            </div>

            <br />
            <br />

            <div class="form-group">

                <div class="col-md-12" style="width: 100%">
                    <asp:TextBox ID="txtPost" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="10" Columns="67" />

                    <asp:RequiredFieldValidator ID="rfvPost" runat="server" ControlToValidate="txtPost"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />
                </div>

            </div>


            <br />

            <div class="form-group">
                <asp:Label ID="lblPostCategoryId" runat="server" CssClass="col-md-2" Text="<%$Resources:GridView,PostCategoryId%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtPostCategoryId" runat="server" CssClass="form-control" MaxLength="30" />

                    <asp:RequiredFieldValidator ID="rfvPostCategoryId" runat="server" ControlToValidate="txtPostCategoryId"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />
                </div>

            </div>

            <div class="form-group">

                <div class="col-md-2">
                    <asp:DropDownList ID="ddlPostCategory" runat="server" DataSourceID="SqlDataSource2" DataTextField="PostCategoryName" DataValueField="PostCategoryId" AutoPostBack="True" OnSelectedIndexChanged="ddlPostCategory_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DataAccessLayer.Properties.Settings.Cwx121ConnectionString %>" SelectCommand="SELECT * FROM [PostCategories]"></asp:SqlDataSource>
                </div>

            </div>

            <br />

            <div class="form-group">
                <asp:Label ID="lblPostTypeId" runat="server" CssClass="col-md-2" Text="<%$Resources:GridView,PostTypeId%>" />

                <div class="col-md-8">
                    <asp:TextBox ID="txtPostTypeId" runat="server" CssClass="form-control" MaxLength="30" />

                    <asp:RequiredFieldValidator ID="rfvPostTypeId" runat="server" ControlToValidate="txtPostTypeId"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />
                </div>

                <div class="form-group">

                    <div class="col-md-2">
                        <asp:DropDownList ID="ddlPostType" runat="server" DataSourceID="SqlDataSource1" DataTextField="PostTypeName" DataValueField="PostTypeId" AutoPostBack="True" OnSelectedIndexChanged="ddlPostType_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataAccessLayer.Properties.Settings.Cwx121ConnectionString %>" SelectCommand="SELECT * FROM [PostTypes] WHERE ([PostCategoryId] = @PostCategoryId)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="txtPostCategoryId" Name="PostCategoryId" PropertyName="Text" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </div>

                </div>

            </div>

            <div class="form-group">
                <asp:Label ID="lblKeyword1" runat="server" CssClass="col-md-2" Text="<%$Resources:GridView,Keyword%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtKeyword1" runat="server" CssClass="form-control" MaxLength="50" />

                    <asp:RequiredFieldValidator ID="rfvKeyword1" runat="server" ControlToValidate="txtKeyword1"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />
                </div>

            </div>


            <div class="form-group">
                <asp:Label ID="lblInsertTime" runat="server" CssClass="col-md-2" Text="<%$Resources:GridView,InsertTime%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtInsertTime" runat="server" CssClass="form-control" />

                    <asp:RequiredFieldValidator ID="rfvInsertTime" runat="server" ControlToValidate="txtInsertTime"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />
                </div>

            </div>


            <div class="form-group">
                <asp:Label ID="lblUpdateTime" runat="server" CssClass="col-md-2" Text="<%$Resources:GridView,UpdateTime%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtUpdateTime" runat="server" CssClass="form-control" />

                    <asp:RequiredFieldValidator ID="rfvUpdateTime" runat="server" ControlToValidate="txtUpdateTime"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />
                </div>

            </div>

            <div class="form-group">
                <asp:Label ID="lblPublishTime" runat="server" CssClass="col-md-2" Text="<%$Resources:GridView,PublishTime%>" />

                <div class="col-md-10">
                    <asp:TextBox ID="txtPublishTime" runat="server" CssClass="form-control" />

                    <asp:RequiredFieldValidator ID="rfvPublishTime" runat="server" ControlToValidate="txtPublishTime"
                        Display="Dynamic" SetFocusOnError="true" EnableClientScript="false"
                        CssClass="validator" Text="*" />
                </div>

            </div>



            <div class="form-group">

                <div class="col-md-4">
                    <asp:CheckBox ID="chkIsHot" runat="server" CssClass="form-control" Text="<%$Resources:GridView,IsHot%>" />
                </div>

            </div>

 

            <div class="form-group">

                <div class="col-md-4">
                    <asp:CheckBox ID="chkIsPostActive" runat="server" CssClass="form-control" Text="<%$Resources:GridView,IsPostActive%>" />
                </div>

            </div>


            <div class="form-group">

                <div class="col-md-4">
                    <asp:CheckBox ID="chkIsCommentEnabled" CssClass="form-control" runat="server" Text="<%$Resources:GridView,IsCommentEnabled%>" />
                </div>

            </div>

      

            <div class="form-group">

                <div class="col-md-4">

                    <div id="divImageOfAvatar" runat="server" style="width: 77px; height: 77px;">

                        <div id="divShowAvatar" runat="server">

                            <asp:Image ID="imgAvatar" runat="server" CssClass="imgAvatar" />
                        </div>

                    </div>

                </div>

                <div class="col-md-2">
                    <asp:Button ID="btnUpload" runat="server" CssClass="btn btn-success" Text="<%$Resources:Captions,UploadPicture %>" OnClick="btnUpload_Click" />
                </div>

                <div class="col-md-2">
                    <asp:Button ID="btnDeleteAvatar" runat="server" CssClass="btn btn-danger" Text="<%$Resources:Captions,DeleteImage %>" OnClick="btnDeleteAvatar_Click" />
                </div>

                <div class="col-md-4">
                    <asp:FileUpload ID="myFileUpload" runat="server" CssClass="form-control" />
                </div>

            </div>

        </div>


        <br />
    </div>

    <div class="panel" align="center">
        <br />
        <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,Edit %>" OnClick="btnEdit_Click" />
        &nbsp
                <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,Clear %>" OnClick="btnCancel_Click" />
        &nbsp
                <asp:Button ID="btnCreatePost" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,CreatePost %>" OnClick="btnCreatePost_Click" />
        &nbsp
                <asp:Button ID="btnDeletePost" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,DeletePost %>" OnClick="btnDeletePost_Click" />
        &nbsp
                <asp:Button ID="btnDeleteAllPosts" runat="server" CssClass="btn btn-primary" Text="<%$Resources:Buttons,DeleteAllPosts %>" OnClick="btnDeleteAllPosts_Click" />
        &nbsp
        <br />
        <br />
        <asp:LinkButton ID="lnbManagePosts" runat="server" CssClass="btn btn-success" Text="<%$Resources:Buttons,BackToManagePosts %>" OnClick="lnbManagePosts_Click" />
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


