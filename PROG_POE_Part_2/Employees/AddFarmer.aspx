<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFarmer.aspx.cs" Inherits="PROG_POE_Part_2.Employees.AddFarmer" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <link href="../Content/Site.css" rel="stylesheet" />
    <title>Add Farmer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add New Farmer</h2>
            <asp:Label ID="lblNameError" runat="server" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            
            <asp:Label ID="lblSurnameError" runat="server" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblSurname" runat="server" Text="Surname:"></asp:Label>
            <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
            
            <asp:Label ID="lblUsernameError" runat="server" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            
            <asp:Label ID="lblPasswordError" runat="server" ForeColor="Blue"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            

            <button type="button" runat="server" onserverclick="btnAddFarmer_Click">Add Farmer</button>
            <button type="button" runat="server" onserverclick="btnHome_Click" style="margin-top: 10px;" id="btnHome">Return Home</button>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
        <div class="farming-fact" style="text-align: center;">
              There are more than 7,500 varieties of apples grown around the world, each with its own unique flavor, color, and texture.
        </div>
        <div style="text-align: center;">
              <asp:Image ID="imgGrass" runat="server" Height="522px" ImageUrl="~/Images/Grass.jpg" Width="1000px" ImageAlign="Middle" />
        </div>
    </form>
</body>
</html>
