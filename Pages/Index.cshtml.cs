using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace PlantDiary002.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            String myName = "Brandan Jones";
            int age = 29;
            ViewData["MyName"] = myName;
            ViewData["Age"] = age;
        }
    }
}
