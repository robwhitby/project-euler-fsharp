(*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*)

open Microsoft.FSharp.Math

let rec maxPrimeFactor n: int64 = 
  let f = {2L..int64(sqrt(float n))} |> Seq.tryFind(fun i -> n%i = 0L) 
  match f with
  | Some(f) -> maxPrimeFactor(int64(n/f))
  | None -> n
    
let max = maxPrimeFactor 600851475143L

printfn "%i" max
