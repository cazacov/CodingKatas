package primeFactorsKata

import org.scalatest.FunSuite
import org.junit.runner.RunWith
import org.scalatest.junit.JUnitRunner

@RunWith(classOf[JUnitRunner])
class FactorsFinderSuite extends FunSuite {

  test("2 has single prime factor: 2") {
    val expected = List(2)
    val actual = FactorsFinder.findPrimeFactors(2)
    assert(expected  === actual)
  }
  
   test("3 has single prime factor: 3") {
    val expected = List(3)
    val actual = FactorsFinder.findPrimeFactors(3)
    assert(expected  === actual)
  }
   
  test("1 has no prime factors ") {
    val expected = List()
    val actual = FactorsFinder.findPrimeFactors(1)
    assert(expected  === actual)
  }
  
  test("4 is 2 * 2") {
    val expected = List(2, 2)
    val actual = FactorsFinder.findPrimeFactors(4)
    assert(expected  === actual)
  }
  
  test("100 is 2 * 2 * 5 * 5") {
    val expected = List(2, 2, 5, 5)
    val actual = FactorsFinder.findPrimeFactors(100)
    assert(expected  === actual)
  }
  
  test("126 is 2 * 3 * 3 * 7") {
    val expected = List(2, 3, 3, 7)
    val actual = FactorsFinder.findPrimeFactors(126)
    assert(expected  === actual)
  }
  
  test("2^30 should return 30 times 2") {
    val expected = List.fill(30)(2)
    val actual = FactorsFinder.findPrimeFactors(1024L * 1024L * 1024L)
    assert(expected  === actual)
  }
  
   test("11! is factored correctly") {
    val expected = List(2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 5, 5, 7, 11)
    val actual = FactorsFinder.findPrimeFactors(39916800L)
    assert(expected  === actual)
  }
   
   test("Mersenne 31") {
    val expected = List(2147483647L)
    val actual = FactorsFinder.findPrimeFactors(2147483647L)
    assert(expected  === actual)
  }
   
   test("2^63 is not a Mersenne number") {
    val expected = List(7,7, 73, 127, 337, 92737, 649657)
    val actual = FactorsFinder.findPrimeFactors(9223372036854775807L)
    assert(expected  === actual)
  }
}