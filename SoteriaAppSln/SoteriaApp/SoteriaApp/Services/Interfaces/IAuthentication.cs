using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoteriaApp.Services.Interfaces
{
    public  interface IAuthentication
    {
        Task <bool> Authenticate(string email, string Password);
    }
}
