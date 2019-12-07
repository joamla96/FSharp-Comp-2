// Learn more about F# at http://fsharp.org

open System
open Wordguesser

[<EntryPoint>]
let main argv =
    printfn "Hello"

    let word = GetRandomWord.GetWord
    let mutable guesses = seq {'A'; 'B'; 'P'}

    guesses <- Seq.append guesses ['E']

    OutputFormatter.GenerateOutput word guesses

    0 // return an integer exit code
