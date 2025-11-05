using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioApp.Models;

namespace PortfolioApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<ProjectItem> Projects { get; set; } = new();
        public List<SkillItem> Skills { get; set; } = new();

        public void OnGet()
        {
            Projects = new List<ProjectItem>
            {
                new ProjectItem
                {
                    Id = 1,
                    Title = "Esmae",
                    Description = "Catálogo online de espejos y bazar",
                    Image = "/images/esmaeimg.jpg",
                    Repository = "https://github.com/nicopazz/esmae-frontend",
                    Url = "https://esmae.vercel.app"
                },
                new ProjectItem
                {
                    Id = 2,
                    Title = "Rápidos y Fogosos",
                    Description = "Página de streaming",
                    Image = "/images/rapidosyfogososimg.jpg",
                    Repository = "https://github.com/nicopazz/RapidosyFogosos",
                    Url = "https://rapidosyfogosos.netlify.app"
                },
                new ProjectItem
                {
                    Id = 3,
                    Title = "Rolling Shop",
                    Description = "E-commerce de ropa de gala",
                    Image = "/images/rollingshopimg.jpg",
                    Repository = "https://github.com/nicopazz/RollingShop",
                    Url = "https://rollingshoptuc.netlify.app"
                }
            };

            Skills = new List<SkillItem>
            {
            new SkillItem {Id = 1, Name="C#", Image="/images/csharpimg.png" },
            new SkillItem { Id = 2,Name="HTML", Image="/images/htmlimg.png" },
            new SkillItem {Id = 3, Name="CSS", Image="/images/cssimg.png" },
            new SkillItem {Id = 4, Name="JavaScript", Image="/images/jsimg.png"},
            new SkillItem { Id = 5,Name="React", Image="/images/reactimg.png"},
            new SkillItem { Id = 6,Name="Node.js", Image="/images/nodeimg.png"},
            new SkillItem { Id = 7,Name="SQL", Image="/images/sqlimg.png"},
            new SkillItem { Id = 8,Name="Mongo", Image="/images/mongoimg.png"},
            new SkillItem { Id = 9,Name="GIT", Image="/images/gitimg.png"},
            new SkillItem { Id = 10,Name="Postman", Image="/images/postmanimg.png"},
            new SkillItem { Id = 11,Name="Visual Studio", Image="/images/visualstudioimg.png"},
            new SkillItem { Id = 12,Name="VS Code", Image="/images/vscodeimg.png"}
            };
        }
    }
}
