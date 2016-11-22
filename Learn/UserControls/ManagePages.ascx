<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManagePages.ascx.cs" Inherits="UserControls_ManagePages" %>

<div class="container">

    <div id="divPageMessage" runat="server" class="panel panel-info">
        <asp:Literal ID="litPageMessage" runat="server" />
    </div>

    <div class="form-group" runat="server" align="center">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="PageID" DataSourceID="SqlDataSource1" EnableModelValidation="True">
            <Columns>
                <asp:BoundField DataField="PageID" HeaderText="<%$Resources:Captions,PageID%>" InsertVisible="False" ReadOnly="True" SortExpression="PageID" />
                <asp:BoundField DataField="PageName" HeaderText="<%$Resources:Captions,PageName%>" SortExpression="PageName" />
                <%--این بدنه را خودمان به شکل دستی ایجاد کردیم که بتوانیم اطلاعات کاربر را در صفحه ای دیگر ویرایش نمائیم--%>
                <asp:TemplateField>
                    <HeaderTemplate>ويرايش صفحه</HeaderTemplate>
                    <ItemTemplate>
                        <%--خط ذیل باعث میشود وقتی به صفحه ویرایش اطلاعات کانتنت میرویم --%>
                        <a href="../Administrator/EditPageContent.aspx?current=Pages&PageName=<%# Eval("PageName")%>">
                            <img src="../assets/img/logo.png" alt="ويرايش اطلاعات اين صفحه" border="0" /></a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataAccessLayer.Properties.Settings.Cwx121ConnectionString %>" SelectCommand="SELECT * FROM [Pages]"></asp:SqlDataSource>

    <
    </div>



