namespace PrimeFactorsKata.FSharp

open PrimeFactorsKata

type FunctionalPrimeFinder() = 
    let rec FindDivisor (candidate:int64, number:int64) : int64 =
        if number % candidate = 0L then
            candidate
        else if number / candidate < candidate then
            number
        else
            FindDivisor(candidate + 1L, number)

    let rec DoFindFactors (value: int64) : PrimeSet =
        if value <= 1L then 
            upcast new PrimeFactorsKata.Empty()
         else 
            let divisor = FindDivisor(2L, value)
            upcast new PrimeFactorsKata.NonEmpty(divisor, DoFindFactors(value / divisor))
    
// public members
    interface IFactorFinder with
        member this.FindFactors(num) = DoFindFactors(num)
