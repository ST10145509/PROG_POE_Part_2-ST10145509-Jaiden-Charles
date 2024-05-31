<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="Home.aspx.cs" Inherits="PROG_POE_Part_2.Employees.Home" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <link href="../Content/Site.css" rel="stylesheet" />
    <title>Employee Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employee Home</h2>
             <div style="text-align: center;">
            <button type="button" runat="server" onserverclick="btnAddFarmer_Click" style="margin-right: 10px;" >Add Farmer</button>
            <button type="button" runat="server" onserverclick="btnViewProducts_Click" style="margin-right: 10px;">View Products</button>
            <button type="button" runat="server" onserverclick="btnLogout_Click">Logout</button>
                 </div>
            <div class="farming-fact" style="text-align: center;">
                Did you know? A single acre of soybeans can produce 82,368 crayons. This fact highlights the versatility of agricultural products.
            </div>
            <div style="text-align: center;">
                 <asp:Image ID="imgGrass" runat="server" Height="522px" ImageUrl="~/Images/Grass.jpg" Width="1000px" ImageAlign="Middle" />
            </div>
        </div>
    </form>
</body>
</html>



