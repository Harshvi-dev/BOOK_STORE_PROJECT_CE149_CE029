<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addBooks.aspx.cs" Inherits="book_project.addBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    
<style>
    body {
  background: #555;
}

.content {
  max-width: 500px;
  margin: auto;
  background: white;
  padding: 10px;
}
</style>
</head>
<body>

    <div class="content">
    <form id="form1" runat="server">
        <div>
            Book name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="200px" BackColor="#E6E6E6" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
            Author :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="27px" Width="201px" BackColor="#E6E6E6" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
            price :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="120px" BackColor="#E6E6E6" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
            Catagory :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="27px" Width="213px" BackColor="#E6E6E6" BorderStyle="None"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="33px" Text="Submit " Width="102px" BackColor="#E6E6E6" OnClick="Button1_Click" />
        </div>
    </form>

        </div>
</body>
</html>
