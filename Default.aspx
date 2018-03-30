<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
</head>
<body>
    <p>Home Page</p>
    <a href="#">Home</a> | <a href="Registration.aspx">Registration</a>
    <!--
        username:webuser
        password:webuser2017

        -->

    <form id="form1" runat="server">
        <div>


            <p>Enter Username</p>
            <asp:TextBox ID="usernameTextBox" Text="" runat="server"/>
            <p>Enter Password</p>
            <asp:TextBox ID="passwordTextBox" Text="" runat="server"/>

            <asp:Button ID="submitButton" Text="Log In" runat="server" OnClick="submitEventMethod"/>
            
        </div>
    </form>
</body>
</html>
