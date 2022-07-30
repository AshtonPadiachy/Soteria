using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Interfaces
{
    public interface ISoteriaDbRepository
    {
        TeacherProfile CreateNewTeacherProfile(TeacherProfile teacherProfile);
        ParentProfile CreateNewParentProfile(ParentProfile parentProfile);
        LearnerProfile CreateNewLearnerProfile(LearnerProfile learnerProfile);
        Report CreateNewReport(Report report);
        bool DoesTeacherProfileExistByEmail(string email);
        bool DoesTeacherProfileExistById(int teacherprofileId);

        bool DoesParentProfileExistByEmail(string email);
        bool DoesParentProfileExistById(int parentprofileId);
      
        bool DoesLearnerProfileExistById(int learnerId);
        bool DoesLearnerProfileExistbyIdNumber(string idNumber);

        List<TeacherProfile> GetAllTeacherProfiles( bool fullfetch = true);
        List<ParentProfile> GetAllParentProfiles(bool fullfetch = true);
        List<LearnerProfile> GetAllLearnerProfiles();
        ParentProfile GetParentProfileById(int parentprofileId);
       
       // IList<TeacherProfile> GetTeacherProfilesByProfileId(int teacherprofileId);
       // IList<ParentProfile> GetParentProfileByProfileId(int parentprofileId);
        IList<LearnerProfile> GetLearnerProfilesByTearcherProfileId(int teacherprofileId);
       
        TeacherProfile GetTeacherProfileByEmail(string email, bool fullfFetch = true);
        TeacherProfile GetTeacherProfileById(int teacherProfileId, bool fullFetch = true);
        //TeacherProfile GetTeacherProfilebyPassword(string password, bool fullfetch = true);
        ParentProfile GetParentProfileByEmail(string email, bool fullFetch = true);
        ParentProfile GetParentProfileId(int parentprofileId, bool fullFetch = true);
       // ParentProfile GetParentProfilePassword(int password, bool fullfetch = true);

        LearnerProfile GetLearnerProfileById(int learnerId, bool fullFetch = true);
       // LearnerProfile GetLearnerProfileByName(string learnername, bool fullfetch = true);
        LearnerProfile GetLearnerProfileByIdNumber(string IdNumber, bool fullFetch = true);
     
        //IList<Reports> GetReportsByLearnerProfile(int LearnerProfileId);
        IList<Report> GetReportsByDateTime( DateTime dateTime);
        IList<Report> GetReportsByLearnerId(int learnerId);
        Report GetReportsById(int reportsId);
        bool PerformAuthenticationCheck(string email, string password);






    }
}

