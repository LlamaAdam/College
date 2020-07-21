<%@ Page Language="C#" AutoEventWireup="true" CodeFile="delete.aspx.cs" Inherits="db" EnableSessionState=true%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
      <asp:Panel ID="panel1" runat="server" Wrap="true" Visible="true">
    <h3>press SUBMIT to get records to update</h3>
    <asp:Button id="update" onclick="btnSubmit_Click_one" runat="server" Text="Submit"></asp:Button>
   
   </asp:Panel>
        
    <asp:Panel ID="panel3" runat="server" Wrap="true" Visible="false">
    <asp:GridView id="data" AutoGenerateColumns="false"
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
     <asp:Panel ID="panel4" runat="server" Wrap="true" Visible="false">
      
         <asp:ListBox id="lb2Names"    
                      AutoPostBack="true" 
                      OnSelectedIndexChanged="Get_data"
                      
                      runat="server"/>
           </asp:ListBox>
       </asp:Panel> 
        
        
       <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false">    
   <asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
        </asp:Panel>
       
        
        <asp:Panel ID="panel5" runat="server" Wrap="true" Visible="false">
      
         <h2>Update the record you selected</h2>
           <asp:label id="delete_id" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label> 
            <h3>last name</h3>
            <asp:TextBox id="txt2lastname" runat="server"/>
            <h3>first name</h3>
            <asp:TextBox id="txt2firstname" runat="server"/>
            <h3>city</h3>
            <asp:TextBox id="txt2city" runat="server"/>
          <asp:Button id="update_rec" onclick="btnSubmit_delete_record" runat="server" Text="Delete record"></asp:Button>  
       </asp:Panel> 
        
    <asp:Panel ID="panel6" runat="server" Wrap="true" Visible="false"> 
            <h2> <a href="delete.aspx">click to delete another record</a></h2>
        </asp:Panel>    
        
        
        
        
    </div>
    </form>
</body>
</html>
