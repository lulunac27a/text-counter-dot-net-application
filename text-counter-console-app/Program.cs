Console.WriteLine("Type text, then press Ctrl+D to calculate the number of characters, words and lines.");
string textContent = "";
while (true)
{
    string textInput = Console.ReadLine();//read text input in each line
    if (textInput == null | textInput == "")//if Ctrl+D is pressed or text input is empty
    {
        break;//end while loop
    }
    textContent += textInput + '\n';//add text content from entered text input for each line
}
Console.WriteLine($"Characters: {textContent.Length}");//number of characters
Console.WriteLine($"Words: {textContent.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length}");//number of words
Console.WriteLine($"Lines: {textContent.Split('\n', StringSplitOptions.RemoveEmptyEntries).Length}");//number of lines