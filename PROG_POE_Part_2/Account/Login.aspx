<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PROG_POE_Part_2.Account.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <link href="../Content/Site.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <div style="text-align: center;">
            <button type="submit" runat="server" onserverclick="btnLogin_Click" style="margin-left: 50px;">Login</button>
            <button type="submit" runat="server" onserverclick="btnReturn_Click" style="margin-left: 10px;">Return to Title</button>
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
            <div class="farming-fact" style="text-align: center;">
                Did you know? Bananas are berries, but strawberries aren't. In botanical terms, a berry is a fleshy fruit produced from a single ovary.
            </div>
                <div style="text-align: center;">
                    <asp:Image ID="imgGrass" runat="server" Height="522px" ImageUrl="~/Images/Grass.jpg" Width="1000px" ImageAlign="Middle" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>


