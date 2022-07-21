using System;
namespace SoteriaProjectWebApi.Models
{
    public class RegistrationTable
    {
        public RegistrationTable(string userName)
        {
            UserName = userName;
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FullName{ get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


    }
}
