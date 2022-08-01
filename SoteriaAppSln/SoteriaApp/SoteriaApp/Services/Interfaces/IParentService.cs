using SoteriaProjectWebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoteriaApp.Services.Interfaces
{
    public interface IParentService
    {
        Task<ParentProfile> CreateProfile(ParentProfile ParentProfile);
    }
}
}
