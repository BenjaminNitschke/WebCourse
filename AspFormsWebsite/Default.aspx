<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Pong Game Website</title>
	<link rel="stylesheet" type="text/css" href="site.css"/>
</head>
<body>
    <form id="form1" runat="server">
<nav>
	<a href="Default.aspx">Overview</a><br/>
	<a href="About.aspx">About</a>
</nav>
<section>
	<h1>Overview</h1>
	Greates game ever!<br/>
	<br/>
	<asp:ScriptManager ID="ScriptManager1" runat="server"/>
	<asp:UpdatePanel ID="UpdatePanel1" runat="server">
		<ContentTemplate>
			Enter your name: 
			<asp:TextBox ID="NameTextBox" runat="server" ToolTip="Enter your name"/>
			<asp:Button ID="ShowNameButton" runat="server" Text="Show Name" OnClick="ShowNameButtonOnClick"/><br>
			<asp:Label ID="NameLabel" runat="server"/>
		</ContentTemplate>
	</asp:UpdatePanel>
	<asp:Label ID="HighscoreLabel" runat="server"/>
</section>
    </form>
</body>
</html>
