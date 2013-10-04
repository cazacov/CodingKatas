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
    describe('for multiples of three', function(){
        it('returns "Fizz"', function() {
            var result = fizzBuzzGame.playFizzBuzzGame();
            result[1*3-1].should.equal('Fizz');
            result[2*3-1].should.equal('Fizz');
        })
    });
    describe('for multiples of five', function(){
        it('returns "Buzz"', function() {
            var result = fizzBuzzGame.playFizzBuzzGame();
            result[1*5-1].should.equal('Buzz');
            result[2*5-1].should.equal('Buzz');
        })
    });
    describe('for numbers which are multiples of both three and five', function(){
        it('returns "FizzBuzz"', function() {
            var result = fizzBuzzGame.playFizzBuzzGame();
            result[1*3*5-1].should.equal('FizzBuzz');
            result[2*3*5-1].should.equal('FizzBuzz');
        })
    })


});