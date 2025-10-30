namespace PortfolioApp.Models
{
    public class ProjectItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string[] Tags { get; set; } = Array.Empty<string>();
        public string Repository { get; internal set; } = string.Empty;
    }
}
