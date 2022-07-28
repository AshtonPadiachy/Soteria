using Microsoft.AspNetCore.Mvc;
using SoteriaApp.Shared.enums;
using SoteriaProjectWebApi.Interfaces;
using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnerProfileController : ControllerBase
    {
        private readonly ISoteriaDbRepository _soteriaDbRepository;
        public LearnerProfileController(ISoteriaDbRepository soteriaDbRepository)
        {
            _soteriaDbRepository = soteriaDbRepository;
        }
        [HttpPost]

        public IActionResult CreateNewLearnerProfile([FromBody] LearnerProfile learnerProfile)
        {
            try
            {
                if (learnerProfile == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.LearnerProfileNotValid.ToString());
                }
                _soteriaDbRepository.CreateNewLearnerProfile(learnerProfile);
            }
            catch (Exception)
            {
                return BadRequest(SystemErrorCodes.LearnerProfileCreationFailed.ToString());
            }
            return Ok(learnerProfile);
        }

        [HttpGet("byteacherprofileid")]

        public IList<LearnerProfile> Get([FromQuery]int teacherprofileid)
        {
            return _soteriaDbRepository.GetLearnerProfilesByTearcherProfileId(teacherprofileid);
        }
    }
}
