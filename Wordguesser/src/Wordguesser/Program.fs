// Learn more about F# at http://fsharp.org

open System
open Wordguesser

[<EntryPoint>]
let main argv =
    printfn "Hello"

    let word = GetRandomWord.GetWord
    let mutable guesses = Seq.empty
    let mutable gameState = true

    while(gameState) do
        let guess = Console.ReadKey().KeyChar;

        if (Seq.contains guess guesses) then
            printfn "You've already guessed on that letter"
        else
            guesses <- Seq.append guesses [Char.ToUpper guess]
            printfn "" 
            OutputFormatter.GenerateOutput word guesses

    0 // return an integer exit code
