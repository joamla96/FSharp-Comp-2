namespace Wordguesser

module GetRandomWord =
    open System

    let random = System.Random();

    let GetWord =
        let word = Config.WordList.[random.Next(0, Config.WordList.Length-1)]
        if Config.CaseSensitive then
           word.ToString()
        else
            word.ToString().ToUpper()