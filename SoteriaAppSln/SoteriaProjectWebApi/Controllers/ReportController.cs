using Microsoft.AspNetCore.Mvc;
using SoteriaApp.Shared.enums;
using SoteriaProjectWebApi.Interfaces;
using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ReportController : ControllerBase
    {
        private readonly ISoteriaDbRepository _soteriaDbRepository;
        public ReportController(ISoteriaDbRepository soteriaDbRepository)
        {
            _soteriaDbRepository = soteriaDbRepository;
        }

        [HttpPost]

        public IActionResult CreateReport([FromBody] Report report)
        {
            try
            {
                if (report == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.ReportIncomplete.ToString());
                }
                _soteriaDbRepository.CreateNewReport(report);
            }
            catch (Exception)
            {
                return BadRequest(SystemErrorCodes.LearnerProfileCreationFailed.ToString());
            }
            return Ok(report);
        }

        [HttpGet("bylearnerid")]

        public IList<Report> Get([FromQuery] int learnerid)
        {
            return _soteriaDbRepository.GetReportsByLearnerId(learnerid);
        }
    }
}
