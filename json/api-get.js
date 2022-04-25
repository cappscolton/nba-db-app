const axios = require("axios");
const fs = require("fs");
const api_key = //you need yours here or ask me for mine
const games_options = {
  method: "GET",
  url: "https://api-nba-v1.p.rapidapi.com/games",
  params: { league: "Standard", season: "2021" },
  headers: {
    "X-RapidAPI-Host": "api-nba-v1.p.rapidapi.com",
    "X-RapidAPI-Key": api_key
  }
};

axios
  .request(games_options)
  .then(function (response) {
    fs.writeFileSync("games.json", JSON.stringify(response.data.response, null, 2));
    // console.log(response.data);
  })
  .catch(function (error) {
    console.error(error);
  });

const teams_options = {
  method: 'GET',
  url: 'https://api-nba-v1.p.rapidapi.com/teams',
  params: { nbaFranchise : 1 },
  headers: {
    'X-RapidAPI-Host': 'api-nba-v1.p.rapidapi.com',
    'X-RapidAPI-Key': api_key
  }
};

axios.request(teams_options).then(function (response) {
  fs.writeFileSync("teams.json", JSON.stringify(response.data.response, null, 2));
	// console.log(response.data);
}).catch(function (error) {
	console.error(error);
});
