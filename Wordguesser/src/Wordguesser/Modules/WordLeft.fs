namespace Wordguesser

module WordLeft =

    // Idea:
    // Input: Word to guess
    // Input: Array off characters guessed
    // String.Iter on chosen world
    // If array contains the character, output character, else output hidden char from config.

    // https://stackoverflow.com/questions/1158030/check-if-an-element-is-within-a-sequence
    let charUsed (used: char seq) (char: char) = 
        if Seq.exists ((=) char) used then 
            char 
        else
            Config.HiddenChar

    let wordleft (word: string) (guesses: char seq) =
        word |> String.map (charUsed guesses)
