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
        ParentProfile GetParentProfileById(int parentprofileId);

        IList<TeacherProfile> GetTeacherProfilesByProfileId(int teacherprofileId);
        IList<ParentProfile> GetParentProfileByProfileId(int parentprofileId);
        IList<LearnerProfile> GetLearnerProfilesByLearnerId (int learnerId); 
        TeacherProfile GetTeacherProfileByEmail (string email, bool fullfetch = true);
        TeacherProfile GetTeacherProfilebyId(int teacherprofileId, bool fullfetch = true);
        TeacherProfile GetTeacherProfilebyPassword (string password, bool fullfetch = true);    
        ParentProfile GetParentProfileByEmail(string email, bool fullfetch = true);
        ParentProfile GetParentProfileId(int parentprofileId, bool fullfetch = true); 
        ParentProfile GetParentProfilePassword(int password, bool fullfetch = true); 

        LearnerProfile GetLearnerProfileById(string learnerId, bool fullfetch = true);
        LearnerProfile GetLearnerProfileByName (string learnername, bool fullfetch = true);    
        LearnerProfile GetLearnerProfileByIdNumber (string IdNumber, bool fullfetch = true);
        IList<Reports> GetReportsByLearnerId( int learnerId);
        IList<Reports> GetReportsByLearnerIdAndDat( int learnerId, DateTime date );
        Reports GetReportsById(int transactionId);
        bool PerformAuthenticationCheck ( string email, string password );
        





    }
}

