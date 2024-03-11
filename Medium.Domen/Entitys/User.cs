using System.ComponentModel.DataAnnotations;

namespace Medium.Domen.Entitys
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Bio { get; set; }
        public string PhotoPath { get; set; }
        public int Followers { get; set; }

        public string Login {  get; set; }
        public string PasswordHash { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime JoinDate { get; set; }
        public DateTime ModifiedDate { get; set;}
        public DateTime DateTime {  get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
