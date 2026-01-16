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
    }
}
