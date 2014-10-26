package primeFactorsKata

object FactorsFinder {

  def findPrimeFactors(number: Long) : List[Long] =
    if (number <= 1)
      List()						// return empty list
    else {
      val divisor = findDivisor(2, number)
      divisor :: findPrimeFactors(number / divisor)
    }
  
  def findDivisor(candidate: Long, number: Long) : Long =
    if (number % candidate == 0)	
    	candidate						//candidate is the exact divisor of the number!
    else if (candidate > number / candidate) 
    	number							// it makes no sense to test candidates above sqrt(number)
    else 
    	findDivisor(candidate + 1, number)  	// try next candidate
}

object Main extends App {
  
  val bigNumber = 2147483647L
  val factors = FactorsFinder.findPrimeFactors(bigNumber)
  
  println("Prime factors of " + bigNumber + " are: ")  
  println(factors.mkString(","))
}
