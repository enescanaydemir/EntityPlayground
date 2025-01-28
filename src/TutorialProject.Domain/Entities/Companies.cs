using System;

namespace EntityPlayground.src.TutorialProject.Domain.Entities;

public class Companies
{
    private Companies()
    {
    }
    public Companies(string? name, string? ındustry, DateTime createdAt, bool ısActive)
    {
        Name = name;
        Industry = ındustry;
        CreatedAt = createdAt;
        IsActive = ısActive;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Industry { get; set; }
    public string? Size { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }

    public ICollection<CompanyKPIs>? CompanyKPIs { get; set; }
    //public ICollection<CompanyDepartments> CompanyDepartments { get; set; }
    //yukarıda not aldığımız gibi CompanyDepartments tablosunu oluşturmadık. Bir şirketin birden çok departmanı olabilir. projede buna bak.
}
