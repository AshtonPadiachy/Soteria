using SoteriaProjectWebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using SoteriaProjectWebApi.enums;
using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Data
{
    public class SoteriaDbRepository : ISoteriaDbRepository
    {
        private SoteriaContext _soteriaContext;

       
        public SoteriaDbRepository(SoteriaContext soteriaContext)
        {
            _soteriaContext = soteriaContext;

        }

        #region TeacherProfile

        public TeacherProfile CreateNewTeacherProfile(TeacherProfile teacherProfile)
        {
            _soteriaContext.TeacherProfiles.Add(teacherProfile);
            _soteriaContext.SaveChanges();
            return teacherProfile;

        }
        public bool DoesTeacherProfileExistById(int id)
        {
            return _soteriaContext.TeacherProfiles.Any(teacher => teacher.TeacherProfileId == id);

        }
        public bool DoesTeacherProfileExistByEmail(string email)
        {
            return _soteriaContext.TeacherProfiles.Any(teacher => teacher.Email == email);

        }
        public List<TeacherProfile> GetAllTeacherProfiles(bool fullFetch = true)
        {
            if (fullFetch)
            {
                var teacherprofiles = _soteriaContext.TeacherProfiles.Include(t => t.LearnerProfiles).ToList();
                return teacherprofiles;

            }
            else
            {
                var teacherprofiles = _soteriaContext.TeacherProfiles.ToList();
                return teacherprofiles;
            }
        }
        public TeacherProfile GetTeacherProfileById(int teacherProfileId, bool fullFetch = true)
        {
            if (fullFetch)
            {
                var teacherprofile = _soteriaContext.TeacherProfiles.Where(t => t.TeacherProfileId == teacherProfileId).Include(t => t.LearnerProfiles).FirstOrDefault();
                return teacherprofile;
            }
            else
            {
                var teacherprofile = _soteriaContext.TeacherProfiles.Where(t => t.TeacherProfileId == teacherProfileId).FirstOrDefault();
                return teacherprofile;

            }
        }
        public TeacherProfile GetTeacherProfileByEmail(string email, bool fullFetch = true)
        {
            if (fullFetch)
            {
                var teacherProfile = _soteriaContext.TeacherProfiles.Where(t => t.Email == email).Include(t => t.LearnerProfiles).FirstOrDefault();
                return teacherProfile;

            }
            else
            {
                var teacherProfile = _soteriaContext.TeacherProfiles.Where(t => t.Email == email).FirstOrDefault();
                return teacherProfile;
            }
        }
        #endregion





        #region ParentProfile
        public ParentProfile CreateNewParentProfile(ParentProfile parentProfile)
        {
            _soteriaContext.ParentProfiles.Add(parentProfile);
            _soteriaContext.SaveChanges();
            return parentProfile;
        }
        public bool DoesParentProfileExistById(int id)
        {
            return _soteriaContext.ParentProfiles.Any(p => p.ParentProfileId == id);
        }

        public bool DoesParentProfileExistByEmail(string email)
        {
            return _soteriaContext.ParentProfiles.Any(parent => parent.Email == email);
        }

        public List<ParentProfile> GetAllParentProfiles(bool fullfetch = true)
        {
            if (fullfetch)
            {
                var parentprofile = _soteriaContext.ParentProfiles.Include(p => p.TeacherProfiles).ToList();
                return parentprofile;
            }
            else
            {
                var parentprofie = _soteriaContext.ParentProfiles.ToList();
                return parentprofie;

            }

        }
        public ParentProfile GetParentProfileByEmail(string email, bool fullfetch = true)
        {
            if (fullfetch)
            {
                var parentprofile = _soteriaContext.ParentProfiles.Where(p => p.Email == email).Include(p => p.TeacherProfiles).FirstOrDefault();
                return parentprofile;
            }
            else
            {
                var parentprofile = _soteriaContext.ParentProfiles.Where(p => p.Email == email).FirstOrDefault();
                return parentprofile;
            }

        }
        public ParentProfile GetParentProfileById(int parentprofileId, bool fullfetch)
        {
            if (fullfetch)
            {
                var parentprofile = _soteriaContext.ParentProfiles.Where(p => p.ParentProfileId == parentprofileId).Include(p => p.TeacherProfiles).FirstOrDefault();
                return parentprofile;

            }
            else
            {
                var parentprofile = _soteriaContext.ParentProfiles.Where(p => p.ParentProfileId == parentprofileId).FirstOrDefault();
                return parentprofile;
            }

        }
        #endregion



        #region LearnerProfile
        public LearnerProfile CreateNewLearnerProfile(LearnerProfile learnerProfile)
        {
            _soteriaContext.learnerProfiles.Add(learnerProfile);
            _soteriaContext.SaveChanges();

            return learnerProfile;

        }
        public bool DoesLearnerProfileExistById(int learnerId)
        {
            return _soteriaContext.learnerProfiles.Any(l => l.LearnerId == learnerId);
        }
        public bool DoesLearnerProfileExitByIdNumber(string IdNumber)
        {
            return _soteriaContext.learnerProfiles.Any(learner => learner.IdNumber == IdNumber);

        }
        public List<LearnerProfile> GetAllLearnerProfiles()
        {
           
                var learnerprofile = _soteriaContext.learnerProfiles.ToList();
                return learnerprofile;
            
        }
        public LearnerProfile GetLearnerProfileById(int learnerId, bool fullFetch = true)
        {
            if (fullFetch)
            {
                var learnerProfile = _soteriaContext.learnerProfiles.Where(l => l.LearnerId == learnerId).Include(l => l.LearnerId).FirstOrDefault();
                return learnerProfile;
            }
            else
            {
                ;
                var learnerProfile = _soteriaContext.learnerProfiles.Where(l => l.LearnerId == learnerId).FirstOrDefault();
                return learnerProfile;
            }
        }
        public LearnerProfile GetLearnrtProfilebyIdnumber(string idNumber, bool fullfetch = true)
        {
            if (fullfetch)
            {
                var learnerprofile = _soteriaContext.learnerProfiles.Where(l => l.IdNumber == idNumber).FirstOrDefault();
                return learnerprofile;
            }
            else
            {
                var learnerprofile = _soteriaContext.learnerProfiles.Where(_ => _.IdNumber == idNumber).FirstOrDefault();
                return learnerprofile;

            }

        }
        public IList<LearnerProfile> GetLearnerProfilesByTeacherProfileId(int teacherprofileId)
        {
            var learnerprofiles = _soteriaContext.learnerProfiles.Where(l => l.TeacherProfileId == teacherprofileId).ToList();
            return learnerprofiles;
        }
        #endregion


        #region Report

        public Report CreateNewReport(Report report)
        {
            _soteriaContext.Reports.Add(report);
            _soteriaContext.SaveChanges();
            return report;
        }
        public IList<Report> GetReportsByLearnerId(int learnerId)
        {
            var reports = _soteriaContext.Reports.Where(r => r.LearnerId == learnerId).ToList();
            return reports;
        }

        public IList<Report> GetReportsByDateTime(DateTime dateTime)
        {
            var reports = _soteriaContext.Reports.Where(r => r.dateTime == dateTime).ToList();
            return reports;
        }

        public Report GetReportsById(int reportsId)
        {
            var reports = _soteriaContext.Reports.Where(r => r.ReportsId == reportsId).FirstOrDefault();
            return reports;
        }

        #endregion

        #region Authentication

        public bool PerformAuthenticationCheck(string email, string password)
        {
            var person = _soteriaContext.Authentications.Where(a => a.Email == email && a.Password == password).FirstOrDefault();
            if (person! == null)
            {
                return true;
            }

            return false;
        }

        public teacherProfile CreateNewProfile(teacherProfile teacherProfile)
        {
            throw new NotImplementedException();
        }

        public bool DoesLearnerProfileExistbyIdNumber(string idNumber)
        {
            throw new NotImplementedException();
        }

        public ParentProfile GetParentProfileById(int parentprofileId)
        {
            throw new NotImplementedException();
        }

        public IList<LearnerProfile> GetLearnerProfilesByTearcherProfileId(int teacherprofileId)
        {
            throw new NotImplementedException();
        }

        public ParentProfile GetParentProfileId(int parentprofileId, bool fullfetch = true)
        {
            throw new NotImplementedException();
        }


        public LearnerProfile GetLearnerProfileByIdNumber(string IdNumber, bool fullfetch = true)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
