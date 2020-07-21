<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" EnableSessionState="True"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Page</title>
</head>
<body>
        
        <form id="form1" runat="server">
            <asp:Panel ID="userbutton" runat="server" Wrap="true" Visible="true">
                Check Movies options here:
                <asp:Button onclick="entersite" runat="server" text="Enter here"/><br>
                View Checked Out Movies here:
                <asp:Button onclick="moviesout" runat="server" text="Check here"/><br>
                <asp:label id="userlog" runat="server" Wrap="true"></asp:label>
            </asp:Panel>
        <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false">    
   <asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
        </asp:Panel>
            <asp:Panel ID="panel3" runat="server" Wrap="true" Visible="true">
            <asp:GridView id="data" AutoGenerateColumns="false"
    BorderWidth="2" BorderStyle="Solid" BorderColor="Red"
    CellPadding="5" GridLines="Vertical" runat="server"
      DataKeyNames="movieID"          
OnRowDeleting="btnSubmit_update_record">
    <HeaderStyle Font-Bold="true"
      BackColor="DarkBlue" ForeColor="White"/>
    <AlternatingRowStyle BackColor="LightGray"/>
    <Columns>
        <asp:BoundField DataField="MovieID"
        HeaderText="Movie Number"/>
      <asp:BoundField DataField="TitleOfMovie"
        HeaderText="Title Of Movie"/>
        <asp:ImageField DataImageUrlField="ImgLoc"
        HeaderText="Image"/>
   <asp:CommandField ShowDeleteButton="true" />
                </Columns>   
                </asp:GridView>
             </asp:Panel>   
     <asp:Panel ID="panel4" runat="server" Wrap="true" Visible="false">
         <asp:ListBox id="lb2Names"    
                      AutoPostBack="true" 
                      OnSelectedIndexChanged="Get_data"
                      runat="server">
           </asp:ListBox>
       </asp:Panel> 
        <asp:Panel ID="panel5" runat="server" Wrap="true" Visible="false">
         <h2>Movie Selected</h2>
            <asp:GridView id="one_data" AutoGenerateColumns="false"
    BorderWidth="2" BorderStyle="Solid" BorderColor="Red"
    CellPadding="5" GridLines="Vertical" runat="server">
    <HeaderStyle Font-Bold="true"
      BackColor="DarkBlue" ForeColor="White"/>
    <AlternatingRowStyle BackColor="LightGray"/>
    <Columns>
      <asp:BoundField DataField="TitleOfMovie"
        HeaderText="Title Of Movie"/>
        <asp:BoundField DataField="DateCheckedOut"
        HeaderText="Date Checked Out"/>
        <asp:BoundField DataField="CheckedOut"
        HeaderText="Currently Out"/>
        <asp:BoundField DataField="SmallDescript"
        HeaderText="Small Description"/>
        <asp:ImageField DataImageUrlField="ImgLoc"
        HeaderText="Image"/>
        <asp:BoundField DataField="rating"
        HeaderText="User Rating"/>
        <asp:BoundField DataField="comment"
        HeaderText="User Comments"/>
    </Columns>
  </asp:GridView>
            <asp:Button onclick="checkout" runat="server" text="Checkout here" Visible="true"/><br/>
            
       </asp:Panel>
            
            <asp:Button onclick="wishlist" runat="server" text="Wishlist Addition" Visible="false" ID="wishbutton"/><br/>
            <asp:Button onclick="mainer" runat="server" text="Main Page"/>
    </form>
</body>

</html>