<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsMerOvningar.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="DeadTextBox" runat="server" Text="I can handle your text, write anything here!" Height="100" Width="500"></asp:TextBox><br />
        <asp:Label ID="TextLabel" runat="server" Text="myLabel" Height="100" Width="500"></asp:Label><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Grimdarkify!" Height="100" Width="500"/><br />
        <asp:HyperLink ID="HDHyperLink" runat="server" NavigateUrl="http://www.hd.se" Height="100" Width="500">HdStuffComingThrough</asp:HyperLink><br />
        <asp:Panel ID="TextPanel" runat="server" GroupingText="MyPanel" Height="100" Width="500"></asp:Panel>

    </div>
    </form>
</body>
</html>
