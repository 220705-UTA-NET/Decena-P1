using MedicationsAPI.Data;
using MedicationsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        
        private readonly MedicinesDbContext _context;

        public MedicinesController(MedicinesDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Medicines>> Get()
            => await _context.Medicines.ToListAsync();

        [HttpGet("id")]
        [ProducesResponseType(typeof(Medicines), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async  Task<IActionResult> GetById(int id)
        {
            var Medicines = await _context.Medicines.FindAsync(id);
            return Medicines == null ? NotFound() : Ok(Medicines);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Medicines Medicines)
        {
            await _context.Medicines.AddAsync(Medicines);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new {id = Medicines.Id}, Medicines);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, Medicines Medicines)
        {
            if (id != Medicines.Id) return BadRequest();

            _context.Entry(Medicines).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();


        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var MedicinesToDelete = await _context.Medicines.FindAsync(id);
            if (MedicinesToDelete == null) return NotFound();

            _context.Medicines.Remove(MedicinesToDelete);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
