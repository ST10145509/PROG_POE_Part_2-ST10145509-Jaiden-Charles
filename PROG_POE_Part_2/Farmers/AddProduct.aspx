<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="PROG_POE_Part_2.Farmers.AddProduct" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <link href="../Content/Site.css" rel="stylesheet" />
    <title>Add Product</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add New Product</h2>
            <asp:Label ID="lblProductNameError" runat="server" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name:"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            
            <asp:Label ID="lblCategoryError" runat="server" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblCategory" runat="server" Text="Category:"></asp:Label>
            <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
            
            <asp:Label ID="lblProductionDateError" runat="server" ForeColor="Red"></asp:Label>
            <asp:Label ID="lblProductionDate" runat="server" Text="Production Date:"></asp:Label>
            <asp:TextBox ID="txtProductionDate" runat="server" TextMode="Date"></asp:TextBox>
            

            <button type="submit" runat="server" onserverclick="btnAddProduct_Click" style="margin-right: 10px;">Add Product</button>
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Black"></asp:Label>
            <button type="button" class="button-link" onclick="location.href='ViewMyProducts.aspx'" style="margin-right: 10px;">View My Products</button>
            <button type="button" runat="server" onserverclick="btnLogout_Click">Logout</button>

            <div class="farming-fact" style="text-align: center;">
                Did you know? There are more microorganisms in a teaspoon of soil than there are people on Earth. Soil health is crucial for sustainable agriculture.
            </div>
            <div style="text-align: center;">
                <asp:Image ID="imgGrass" runat="server" Height="522px" ImageUrl="~/Images/Grass.jpg" Width="1000px" ImageAlign="Middle" />
            </div>
        </div>
    </form>
</body>
</html>



