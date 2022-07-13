using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Interfaces
{
    public interface ISoteriaDbRepository
    {
        TeacherProfile CreateNewProfile(TeacherProfile teacherProfile);
        ParentProfile CreateNewParentProfile(ParentProfile parentProfile);
        LearnerProfile CreateNewLearnerProfile(LearnerProfile learnerProfile);
        Reports CreateNewReport(Reports report);    
        bool DoesTeacherProfileExitByEmail (string email);
        bool DoesTeacherProfileExitByUserName(string userName);
        bool DoesTeacherProfileExitByPassword (string password);
        bool DoesParentProfileExistByEmail (string email);
        bool DoesParentProfileExistByPassword (string password);    
        List<TeacherProfile> GetAllTeacherProfiles( bool fullfetch = true);
        TeacherProfile GetTeacherProfileById(int teacherprofileId);
        ParentProfile GetParentProfileById(int  parentprofileId);

        IList<TeacherProfile> GetTeacherProfilesByProfileId(int profileId);
        IList<ParentProfile> GetParentProfileByProfileId(int profileId);
        IList<LearnerProfile> GetLearnerProfilesByLearnerId (int learnerId);    








    }
}
