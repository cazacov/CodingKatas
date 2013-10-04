/**
 * FizzBuzz game as described in http://codingdojo.org/cgi-bin/wiki.pl?KataFizzBuzz
 */
module.exports = function() {

    function playFizzBuzzGame(gameLength)
    {
        var i;
        var result = [];

        // default game length is 100
        gameLength = typeof gameLength !== 'undefined' ? gameLength : 100;

        for (i = 1; i<= gameLength; i++)
        {
            if (i % (3*5) == 0) {
                result.push('FizzBuzz');
            }
            else if (i % 3 == 0) {
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

    // JavaScript mumbo-jumbo to simulate "normal" class behavior
    return {
        playFizzBuzzGame: playFizzBuzzGame
    };
}();