(*
The sum of the squares of the first ten natural numbers is
1^2 + 2^2 + ... + 10^2 = 385

The square of the sum of the first ten natural numbers is
(1 + 2 + ... + 10)^2 = 55^2 = 3025

Hence the difference between the sum of the squares of the first ten 
natural numbers and the square of the sum is 3025 - 385 = 2640.

Find the difference between the sum of the squares of the first one 
hundred natural numbers and the square of the sum.
*)

let square i = i*i
let range = {1..100}
let diff = (square(range |> Seq.sum)) - (range |> Seq.sumBy square)

printfn "%i" diff
