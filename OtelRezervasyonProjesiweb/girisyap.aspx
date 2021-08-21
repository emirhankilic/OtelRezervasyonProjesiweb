<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="girisyap.aspx.cs" Inherits="OtelRezervasyonProjesiweb.girisyap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 1280px; height: 600px; background-image: url('img/backwebhome2.jpg'); background-color: #000000;">

        
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="KULLANICI ADI :" BackColor="Black" ForeColor="White"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 42px" Width="160px" Height="16px"></asp:TextBox>
            <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="ŞİFRE :" BackColor="Black" ForeColor="White"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Height="16px" style="margin-left: 120px" Width="161px"></asp:TextBox>
            <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GİRİŞ" style="margin-left: 126px" Width="118px" BackColor="Black" ForeColor="White" />
            <br />
       <asp:Label ID="Label4" runat="server" Text="Label" ForeColor="White"></asp:Label>
            </div>
    </form>
</body>

</html>
