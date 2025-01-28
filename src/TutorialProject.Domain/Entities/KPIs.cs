using System;

namespace EntityPlayground.src.TutorialProject.Domain.Entities;

public class KPIs
{
    private KPIs()
    {
    }
    public KPIs(string? name, string? unit, int categoryId)
    {
        Name = name;
        Unit = unit;
        CategoryId = categoryId;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Unit { get; set; }
    public string? CalculationMethod { get; set; }
    public int CategoryId { get; set; }
    public bool IsStandard { get; set; }

    public KPIsCategory? Category { get; set; } // Bir KPI bir KPI kategorisine ait olabilir.
    public ICollection<CompanyKPIs>? CompanyKPIs { get; set; } // Bir KPI birden çok şirkete ait olabilir.
}
