using System;
using System.Configuration;
using MongoDB.Driver;
using PongDatabase.Mongo;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		var connectionString = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
		var client = new MongoClient(connectionString);
		var database = client.GetServer().GetDatabase("Pong");
		var highscores = database.GetCollection<HighScore>("HighScore").FindAll();
		var players = database.GetCollection<Player>("Player").FindAll();
		HighscoreLabel.Text = "<ul>";
		foreach (var scoreUser in highscores)
			foreach (var player in players)
				if (player.Id == scoreUser.PlayerId)
					HighscoreLabel.Text += "<li>Rank " + scoreUser.PositionInRanking + ". " +
						player.Username + " Score: " + scoreUser.Score;
		HighscoreLabel.Text += "</ul>";
	}

	public void ShowNameButtonOnClick(object sender, EventArgs eventArgs)
	{
		NameLabel.Text = "Welcome " + NameTextBox.Text;
		NameTextBox.Text = "";
	}
}