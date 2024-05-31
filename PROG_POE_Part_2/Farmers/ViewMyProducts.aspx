<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMyProducts.aspx.cs" Inherits="PROG_POE_Part_2.Farmers.ViewMyProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/Site.css" rel="stylesheet" />
    <title>View My Products</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>My Products</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <asp:TextBox ID="txtProductNameToDelete" runat="server" placeholder="Enter product name to delete"></asp:TextBox>
            <button type="button" runat="server" onserverclick="btnDeleteProduct_Click" style="margin-left: 2.5px;">Delete Product</button>
            <br /><br />
            <asp:GridView ID="gvMyProducts" runat="server" CssClass="grid-view" AutoGenerateColumns="False" ShowHeaderWhenEmpty ="true">
                <Columns>
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                    <asp:BoundField DataField="Category" HeaderText="Category" />
                    <asp:BoundField DataField="ProductionDate" HeaderText="Production Date" DataFormatString="{0:yyyy-MM-dd}" />
                </Columns>
            </asp:GridView>
             <button type="button" runat="server" onserverclick="btnReturnHome_Click" style="margin-top: 10px">Home</button>
             <button type="button" runat="server" onserverclick="btnLogout_Click" style="margin-left: 2.5px;">Logout</button>
            <div class="farming-fact" style="text-align: center;">
                Did you know? One-third of the world's food production depends on pollinators like bees. Protecting pollinators is vital for food security.
            </div>
            <div style="text-align: center;">
                <asp:Image ID="imgGrass" runat="server" Height="522px" ImageUrl="~/Images/Grass.jpg" Width="1000px" ImageAlign="Middle" />
            </div>
        </div>
    </form>
</body>
</html>








