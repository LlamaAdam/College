<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" EnableSessionState="True"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Page</title>
</head>
<body>
        
        <form id="form1" runat="server">
            <asp:Label runat="server" ID="userlog">A</asp:Label>
    <div>   
      <asp:Panel ID="panel1" runat="server" Wrap="true" Visible="true">

    <asp:Button id="grid" onclick="btnSubmit_Click_one" runat="server" Text="Submit"></asp:Button>
   
      
          
   </asp:Panel>
        
    <asp:Panel ID="panel3" runat="server" Wrap="true" Visible="false">
    
        <asp:GridView id="data" AutoGenerateColumns="false"
    BorderWidth="2" BorderStyle="Solid" BorderColor="Red"
    CellPadding="5" GridLines="Vertical" runat="server"
      DataKeyNames="movieid"          
       OnRowDeleting="btnSubmit_delete_record"            OnRowUpdating="btnSubmit_update_record"         
        OnRowEditing="btnSubmit_Click_one">
    <HeaderStyle Font-Bold="true"
      BackColor="DarkBlue" ForeColor="White"/>
    <AlternatingRowStyle BackColor="LightGray"/>
    <Columns>
      <asp:BoundField DataField="movieid"
        HeaderText="Movie ID"/>
      <asp:BoundField DataField="TitleOfMovie"
        HeaderText="Title of Movie"/>
    <asp:CommandField ShowEditButton="true" />
        <asp:CommandField ShowDeleteButton="true" />
        
        </Columns>
        
        
  </asp:GridView> //top edit area
    </asp:Panel>
     <asp:Panel ID="panel4" runat="server" Wrap="true" Visible="false">
      
         <asp:ListBox id="lb2Names"    
                      AutoPostBack="true" 
                      OnSelectedIndexChanged="Get_data"
                      
                      runat="server">
           </asp:ListBox>
       </asp:Panel> 
        
        
       <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false">    
   <asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
        </asp:Panel>
        <asp:Panel ID="panel5" runat="server" Wrap="true" Visible="false">
      
         <h2>in panel 5</h2>
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
    </Columns>
  </asp:GridView>
            
            
            
       </asp:Panel> 
<asp:Panel ID="panel6" runat="server" Wrap="true" Visible="false">
      
    <h2>Movie Description</h2>
            <asp:GridView id="photo_data" AutoGenerateColumns="false"
    BorderWidth="2" BorderStyle="Solid" BorderColor="Red"
    CellPadding="5" GridLines="Vertical" runat="server">
    <HeaderStyle Font-Bold="true"
      BackColor="DarkBlue" ForeColor="White"/>
    <AlternatingRowStyle BackColor="LightGray"/>
    <Columns>
      <asp:BoundField DataField="movieid"
        HeaderText="Employee ID"/>
      <asp:BoundField DataField="TitleOfMovie"
        HeaderText="First Name"/>
        
        <asp:ImageField DataImageUrlField="image_loc"></asp:ImageField>
        
    </Columns>
  </asp:GridView>
            
            
            
       </asp:Panel> 
        
        
        
        
        
        
    </div>
    </form>
</body>

</html>