namespace Wordguesser

module Config =
    let HiddenChar = '*' // Character used for letters not yet guessed
    let CaseSensitive = false; // Should guesses and words be case sensitive. Eg. if the word is "Apple" and the user types "a" should it count as correct. 
    let AllowBlanks = false; // Weather the system should be allowed to pick items with spaces
    let AllowHelp = false; // Weather the system should allow the use of the "cheat" feature.
    let AllowMultiple = false; // If the user can type in multiple letters. E.g. the word is "apple". The client can type "ap" the result should now be "ap***"

    let WordList = ["Apple"; "grape"; "Slippers";"raccon"; "toast"; "Pancake";"Cabbage"; "Salad"; "hotdog";"cake"; "plate"; "scissors";];