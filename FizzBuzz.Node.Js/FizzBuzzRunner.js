/**
 * Created with JetBrains WebStorm.
 * User: Victor
 * Date: 04.10.13
 * Time: 16:49
 * To change this template use File | Settings | File Templates.
 */
var fizzBuzzGame = require('./FizzBuzzGame.js');

var gameResult = fizzBuzzGame.playFizzBuzzGame();

for (var i = 0; i < gameResult.length; i++)
{
    console.log(gameResult[i]);
}
