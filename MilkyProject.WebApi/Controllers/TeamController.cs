using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinesLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {

        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public IActionResult   TeamList()
        {
            var values = _teamService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateTeam(Team  team)
        {
            _teamService.TInsert(team);
            return Ok("Başarıyla eklendi.");
        }
        [HttpDelete]

        public IActionResult DeleteTeam(int id)
        {
            _teamService.TDelete(id);
            return Ok("başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdateTeam(Team team)
        {
            _teamService.TUpdate(team);
            return Ok("başarıyla güncellendi");
        }
   
        [HttpGet("GetETeamCount")]

        public IActionResult GetETeamCount()
        {
            return Ok(_teamService.TGetETeamCount());
        }
    }
}
