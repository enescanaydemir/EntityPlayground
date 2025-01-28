using System;

namespace EntityPlayground.src.TutorialProject.Domain.Entities;

public class ApplicationRoles
{
    private ApplicationRoles()
    {
    }
    public ApplicationRoles(string? name, string? description)
    {
        Name = name;
        Description = description;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public ICollection<ApplicationUsers>? ApplicationUsers { get; set; }
}
