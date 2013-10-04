/**
 * Created with JetBrains WebStorm.
 * User: Victor
 * Date: 04.10.13
 * Time: 16:45
 * To change this template use File | Settings | File Templates.
 */
module.exports = function() {

    function _playFizzBuzzGame(gameLength)
    {
        var i;
        gameLength = typeof gameLength !== 'undefined' ? gameLength : 100;
        var result = [];

        for (i = 1; i<= gameLength; i++)
        {
            result.push(i);
        }

        return result;
    }

    return {
        playFizzBuzzGame: _playFizzBuzzGame
    };
}();