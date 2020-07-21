<%@ Page Language="C#" AutoEventWireup="true" CodeFile="grid_view.aspx.cs" Inherits="db" EnableSessionState=true%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
      <asp:Panel ID="panel1" runat="server" Wrap="true" Visible="true">

    <asp:Button id="grid" onclick="btnSubmit_Click_one" runat="server" Text="Submit"></asp:Button>
   
      
          
   </asp:Panel>
        
    <asp:Panel ID="panel3" runat="server" Wrap="true" Visible="false">
    
        <asp:GridView id="data" AutoGenerateColumns="false"
    BorderWidth="2" BorderStyle="Solid" BorderColor="Red"
    CellPadding="5" GridLines="Vertical" runat="server"
      DataKeyNames="id"          
       OnRowDeleting="btnSubmit_delete_record"            OnRowUpdating="btnSubmit_update_record"         
        OnRowEditing="btnSubmit_Click_one"          
                  
                  
                  >
    <HeaderStyle Font-Bold="true"
      BackColor="DarkBlue" ForeColor="White"/>
    <AlternatingRowStyle BackColor="LightGray"/>
    <Columns>
      <asp:BoundField DataField="id"
        HeaderText="Employee ID"/>
      <asp:BoundField DataField="first_name"
        HeaderText="First Name"/>
      <asp:BoundField DataField="last_name"
        HeaderText="Last Name"/>
      <asp:BoundField DataField="address"
        HeaderText="Address"/>
    <asp:CommandField ShowEditButton="true" />
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
      <asp:BoundField DataField="id"
        HeaderText="Employee ID"/>
      <asp:BoundField DataField="first_name"
        HeaderText="First Name"/>
      <asp:BoundField DataField="last_name"
        HeaderText="Last Name"/>
      <asp:BoundField DataField="address"
        HeaderText="Address"/>
    </Columns>
  </asp:GridView>
            
            
            
       </asp:Panel> 
<asp:Panel ID="panel6" runat="server" Wrap="true" Visible="false">
      
         <h2>pick a user/h2>
            <asp:GridView id="photo_data" AutoGenerateColumns="false"
    BorderWidth="2" BorderStyle="Solid" BorderColor="Red"
    CellPadding="5" GridLines="Vertical" runat="server">
    <HeaderStyle Font-Bold="true"
      BackColor="DarkBlue" ForeColor="White"/>
    <AlternatingRowStyle BackColor="LightGray"/>
    <Columns>
      <asp:BoundField DataField="id"
        HeaderText="Employee ID"/>
      <asp:BoundField DataField="firstname"
        HeaderText="First Name"/>
      <asp:BoundField DataField="lastname"
        HeaderText="Last Name"/>
        <asp:BoundField DataField="image_loc"
        HeaderText="image_loc"/>
        
        <asp:ImageField DataImageUrlField="image_loc"></asp:ImageField>
        
    </Columns>
  </asp:GridView>
            
            
            
       </asp:Panel> 
        
        
        
        
        
        
    </div>
    </form>
</body>
</html>
