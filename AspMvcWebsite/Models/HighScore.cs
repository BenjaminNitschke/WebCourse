using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AspMvcWebsite.Models
{
	public class HighScore
	{
		[BsonId]
		public ObjectId Id { get; set; }
		public ObjectId PlayerId { get; set; }
		public int Score { get; set; }
		public int PositionInRanking { get; set; }
	}
}