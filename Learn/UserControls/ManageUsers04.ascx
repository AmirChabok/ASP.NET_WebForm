<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageUsers04.ascx.cs" Inherits="Administrator_UserControls_ManageUsers04" %>

<div class="container">

    <div id="divPageMessage" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessage" runat="server" />
    </div>

    <div class="form-group" runat="server" align="center">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="UserId" DataSourceID="SqlDataSource1" EnableModelValidation="True" AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="UserId" HeaderText="<%$Resources:Captions,UserId%>" InsertVisible="False" ReadOnly="True" SortExpression="UserId" />
                <asp:BoundField DataField="RoleId" HeaderText="<%$Resources:Captions,RoleId%>" SortExpression="RoleId" />
                <asp:BoundField DataField="LoginCount" HeaderText="<%$Resources:Captions,LoginCount%>" SortExpression="LoginCount" />
                <asp:CheckBoxField DataField="IsUserActive" HeaderText="<%$Resources:Captions,IsUserActive%>" SortExpression="IsUserActive" />
                <asp:BoundField DataField="UserEmail" HeaderText="<%$Resources:Captions,Email%>" SortExpression="UserEmail" />
                <asp:BoundField DataField="Username" HeaderText="<%$Resources:Captions,Username%>" SortExpression="Username" />
                <asp:BoundField DataField="LastLoginTime" HeaderText="<%$Resources:Captions,LastLoginTime%>" SortExpression="LastLoginTime" />
                <asp:CheckBoxField DataField="IsUserEmailVerified" HeaderText="<%$Resources:Captions,EmailVerified%>" SortExpression="IsUserEmailVerified" />

                <%--این بدنه را خودمان به شکل دستی ایجاد کردیم که بتوانیم اطلاعات کاربر را در صفحه ای دیگر ویرایش نمائیم--%>
                <asp:TemplateField>
                    <HeaderTemplate>ويرايش</HeaderTemplate>
                    <ItemTemplate>
                        <%--خط ذیل باعث میشود وقتی به صفحه ویرایش اطلاعات کاربر میرویم شماره کاربری کاربر را نیز به همراه داشته باشیم--%>
                        <a href="../Administrator/EditUsers.aspx?current=user&UserID=<%# Eval("UserId") %>">
                            <img src="../assets/img/logo.png" alt="ويرايش اطلاعات اين كاربر" border="0" /></a>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:DataAccessLayer.Properties.Settings.Cwx121ConnectionString %>" DeleteCommand="DELETE FROM [Users] WHERE [UserId] = @original_UserId AND [RoleId] = @original_RoleId AND [LoginCount] = @original_LoginCount AND [IsUserActive] = @original_IsUserActive AND [UserEmail] = @original_UserEmail AND [Username] = @original_Username AND [LastLoginTime] = @original_LastLoginTime AND [IsUserEmailVerified] = @original_IsUserEmailVerified" InsertCommand="INSERT INTO [Users] ([RoleId], [LoginCount], [IsUserActive], [UserEmail], [Username], [LastLoginTime], [IsUserEmailVerified]) VALUES (@RoleId, @LoginCount, @IsUserActive, @UserEmail, @Username, @LastLoginTime, @IsUserEmailVerified)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [UserId], [RoleId], [LoginCount], [IsUserActive], [UserEmail], [Username], [LastLoginTime], [IsUserEmailVerified] FROM [Users]" UpdateCommand="UPDATE [Users] SET [RoleId] = @RoleId, [LoginCount] = @LoginCount, [IsUserActive] = @IsUserActive, [UserEmail] = @UserEmail, [Username] = @Username, [LastLoginTime] = @LastLoginTime, [IsUserEmailVerified] = @IsUserEmailVerified WHERE [UserId] = @original_UserId AND [RoleId] = @original_RoleId AND [LoginCount] = @original_LoginCount AND [IsUserActive] = @original_IsUserActive AND [UserEmail] = @original_UserEmail AND [Username] = @original_Username AND [LastLoginTime] = @original_LastLoginTime AND [IsUserEmailVerified] = @original_IsUserEmailVerified">
            <DeleteParameters>
                <asp:Parameter Name="original_UserId" Type="Int32" />
                <asp:Parameter Name="original_RoleId" Type="Int32" />
                <asp:Parameter Name="original_LoginCount" Type="Int32" />
                <asp:Parameter Name="original_IsUserActive" Type="Boolean" />
                <asp:Parameter Name="original_UserEmail" Type="String" />
                <asp:Parameter Name="original_Username" Type="String" />
                <asp:Parameter Name="original_LastLoginTime" Type="DateTime" />
                <asp:Parameter Name="original_IsUserEmailVerified" Type="Boolean" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="RoleId" Type="Int32" />
                <asp:Parameter Name="LoginCount" Type="Int32" />
                <asp:Parameter Name="IsUserActive" Type="Boolean" />
                <asp:Parameter Name="UserEmail" Type="String" />
                <asp:Parameter Name="Username" Type="String" />
                <asp:Parameter Name="LastLoginTime" Type="DateTime" />
                <asp:Parameter Name="IsUserEmailVerified" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="RoleId" Type="Int32" />
                <asp:Parameter Name="LoginCount" Type="Int32" />
                <asp:Parameter Name="IsUserActive" Type="Boolean" />
                <asp:Parameter Name="UserEmail" Type="String" />
                <asp:Parameter Name="Username" Type="String" />
                <asp:Parameter Name="LastLoginTime" Type="DateTime" />
                <asp:Parameter Name="IsUserEmailVerified" Type="Boolean" />
                <asp:Parameter Name="original_UserId" Type="Int32" />
                <asp:Parameter Name="original_RoleId" Type="Int32" />
                <asp:Parameter Name="original_LoginCount" Type="Int32" />
                <asp:Parameter Name="original_IsUserActive" Type="Boolean" />
                <asp:Parameter Name="original_UserEmail" Type="String" />
                <asp:Parameter Name="original_Username" Type="String" />
                <asp:Parameter Name="original_LastLoginTime" Type="DateTime" />
                <asp:Parameter Name="original_IsUserEmailVerified" Type="Boolean" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>

</div>

