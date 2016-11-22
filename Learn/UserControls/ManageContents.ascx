<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageContents.ascx.cs" Inherits="UserControls_ManageContents" %>

<div class="container">

    <div id="divPageMessage" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessage" runat="server" />
    </div>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PostId" DataSourceID="SqlDataSource1" EnableModelValidation="True">
            <Columns>
                <asp:BoundField DataField="PostId" HeaderText="<%$Resources:GridView,PostId%>" InsertVisible="False" ReadOnly="True" SortExpression="PostId" />
                <asp:BoundField DataField="UserId" HeaderText="<%$Resources:GridView,UserId%>" SortExpression="UserId" />
                <asp:BoundField DataField="PostTypeId" HeaderText="<%$Resources:GridView,PostTypeId%>" SortExpression="PostTypeId" />
                <asp:BoundField DataField="PostCategoryId" HeaderText="<%$Resources:GridView,PostCategoryId%>" SortExpression="PostCategoryId" />
                <asp:BoundField DataField="PostVisitedCount" HeaderText="<%$Resources:GridView,PostVisitedCount%>" SortExpression="PostVisitedCount" />
                <asp:CheckBoxField DataField="IsHot" HeaderText="<%$Resources:GridView,IsHot%>" SortExpression="IsHot" />
                <asp:CheckBoxField DataField="IsPostActive" HeaderText="<%$Resources:GridView,IsPostActive%>" SortExpression="IsPostActive" />
                <asp:CheckBoxField DataField="IsCommentEnabled" HeaderText="<%$Resources:GridView,IsCommentEnabled%>" SortExpression="IsCommentEnabled" />
                <asp:BoundField DataField="Password" HeaderText="<%$Resources:GridView,Password%>" SortExpression="Password" />
                <asp:BoundField DataField="Title" HeaderText="<%$Resources:GridView,Title%>" SortExpression="Title" />
                <asp:BoundField DataField="Keywords" HeaderText="<%$Resources:GridView,Keyword%>" SortExpression="Keyword" />
                <asp:BoundField DataField="InsertTime" HeaderText="<%$Resources:GridView,InsertTime%>" SortExpression="InsertTime" />
                <asp:BoundField DataField="UpdateTime" HeaderText="<%$Resources:GridView,UpdateTime%>" SortExpression="UpdateTime" />
                <asp:BoundField DataField="PublishTime" HeaderText="<%$Resources:GridView,PublishTime%>" SortExpression="PublishTime" />

                <%--این بدنه را خودمان به شکل دستی ایجاد کردیم که بتوانیم اطلاعات کاربر را در صفحه ای دیگر ویرایش نمائیم--%>
                <asp:TemplateField>
                    <HeaderTemplate>ويرايش</HeaderTemplate>
                    <ItemTemplate>
                        <%--خط ذیل باعث میشود وقتی به صفحه ویرایش اطلاعات پست میرویم شماره کاربری کاربر را نیز به همراه داشته باشیم--%>

                        <a href="../Administrator/ManageContent.aspx?current=user&PostId=<%# Eval("PostId") %>">
                            <img src="../assets/img/logo.png" alt="ويرايش اطلاعات اين پست" border="0" /></a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataAccessLayer.Properties.Settings.Cwx121ConnectionString %>" SelectCommand="SELECT * FROM [Posts] WHERE ([IsCommentEnabled] = @IsCommentEnabled)">
        <SelectParameters>
            <asp:Parameter DefaultValue="false" Name="IsCommentEnabled" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>



