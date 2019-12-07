namespace Wordguesser

module GetRandomWord =
    open System
    let random = new System.Random();

    let GetWord =
        let randInt = random.Next(Config.WordList.Length)
        let word = Config.WordList.[randInt]

        if Config.CaseSensitive then
           word.ToString()
        else
            word.ToString().ToUpper()