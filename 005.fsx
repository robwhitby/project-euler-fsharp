(*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*)

let rec gcd i j = if j = 0L then i else gcd j (i%j)

let lcm i j = i * j / (gcd i j)

let smallest = {1L..20L} |> Seq.fold(lcm)(1L)

printfn "%i" smallest
