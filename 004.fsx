(*
A palindromic number reads the same both ways. The largest palindrome made from the
product of two 2-digit numbers is 9009 = 91 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*)
open System

let isPalindrome (n: int): bool = n.ToString() = new string(n.ToString().ToCharArray() |> Array.rev)

let max = 
  seq { 
    for i in {100..999} do
      for j in {i..999} do
        yield i * j
  } |> Seq.filter isPalindrome |> Seq.max

printfn "%i" max
