/// <reference path="jquery.d.ts" />
window.onload = function () {
    $('#highscores').html("Loading ...");
    $.getJSON("http://localhost:3000/Highscores", function (json) {
        var tableHtml = "<table>" +
            "<tr><th>Rank</th><th>Player</th><th>Score</th></tr>";
        json.sort(function (a, b) { return (a.PositionInRanking > b.PositionInRanking ? 1 : -1); });
        json.forEach(function (score) { return tableHtml += writeScore(score); });
        tableHtml += "</table>";
        $('#highscores').html(tableHtml);
    });
};
var HighScore = (function () {
    function HighScore(Player, PositionInRanking, Score) {
        this.Player = Player;
        this.PositionInRanking = PositionInRanking;
        this.Score = Score;
    }
    return HighScore;
})();
function writeScore(score) {
    return "<tr><td>" + score.PositionInRanking + ".</td>" +
        "<td>" + score.Player + "</td>" +
        "<td>" + score.Score + "</td></tr>";
}
//# sourceMappingURL=app.js.map