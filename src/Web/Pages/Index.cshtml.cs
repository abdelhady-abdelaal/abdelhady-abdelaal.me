using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {

        public List<Project> Projects { get; set; }

        public void OnGet()
        {
            Projects = new List<Project>()
            {
                new Project
                {
                    Id = 1,
                    Name = "Personal Portfolio",
                    Teaser = "A personal portfolio web app built using ASP.NET Core for the sole purpose of putting the knowledge to practice.",
                    Thumbnails = ["https://cdn.sanity.io/images/hvisvj7q/production/e203da247fe7721fcbf3b5cf54363dc3df4cad35-1920x1080.png"],
                    Tags = ["ASP.NET Core", "SQLite", "EntityFrameworkCore"]
                },
                new Project
                {
                    Id = 2,
                    Name = "Landing Page",
                    Teaser = "A personal portfolio web app built using ASP.NET Core for the sole purpose of putting the knowledge to practice.",
                    Thumbnails = ["https://www.figma.com/community/resource/7e3463f4-c89a-4227-849c-cdbde0014d80/thumbnail"],
                    Tags = ["HTML", "Figma", "CSS", "JavaScript"]
                }
            };
        }
    }
}
