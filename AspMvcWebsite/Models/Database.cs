using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using MongoDB.Driver;

namespace AspMvcWebsite.Models
{
	public class Database
	{
		public Database()
		{
			var connectionString = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
			var client = new MongoClient(connectionString);
			database = client.GetDatabase("Pong");
		}

		private readonly IMongoDatabase database;

		public List<HighScore> GetAllHighscores()
		{
			return database.GetCollection<HighScore>("HighScore").AsQueryable().ToList();
		}

		public List<Player> GetAllPlayers()
		{
			return database.GetCollection<Player>("Player").AsQueryable().ToList();
		}
	}
}