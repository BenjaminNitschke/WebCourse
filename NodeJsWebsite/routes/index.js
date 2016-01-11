var express = require('express');
var router = express.Router();

router.get('/', function(req, res, next) {
  var highscores = req.db.get('HighScore');
  var players = req.db.get('Player');
  players.find({}, function(e, playerData){
    highscores.find({}, function(e, scoreUsers){
		for (scoreUser of scoreUsers)
			for (player of playerData)
				if (player._id.equals(scoreUser.PlayerId))
					scoreUser.Username = player.Username;
		res.render('index', { title: 'Highscores', scores: scoreUsers });
	  });
  });
});

router.get('/about', function(req, res, next) {
  res.render('about', {});
});

module.exports = router;
