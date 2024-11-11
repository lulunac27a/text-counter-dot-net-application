namespace TextCounterRazor.Pages
{
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
            this.TextContent = this.Request.Form["textContent"]; //get text box input
            this.Characters = this.TextContent?.Length ?? 0; //update number of characters, words and lines based on entered text
            this.Words =
                this.TextContent?.Split(
                    new char[] { ' ', '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries
                ).Length ?? 0;
            this.Lines =
                this.TextContent?.Split('\n', StringSplitOptions.RemoveEmptyEntries).Length ?? 0;
        }
    }
}
