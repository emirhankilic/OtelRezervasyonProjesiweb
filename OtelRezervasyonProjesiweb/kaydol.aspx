<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kaydol.aspx.cs" Inherits="OtelRezervasyonProjesiweb.kaydol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 595px;
            margin-right: 304px;
        }
    </style>
</head>
<body style="height: 569px">
    <form id="form1" runat="server">
        <div style="width: 1280px; height: 600px; margin-right: 0px; background-color: #FFFF00; background-image: url('img/backwebhome2.jpg');">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Text="AD :" BackColor="Black" Font-Bold="True" ForeColor="White"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="100px" style="margin-left: 125px" Height="16px"></asp:TextBox>

            <br />

            <br />
            <asp:Label ID="Label3" runat="server" Text="SOYAD : " BackColor="Black" Font-Bold="True" ForeColor="White"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 96px" Width="100px" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="YAŞ :" BackColor="Black" Font-Bold="True" ForeColor="White"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 118px" Width="100px" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="EMAİL :" BackColor="Black" Font-Bold="True" ForeColor="White"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 94px" Width="100px" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="KULLANICI ADI :" BackColor="Black" Font-Bold="True" ForeColor="White"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 23px" Width="100px" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="ŞİFRE :" BackColor="Black" Font-Bold="True" ForeColor="White"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 96px" Width="100px" Height="16px"></asp:TextBox>
            <br />

            <asp:Button ID="Button1" runat="server" Text="KAYIT OL" OnClick="Button1_Click" Height="28px" Width="233px" style="margin-left: 58px; margin-right: 0px; margin-top: 30px" BackColor="Black" ForeColor="White" />

            <br />

            <asp:Label ID="Label8" runat="server" ForeColor="White"></asp:Label>

            <br />
            <br />
            <asp:Button ID="Button2" runat="server" BackColor="Black" ForeColor="White" OnClick="Button2_Click" style="margin-left: 63px" Text="KAYITLI BİR HESABIM VAR" Width="226px" />
            <br />

       </div>
    </form>
</body>
</html>
