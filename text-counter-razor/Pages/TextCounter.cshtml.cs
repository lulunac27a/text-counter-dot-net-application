using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class TextCounterModel : PageModel
{
    [BindProperty]
    public string textContent { get; set; }
    public int characters { get; set; }
    public int words { get; set; }
    public int lines { get; set; }
    public void OnPost()
    {
        textContent = Request.Form["textContent"];
        characters = textContent.Length;
        words = textContent.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        lines = textContent.Split('\n', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}