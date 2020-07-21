
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConnectionTester.aspx.cs" Inherits="db" EnableSessionState=true%>

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
        
   
    
        
        
       <asp:Panel ID="panel2" runat="server" Wrap="true" Visible="false">    
   <asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
        </asp:Panel>
        
       
        
        
        
        
        
        
    </div>
    </form>
</body>
</html>

