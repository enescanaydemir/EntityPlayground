using System;

namespace EntityPlayground.src.TutorialProject.Domain.Entities;

public class KPIsCategory
{
    private KPIsCategory()
    {
    }
    public KPIsCategory(string? name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public ICollection<KPIs>? KPIs { get; set; }
}
