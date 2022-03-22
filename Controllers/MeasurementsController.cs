using System.Collections.Generic;
using System.Threading.Tasks;
using MentalShower.Data;
using MentalShower.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentalShower.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MeasurementsController : ControllerBase
    {
        private readonly ApiContext _context;
        public MeasurementsController(ApiContext ctx)
        {
            _context = ctx;
        }
        // GET: /measurements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Measurement>>> Get()
        {
            var data = await _context.Measurements.ToListAsync();
            return Ok(data);
        }


        // POST: /measurements
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MeasurementDto dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            Measurement mm = new Measurement(dto);
            _context.Measurements.Add(mm);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
