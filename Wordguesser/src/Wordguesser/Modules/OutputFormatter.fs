namespace Wordguesser

module OutputFormatter =
    
    let GenerateOutput (word: string) (guessed: char seq) = 
        printfn "Word Length: %i" word.Length
        printfn "Guessed Letters: %A" guessed
        printfn  "%s" (WordLeft.wordleft word guessed)

