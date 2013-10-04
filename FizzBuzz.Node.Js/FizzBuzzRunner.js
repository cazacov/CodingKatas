/**
 * Console runner for the FizzBuzzGame module
 */
var fizzBuzzGame = require('./FizzBuzzGame.js');

var gameResult = fizzBuzzGame.playFizzBuzzGame();

for (var i = 0; i < gameResult.length; i++)
{
    console.log(gameResult[i]);
}
