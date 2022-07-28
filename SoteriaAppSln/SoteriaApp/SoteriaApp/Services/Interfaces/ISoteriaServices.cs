using SoteriaProjectWebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoteriaApp.Services.Interfaces
{
    public interface ISoteriaService
    {
        void CreateNewLearnerProfile(LearnerProfile learnerProfile);
    }
}
