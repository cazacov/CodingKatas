/**
 * Created with JetBrains WebStorm.
 */
var fizzBuzzGame = require('../FizzBuzzGame');
var should = require('should');

describe("FizzBuzz Game", function() {
    describe('when called', function() {
        it('should return non-empty array of results', function() {
            var result = fizzBuzzGame.playFizzBuzzGame();
            should.exist(result);
        });
    });
    describe('when called with game length = 100', function() {
        it('returns an array with exactly 100 strings', function() {
            var result = fizzBuzzGame.playFizzBuzzGame(100);
            result.should.have.lengthOf(100);

        });
    });
    describe('as the first result', function() {
        it('returns 1', function() {
            var result = fizzBuzzGame.playFizzBuzzGame();
            result[0].should.equal(1);
        });
    });
    describe('as the second result', function() {
        it('returns 2', function() {
            var result = fizzBuzzGame.playFizzBuzzGame();
            result[1].should.equal(2);
        });
    });
});