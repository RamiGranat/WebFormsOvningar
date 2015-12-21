<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="CalculatorFrame" runat="server"><br />
        <asp:Label ID="ResultBox" runat="server">The result is shown here</asp:Label><br />
        <asp:TextBox ID="Input1" runat="server" Placeholder="Input first number"></asp:TextBox>
        <asp:TextBox ID="Input2" runat="server" Placeholder="Input second number"></asp:TextBox><br />
        <asp:Button ID="DivideButton" runat="server" Text="/" OnClick="DivideButton_Click"/>
        <asp:Button ID="MultiplyButton" runat="server" Text="*" OnClick="MultiplyButton_Click"/>
        <asp:Button ID="SubtractButton" runat="server" Text="-" OnClick="SubtractButton_Click"/>
        <asp:Button ID="AddButton" runat="server" Text="+" OnClick="AddButton_Click"/>
    </asp:Panel>
    </div>
    </form>
</body>
</html>
