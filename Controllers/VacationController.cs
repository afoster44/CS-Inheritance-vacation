using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using vacation_time.Models;
using vacation_time.Services;

namespace vacation_time.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class VacationController : ControllerBase
    {
        public readonly CruisesService _vService;

        public VacationController(CruisesService vService)
        {
            _vService = vService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cruise>> GetAll()
        {
            try
            {
                return Ok(_vService.GetAllVacations());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}