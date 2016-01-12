using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspMvcWebsite.Models;

namespace AspMvcWebsite.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Highscores =
				"<table>" +
				"<tr><th>Rank</th><th>Player</th><th>Score</th></tr>";
			var database = new Database();
			foreach (var scoreUser in database.GetAllHighscores())
				foreach (var player in database.GetAllPlayers())
					if (player.Id == scoreUser.PlayerId)
						ViewBag.Highscores +=
							"<tr><td>" + scoreUser.PositionInRanking + ".</td>" +
							"<td>" + player.Username + "</td>" +
							"<td>" + scoreUser.Score + "</td></tr>";
			ViewBag.Highscores += "</table>";
			return View();
		}

		public ActionResult About()
		{
			return View();
		}
	}
}