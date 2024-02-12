using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class TextCounterModel : PageModel
{
    [BindProperty]
    public string? textContent { get; set; }//text content string input from text box
    public int characters { get; set; }//number of characters
    public int words { get; set; }//number of words
    public int lines { get; set; }//number of lines
    public void OnPost()
    {
        textContent = Request.Form["textContent"];//get text box input 
        characters = textContent?.Length ?? 0;//update number of characters, words and lines based on entered text
        words = textContent?.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length ?? 0;
        lines = textContent?.Split('\n', StringSplitOptions.RemoveEmptyEntries).Length ?? 0;
    }
}