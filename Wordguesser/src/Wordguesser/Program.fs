// Learn more about F# at http://fsharp.org

open System
open Wordguesser

[<EntryPoint>]
let main argv =
    printfn "Welcome to Wordgeusser press a letter to start the game"

    let word = GetRandomWord.GetWord
    let mutable guesses = Seq.empty
    let mutable gameState = true

    while(gameState) do
        let guess = Console.ReadKey().KeyChar |> Char.ToUpper;

        if (Seq.contains guess guesses) then
            printfn " You've already guessed on that letter"
        elif not (Seq.contains guess ['A'..'Z']) then
            printfn " This is not an acceptable guess"
        else
            guesses <- Seq.append guesses [guess] 
            printfn "" 
            OutputFormatter.GenerateOutput word guesses

    0 // return an integer exit code
