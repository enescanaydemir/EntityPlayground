using System;

namespace EntityPlayground.src.TutorialProject.Domain.Entities
{
    public class ApplicationUsers
    {
        private ApplicationUsers()
        {
        }
        public ApplicationUsers(string? firstName, string? lastName, string? email = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }


        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }

        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; }

        public ApplicationRoles? Role { get; set; } // Bir kullanıcı sadece bir role sahip olabilir.
        public ICollection<Companies>? Companies { get; set; }
    }
}
