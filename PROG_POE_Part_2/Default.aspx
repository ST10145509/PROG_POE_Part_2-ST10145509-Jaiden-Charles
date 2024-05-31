<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PROG_POE_Part_2.Default" MasterPageFile="~/Site.master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align: center;">
        <h1>Welcome to Agri-Energy Connect</h1>
        <p>Connecting Farmers around the world for a better agricultural future.</p>
        <div class="farming-fact">
            Did you know? Honey never spoils. Archaeologists have found pots of honey in ancient Egyptian tombs that are over 3,000 years old and still perfectly edible.
        </div>
        <div style="text-align: center;">
              <asp:Image ID="imgLogin" runat="server" Height="522px" ImageUrl="~/Images/Grass.jpg" Width="1000px" ImageAlign="Middle" />
        </div>
    </div>
</asp:Content>
