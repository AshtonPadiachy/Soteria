using Microsoft.AspNetCore.Mvc;
using SoteriaApp.Shared.enums;
using SoteriaProjectWebApi.Interfaces;
using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class TeacherProfileController: ControllerBase
    {  private readonly ISoteriaDbRepository _soteriaDbRepository;

        public TeacherProfileController(ISoteriaDbRepository soteriaDbRepository)
        {
            _soteriaDbRepository = soteriaDbRepository;
        }

        [HttpPost]
        public IActionResult CreateTeacherProfile([FromBody] TeacherProfile teacherProfile)
        {
            try
            {
                if (teacherProfile == null || !ModelState.IsValid)
                { 
                    return BadRequest(SystemErrorCodes.TeacherProfileNotValid.ToString());

                }

                _soteriaDbRepository.CreateNewTeacherProfile(teacherProfile);
            }
            catch (Exception)
            {
                return BadRequest(SystemErrorCodes.TeacherProfileCreationFailed.ToString());

            }
            return Ok(teacherProfile);
        }

        [HttpGet("byteacherprofileid")]

        public TeacherProfile Get([FromQuery] int teacherprofileid)
        {
            return _soteriaDbRepository.GetTeacherProfileById(teacherprofileid);
        }
    }
}
