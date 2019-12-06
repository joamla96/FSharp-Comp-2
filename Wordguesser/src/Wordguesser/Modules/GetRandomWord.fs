namespace Wordguesser

module GetRandomWord =
    let random = System.Random();

    let GetWord =
        Config.WordList.[random.Next(0, Config.WordList.Length-1)]