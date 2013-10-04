/**
 * Created with JetBrains WebStorm.
 * User: Victor
 */
module.exports = function() {

    function _playFizzBuzzGame(gameLength)
    {
        var i;
        gameLength = typeof gameLength !== 'undefined' ? gameLength : 100;
        var result = [];

        for (i = 1; i<= gameLength; i++)
        {
            if (i % 3 == 0) {
                result.push('Fizz');
            }
            else if (i % 5 == 0) {
                result.push('Buzz');
            }
            else {
                result.push(i);
            }
        }
        return result;
    }

    return {
        playFizzBuzzGame: _playFizzBuzzGame
    };
}();