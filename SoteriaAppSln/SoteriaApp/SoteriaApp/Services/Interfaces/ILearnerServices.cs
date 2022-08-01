using SoteriaProjectWebApi.Models;
using System.Threading.Tasks;

namespace SoteriaApp.Services.Interfaces
{
    public interface ILearnerService
    {
        //        Task<LearnerResponse> CreateProfile (string LearnerName, string LearnerSurname, int LearnerGender, string IdNumber, int LearnerGrade);
        Task<LearnerProfile> CreateProfile(LearnerProfile learnerProfile);

    }
}
