using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class TextCounterModel : PageModel
{
    [BindProperty]
    public string? TextContent { get; set; } //text content string input from text box
    public int Characters { get; set; } //number of characters
    public int Words { get; set; } //number of words
    public int Lines { get; set; } //number of lines

    public void OnPost()
    {
        TextContent = Request.Form["textContent"]; //get text box input
        Characters = TextContent?.Length ?? 0; //update number of characters, words and lines based on entered text
        Words =
            TextContent
                ?.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Length ?? 0;
        Lines = TextContent?.Split('\n', StringSplitOptions.RemoveEmptyEntries).Length ?? 0;
    }
}
