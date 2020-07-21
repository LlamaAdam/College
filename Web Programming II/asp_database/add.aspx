<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="db" EnableSessionState=true%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
      <asp:Panel ID="panel1" runat="server" Wrap="true" Visible="true">
       <h2>enter the following information</h2>
          <h3>id number</h3><asp:TextBox ID="id" MaxLength="3" runat="server"   /> 
        <h3>last name</h3><asp:TextBox ID="first_name" MaxLength="20" runat="server"   /> 
        <h3>first name</h3><asp:TextBox ID="last_name" MaxLength="20" runat="server"   /> 
        <h3>address name</h3><asp:TextBox ID="address" MaxLength="20" runat="server"   /> 
        <h3>city</h3><asp:TextBox ID="city" MaxLength="20" runat="server"   /> 
        <h3>state</h3> <asp:TextBox ID="state" MaxLength="2" runat="server"   /> 
         <asp:Button id="btnSubmit" onclick="add_record" runat="server" Text="add record"></asp:Button> 
   </asp:Panel>
    <asp:Panel ID="panel3" runat="server" Wrap="true" Visible="false">
    
    
    </asp:Panel>
     <asp:Panel ID="panel4" runat="server" Wrap="true" Visible="false">
      
       </asp:Panel> 
       <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false">    
   <asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
        </asp:Panel>
        <asp:Panel ID="panel5" runat="server" Wrap="true" Visible="false"> 
            <h2> <a href="add.aspx">click to add another record</a></h2>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
