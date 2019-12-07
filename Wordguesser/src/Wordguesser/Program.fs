// Learn more about F# at http://fsharp.org

open System
open Wordguesser

[<EntryPoint>]
let main argv =
    printfn "Hello"

    let word = GetRandomWord.GetWord

    printfn "%s" word
    0 // return an integer exit code
