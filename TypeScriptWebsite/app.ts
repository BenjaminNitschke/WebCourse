/// <reference path="jquery.d.ts" />
window.onload = () => {
	$('#highscores').html("Loading ...");
	$.getJSON("http://localhost:3000/Highscores", json => {
		var tableHtml = "<table>" +
			"<tr><th>Rank</th><th>Player</th><th>Score</th></tr>";
		json.sort((a, b) => (a.PositionInRanking > b.PositionInRanking ? 1 : -1));
		json.forEach(score => tableHtml += writeScore(score));
		tableHtml += "</table>";
		$('#highscores').html(tableHtml);
	});
};

class HighScore {
	constructor(public Player: string,
		public PositionInRanking: number,
		public Score: number) {}
}

function writeScore(score: HighScore) {
	return "<tr><td>" + score.PositionInRanking + ".</td>" +
		"<td>" + score.Player + "</td>" +
		"<td>" + score.Score + "</td></tr>";
}