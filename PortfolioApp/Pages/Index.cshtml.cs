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
            new SkillItem { Name="C#", Image="/images/csharpimg.png" },
            new SkillItem { Name="HTML", Image="/images/htmlimg.png" },
            new SkillItem { Name="CSS", Image="/images/cssimg.png" },
            new SkillItem { Name="JavaScript", Image="/images/jsimg.png"},
            new SkillItem { Name="React", Image="/images/reactimg.png"},
            new SkillItem { Name="Node.js", Image="/images/nodeimg.png"},
            new SkillItem { Name="SQL", Image="/images/sqlimg.png"},
            new SkillItem { Name="Mongo", Image="/images/mongoimg.png"},
            new SkillItem { Name="GIT", Image="/images/gitimg.png"},
            new SkillItem { Name="Postman", Image="/images/postmanimg.png"}
            };
        }
    }
}
