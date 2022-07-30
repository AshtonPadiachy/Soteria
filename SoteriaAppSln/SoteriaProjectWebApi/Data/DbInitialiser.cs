using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Data
{
    public class DbInitialiser
    {
        private readonly SoteriaContext _context;

        public DbInitialiser(SoteriaContext context)
        {
            _context = context;
        }

        public void Run()
        {
            if (!_context.Zones.Any())
            {
                var zone = new Zone();
                zone.Description = "Green";
                _context.Zones.Add(zone);

                zone = new Zone();
                zone.Description = "Yellow";
                _context.Zones.Add(zone);

                zone = new Zone();
                zone.Description = "Blue";
                _context.Zones.Add(zone);

                zone = new Zone();
                zone.Description = "Red";
                _context.Zones.Add(zone);


                _context.SaveChanges();

            }
            if (!_context.ProfileTypes.Any())
            {
                var profileType = new ProfileType();
                profileType.Description = "TeacherProfile";
                _context.ProfileTypes.Add(profileType);

                profileType = new ProfileType();
                profileType.Description = "LearnerProfile";
                _context.ProfileTypes.Add(profileType);

                profileType = new ProfileType();
                profileType.Description = "Guest";
                _context.ProfileTypes.Add(profileType);

                _context.SaveChanges();
            }

            var learnerProfile = new LearnerProfile();


            if (!_context.LearnerProfiles.Any())
            {
                learnerProfile.LearnerName = "Inathi";
                learnerProfile.LearnerSurname = "Jozi";
                learnerProfile.LearnerGender = 1;
                learnerProfile.DateOfBirth = DateTime.Now;
                learnerProfile.IdNumber = "0015568904756";
                learnerProfile.LearnerGrade = 2;
                learnerProfile.ParentName = "Hlubi";
                learnerProfile.ParentSurname = "Jozi";
                learnerProfile.Email = "hlubijozi@gmail.com";
                learnerProfile.ParentAge = 56;
                learnerProfile.MaritalStatus = 2;
                learnerProfile.ParentCellNumber = "0723904705";

                _context.LearnerProfiles.Add(learnerProfile);

                _context.SaveChanges();


            }

            if (!_context.TeacherProfiles.Any())
            {
                var teacherProfile = new TeacherProfile();
                teacherProfile.Email = "janejoe@hudson.co.za";
                teacherProfile.TeacherName = "Jane";
                teacherProfile.TeacherSurname = "Joe";
                teacherProfile.TeacherCellNumber = "0823566877";
                teacherProfile.ProfileTypeId = 1;

                var profile = new Authentication();
                profile.Email = "janejoe@hudson.co,za";
                profile.Password = "123456#";
                profile.Enabled = true;

                teacherProfile.LearnerProfiles = new List<LearnerProfile>();
                teacherProfile.LearnerProfiles.Add(learnerProfile);

                _context.TeacherProfiles.Add(teacherProfile);

                _context.Authentications.Add(profile);


                _context.SaveChanges();


            }

            if (!_context.ParentProfiles.Any())
            {
                var parentProfile = new ParentProfile();
                parentProfile.Email = "hlubijozi@gmail.com";
                parentProfile.ParentName = "Hlubi";
                parentProfile.ParentSurname = "Jozi";
                parentProfile.ParentCellNumber = "0723904705";
                parentProfile.Password = "12345#";
                parentProfile.ParentAge = 56;
                parentProfile.ProfileTypeId = 2;

                var profile = new Authentication();
                profile.Email = "hlubijozi@gmail.com";
                profile.Password = "12345#";
                profile.Enabled = true;

                _context.ParentProfiles.Add(parentProfile);
                _context.Authentications.Add(profile);


                _context.SaveChanges();


            }


            if (_context.Reports.Any())
            {

                var report = new Report();
                report.CommentOnZones = "Child showing progress in attitude and behavior";
                report.CommentOnSocialSkills = "Playful and happy in class";
                report.CommentOnCreativitySkills = "Good imagination and very good with colours";
                report.CommentOnParticipation = "Always interactive in class and asking questions";
                report.Tips = "see Zones Of regulations in solutions in insights page";
                report.dateTime = DateTime.Now;
                report.Participation = 4;
                report.SocialSkills = 3;
                report.CreativitySkills = 4;

                learnerProfile.Reports = new List<Report>();
                learnerProfile.Reports.Add(report);

                //       _context.LearnerProfiles.Add(learnerProfile);
                _context.Reports.Add(report);
                _context.SaveChanges();


            }
        }
    }
}
