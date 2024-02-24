module App

open Browser.Dom
// Text content area
let textcontent =
    document.getElementById ("textContent") :?> Browser.Types.HTMLTextAreaElement

// Update text counter button
let updateText =
    document.getElementById ("updateText") :?> Browser.Types.HTMLButtonElement
// Text counter output
let textOutput =
    document.getElementById ("textOutput") :?> Browser.Types.HTMLDivElement

// Update text counter output when button is clicked
updateText.onclick <-
    fun _ ->
        let textString = textcontent.value
        let characters = textString.Length //number of characters
        let words = textString.Split(' ').Length //number of words
        let lines = textString.Split('\n').Length //number of lines
        textOutput.innerText <- sprintf "Characters: %i\nWords: %i\nLines: %i" characters words lines //update text counter output
