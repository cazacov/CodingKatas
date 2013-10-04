/**
 * Created with JetBrains WebStorm.
 * User: Victor
 * Date: 04.10.13
 * Time: 17:47
 * To change this template use File | Settings | File Templates.
 */
var fizzBuzzGame = require('../FizzBuzzGame');
describe("FizzBuzz Game", function() {
    it("returns an array of strings", function(done){
        var result =  fizzBuzzGame.playFizzBuzzGame();
        result.should.exist();
        done();

    });
});