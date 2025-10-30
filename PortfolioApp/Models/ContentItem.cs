// Models/ContentItem.cs
public abstract class ContentItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Repository { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    // Método virtual para obtener un resumen
    public virtual string GetSummary()
    {
        // sintaxis: return string
        return $"{Title} - {Description}";
    }
}

/* Models/ProjectItem.cs
public class ProjectItem : ContentItem
{
    public string Url { get; set; } = "";
    public string[] Tags { get; set; } = new string[0];

    // override para dar un resumen más específico
    public override string GetSummary()
    {
        // Usa base.GetSummary() si necesitas la implementación del padre
        var baseSummary = base.GetSummary();
        return $"{baseSummary} (proyecto) - tags: {string.Join(",", Tags)}";
    }
}
*/