using Microsoft.AspNetCore.Mvc;
using OverlordAPI.Interfaces;
using OverlordAPI.Models.DTOs;

namespace OverlordAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MinionsController : ControllerBase
    {
        private readonly IMinionService _minionService;

        public MinionsController(IMinionService minionService)
        {
            _minionService = minionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var minions = await _minionService.GetAllMinionsAsync();
            return Ok(minions); 
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var minion = await _minionService.GetMinionByIdAsync(id);
            return Ok(minion);
        } 

        [HttpPost]
        public async Task<IActionResult> Create(MinionCreateDto dto)
        {
            var success = await _minionService.CreateMinionAsync(dto);

            if (!success)
                return BadRequest("Could not create minion");

            return Ok("Minion successfully created!");
        }
    }
}
