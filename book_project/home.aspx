<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="book_project.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-right: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="book_id" DataSourceID="BooksSqlDataSource" Height="194px" OnRowCommand="GridView1_RowCommand" Width="447px" CssClass="auto-style1">
                <Columns>
                    <asp:BoundField DataField="book_id" HeaderText="book_id" InsertVisible="False" ReadOnly="True" SortExpression="book_id" />
                    <asp:BoundField DataField="book_name" HeaderText="book_name" SortExpression="book_name" />
                    <asp:BoundField DataField="author" HeaderText="author" SortExpression="author" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                    <asp:BoundField DataField="catagory" HeaderText="catagory" SortExpression="catagory" />
                    <asp:ButtonField CommandName="buy" Text="buy"></asp:ButtonField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="BooksSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Books]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
