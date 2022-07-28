using Microsoft.AspNetCore.Mvc;
using SoteriaApp.Shared.enums;
using SoteriaProjectWebApi.Interfaces;
using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentProfileController : ControllerBase
    {
        private readonly ISoteriaDbRepository _soteriaDbRepository;

        public ParentProfileController(ISoteriaDbRepository soteriaDbRepository)
        {
            _soteriaDbRepository = soteriaDbRepository;
        }

        [HttpPost]
        public IActionResult CreateParentProfile([FromBody] ParentProfile parentProfile)
        {
            try
            {
                if (parentProfile == null || !ModelState.IsValid)

                {
                    return BadRequest(SystemErrorCodes.ParentProfileNotValid.ToString());

                }
                _soteriaDbRepository.CreateNewParentProfile(parentProfile);
            }
            catch (Exception)
            {
                return BadRequest(SystemErrorCodes.ParentProfileCreationFailed.ToString());

            }
            return Ok(parentProfile);
        }

            [HttpGet("byparentprofileid")]

            public ParentProfile Get([FromQuery] int parentprofileid)
            {
               return _soteriaDbRepository.GetParentProfileById(parentprofileid);
            }


    }
}
