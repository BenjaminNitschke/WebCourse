var express = require('express');
var mongo = require('mongodb');
var monk = require('monk');
var app = express();
app.set('port', 3000);
app.use(function (req, res) {
    var db = monk('localhost:27017/Pong');
    var highscores = db.get('HighScore');
    var players = db.get('Player');
    players.find({}, function (e, playerData) {
        highscores.find({}, function (e, scoreUsers) {
            var json = '[';
            scoreUsers.forEach(function (scoreUser) {
                playerData.forEach(function (player) {
                    if (player._id.equals(scoreUser.PlayerId))
                        scoreUser.Player = player.Username;
                });
                if (json.localeCompare('['))
                    json += ',\n';
                json += '{ "Player": "' + scoreUser.Player +
                    '", "PositionInRanking": "' + scoreUser.PositionInRanking +
                    '", "Score": "' + scoreUser.Score + '" }';
            });
            json += ']';
            res.writeHeader(200, {
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': '*'
            });
            res.write(json);
            res.end();
        });
    });
    /*test data
    var json =
        `[{
    "Player" : "Hugo",
    "Score" : 3592,
    "PositionInRanking" : 1
},
{
    "Player" : "Lugo",
    "Score" : 153,
    "PositionInRanking" : 2
},
{
    "Player" : "Lugo",
    "Score" : 153,
    "PositionInRanking" : 2
},
{
    "Player" : "Lugo",
    "Score" : 153,
    "PositionInRanking" : 2
},
{
    "Player" : "Lugo",
    "Score" : 153,
    "PositionInRanking" : 2
}]`;
    */
});
module.exports = app;
//# sourceMappingURL=app.js.map