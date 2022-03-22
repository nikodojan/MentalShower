using System.Collections.Generic;
using System.Threading.Tasks;
using MentalShower.Models;
using MentalShower.MongoDb;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MentalShower.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MongoMeasurementsController : ControllerBase
    {
        private readonly MeasurementsService _service;
        public MongoMeasurementsController(MeasurementsService svc)
        {
            _service = svc;
        }

        // GET: api/<MongoMeasurementsController>
        [HttpGet]
        public async Task<ActionResult<List<Measurement>>> Get()
        {
            return Ok(await _service.GetAsync());
        }
        

        // POST api/<MongoMeasurementsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MeasurementDto dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            Measurement mm = new Measurement(dto);
            mm.Id = null;
            await _service.CreateAsync(mm);
            return NoContent();
        }
        
    }
}
