using System.Collections.Generic;
using AspMvcWebsite.Models;
using NUnit.Framework;

namespace AspMvcWebsite.Tests.Models
{
	public class HighscoresTests
	{
		[Test]
		public void GetAllHighscores()
		{
			var database = new Database();
			List<HighScore> scores = database.GetAllHighscores();
			Assert.That(scores, Is.Not.Empty);
			List<Player> players = database.GetAllPlayers();
			Assert.That(players, Is.Not.Empty);
		}
	}
}
