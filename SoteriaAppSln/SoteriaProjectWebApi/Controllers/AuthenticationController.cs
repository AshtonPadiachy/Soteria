using Microsoft.AspNetCore.Mvc;
using SoteriaApp.Shared;
using SoteriaApp.Shared.enums;
using SoteriaProjectWebApi.Interfaces;

namespace SoteriaProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ISoteriaDbRepository _soteriaDbRepository;
        public AuthenticationController(ISoteriaDbRepository soteriaDbRepository)
        {
            _soteriaDbRepository = soteriaDbRepository;
        }
             
        [HttpPost]
        public IActionResult Post([FromBody] AuthRequest auth)
        {
            try
            {
                var result = _soteriaDbRepository.PerformAuthenticationCheck(auth.Email,auth.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(SystemErrorCodes.AuthenticationFailed.ToString());
            }
        }
       
    }
}
