<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="db" EnableSessionState="True"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">

    
   <h1>This is the main page</h1>
        <asp:label runat="server" ID="userlog"></asp:label>
    <asp:Panel runat="server">
        <asp:Label id="login" runat="server" Visible="true">
            <h3>email address</h3><asp:TextBox ID="txusername" MaxLength="20" runat="server"   /> 
            <h3>password</h3><asp:TextBox ID="txpassword" MaxLength="20" runat="server"   /> 
            <asp:Button onclick="loginbut" runat="server" text="Click"/><br>
            <asp:Label ID="connected" runat="server"></asp:Label>
        </asp:Label>
<br>
    </asp:Panel>
    <asp:Panel runat="server">
        
        <asp:Button onclick="Search" runat="server" text="Search Box Return "/><br>
        <asp:Label ID="search" runat="server" Visible="false">
            <asp:TextBox ID="searchtext" runat="server"></asp:TextBox>
            <asp:Button OnClick="Run_search" runat="server" text="Search"/>
            <asp:GridView ID="searchresult" runat="server"></asp:GridView>
        </asp:Label>
<br>
    </asp:Panel>
    <asp:Panel runat="server">
        
        <asp:Button  onclick="NewUse" runat="server" text="New User Registration "/> 
        <asp:Panel ID="newuse" runat="server" Wrap="true" Visible="false">
            <h2>enter the following information</h2>
            <h3>last name</h3><asp:TextBox ID="first_name" MaxLength="20" runat="server"   /> 
            <h3>first name</h3><asp:TextBox ID="last_name" MaxLength="20" runat="server"   /> 
            <h3>email address</h3><asp:TextBox ID="email_address" MaxLength="20" runat="server"   /> 
            <h3>password</h3><asp:TextBox ID="password" MaxLength="20" runat="server"   /> 
            <asp:Button id="btnSubmit" onclick="add_record" runat="server" Text="add record"></asp:Button> 
        </asp:Panel>
    </asp:Panel>

        
        <asp:Panel ID="panel5" runat="server" Wrap="true" Visible="true"> 
        </asp:Panel>
        <asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
        </form>
</body>
</html>
