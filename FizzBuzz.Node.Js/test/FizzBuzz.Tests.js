/**
 * Created with JetBrains WebStorm.
 * User: Victor
 * Date: 04.10.13
 * Time: 17:47
 * To change this template use File | Settings | File Templates.
 */
var should = require('should');
var fizzBuzzGame = require('../FizzBuzzGame');

describe("FizzBuzz Game", function() {
    describe('when called', function() {
        it('should return non-empty array of results', function() {
            fizzBuzzGame.playFizzBuzzGame();

        });
    });
});