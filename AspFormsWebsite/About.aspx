<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Pong Game Website</title>
	<link rel="stylesheet" type="text/css" href="site.css"/>
	<script src="https://maps.googleapis.com/maps/api/js"></script>
</head>
<body>
    <form id="form1" runat="server">
<nav>
	<a href="Default.aspx">Overview</a><br/>
	<a href="About.aspx">About</a>
</nav>
<section>
	<h1>About</h1>
  Greatest game company ever, you can find us at:<br/>
	<div id="map" style="height: 600px; width: 800px;"></div>
	<script>
		var mapCanvas = document.getElementById("map");
		var mapOptions = {
			center: new google.maps.LatLng(52.5125, 13.4198),
			zoom: 18
		};
		var map = new google.maps.Map(mapCanvas, mapOptions);
	</script>
</section>
    </form>
</body>
</html>
