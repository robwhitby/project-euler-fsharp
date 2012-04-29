(*
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
we can see that the 6th prime is 13.

What is the 10,001st prime number?
*)

let isPrime n = n > 1 && not <| Seq.exists(fun i -> n%i = 0) {2..int(sqrt(float n))}

let primes = Seq.initInfinite(fun n -> n + 2) |> Seq.filter isPrime
 
let nth = Seq.nth 10000 primes

printfn "%i" nth
