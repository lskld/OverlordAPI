using Microsoft.AspNetCore.Mvc;
using OverlordAPI.Interfaces;
using OverlordAPI.Models.DTOs;

namespace OverlordAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MissionsController : ControllerBase
    {
        private readonly IMissionService _missionService;

        public MissionsController(IMissionService missionService)
        {
            _missionService = missionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var missions = await _missionService.GetAllMissionsAsync();
            return Ok(missions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var mission = await _missionService.GetMissionByIdAsync(id);
            return Ok(mission);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MissionCreateDto dto)
        {
            var success = await _missionService.CreateMissionAsync(dto);

            if (!success)
                return BadRequest("Mission could not be created.");

            return Ok("Mission successfully created!");
        }

        [HttpGet("{id}/minions/")]
        public async Task<IActionResult> GetAssignedMinions(int id)
        {
            var minions = await _missionService.GetMinionsInMissionAsync(id);

            return Ok(minions);
        }

        [HttpPost("/assign/minion/{minionId}/mission/{missionId}")]
        public async Task<IActionResult> AssignMinionToMission(int minionId,  int missionId)
        {
            var success = await _missionService.AssignMinionToMissionAsync(minionId, missionId);

            if (!success)
                return BadRequest("The entered minion or mission doesn't exist");

            return Ok("The minion has been connected to the mission");
        }
    }
}
