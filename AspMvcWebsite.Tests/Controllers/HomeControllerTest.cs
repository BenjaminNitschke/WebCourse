using System.Web.Mvc;
using AspMvcWebsite.Controllers;
using NUnit.Framework;

namespace AspMvcWebsite.Tests.Controllers
{
	public class HomeControllerTest
	{
		[SetUp]
		public void CreateController()
		{
			controller = new HomeController();
		}

		private HomeController controller;

		[Test]
		public void Index()
		{
			Assert.That(controller.Index(), Is.InstanceOf<ViewResult>());
		}

		[Test]
		public void WeExpectAHighscoreList()
		{
			var highscorePage = controller.Index() as ViewResult;
			var highscoresText = highscorePage.ViewBag.Highscores as string;
			Assert.That(highscoresText, Is.StringContaining("<td>1.</td><td>User1</td><td>10</td>"));
			Assert.That(highscoresText, Is.StringContaining("<td>2.</td><td>User2</td><td>8</td>"));
		}

		[Test]
		public void About()
		{
			Assert.That(controller.About(), Is.InstanceOf<ViewResult>());
		}
	}
}