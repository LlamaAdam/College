<%@ Page Language="C#" AutoEventWireup="true" CodeFile="review.aspx.cs" Inherits="db" EnableSessionState=true%>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:label id="userlog" runat="server" Wrap="true"></asp:label><br />
        Please leave a review for the movie here.<br />
        Your rating on a scale of 1-10.
        <asp:TextBox runat="server" id="Rating" />
        <asp:RangeValidator Type="Integer" id="rngDate" controltovalidate="Rating" minimumvalue="1" maximumvalue="10" errormessage="Please enter a correct number." runat="server"/><br />
        Please leave a review of what you thought of the movie.
        <asp:TextBox runat="server" id="review" Rows="10" MaxLength="250" Width="50%"/><br />
        <asp:Button onclick="submit" runat="server" text="Leave Review"/>
        <asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
        <br />If for some reason you dont want to leave a review just click this button.
        <asp:Button onclick="mainer" runat="server" text="I kick babies." />
    </form>
</body>
</html>