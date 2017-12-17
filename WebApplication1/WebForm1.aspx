<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .position {
            text-align: center;
            background-color: #FFCC00;
            margin-left: 157px;
        }
        .auto-style1 {
            text-align: left;
            font-size: small;
        }
        </style>
</head>
<body style="height: 286px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p class="auto-style1">
            &nbsp;</p>
        <p style="margin-left: 312px">
            <asp:Label ID="LabelName" runat="server" Text="Имя"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 45px" Width="217px"></asp:TextBox>
        </p>
        <p style="margin-left: 297px">
            <asp:Label ID="LabelSurname" runat="server" Text="Фамилия"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" style="margin-left: 16px" Width="214px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p style="width: 563px; margin-left: 156px">
            <asp:Label ID="LabelWelcome" runat="server" Text="Введите ваше имя..." ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass ="position" Text="Отправить" BorderStyle="Solid" Width="252px" />
            <asp:Button ID="Button2" runat="server" BackColor="#FF9900" BorderColor="#FFCC00" BorderStyle="Solid" OnClick="Button2_Click" style="margin-left: 175px" Text="Восстановить" Width="204px" />
        </p>
    </form>
</body>
</html>
