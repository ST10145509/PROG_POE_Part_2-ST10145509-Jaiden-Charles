<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProducts.aspx.cs" Inherits="PROG_POE_Part_2.Employees.ViewProducts" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <link href="../Content/Site.css" rel="stylesheet" />
    <title>View Products</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>View Products</h2>
            <asp:Label ID="lblFarmerUsername" runat="server" Text="Farmer Username:"></asp:Label>
            <asp:TextBox ID="txtFarmerUsername" runat="server"></asp:TextBox>
            <asp:Label ID="lblStartDate" runat="server" Text="Start Date:"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="lblEndDate" runat="server" Text="End Date:"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="lblCategoryType" runat="server" Text="Category Type:"></asp:Label>
            <asp:TextBox ID="txtCategoryType" runat="server"></asp:TextBox>
            <button type="submit" runat="server" onserverclick="btnViewProducts_Click">View Products</button>
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
            <asp:GridView ID="gvProducts" runat="server" CssClass="grid-view"></asp:GridView>
            <button type="button" runat="server" onserverclick="homeBtn_Click" style="margin-top: 10px;" id="homeBtn">Return Home</button>
            <div class="farming-fact" style="text-align: center;">
                Did you know? Potatoes were the first vegetable to be grown in space. NASA and a team of university scientists collaborated to grow them on the Space Shuttle.
            </div>
            <div style="text-align: center;">
                  <asp:Image ID="imgGrass" runat="server" Height="522px" ImageUrl="~/Images/Grass.jpg" Width="1000px" ImageAlign="Middle" />
            </div>
            
        </div>
    </form>
</body>
</html>

