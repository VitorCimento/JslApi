#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JslApi.Models;

namespace JslApi.Controllers
{
    [Route("api/Viagens")]
    [ApiController]
    public class ViagensController : ControllerBase
    {
        private readonly Contexto _context;

        public ViagensController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Viagens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Viagem>>> GetViagem()
        {
            return await _context.Viagem.OrderBy(v => v.Id).Include(m => m.Motorista).ToListAsync();
        }

        // GET: api/Viagens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Viagem>> GetViagem(int id)
        {
            var viagem = await _context.Viagem.FindAsync(id);

            if (viagem == null)
            {
                return NotFound();
            }

            return viagem;
        }

        // PUT: api/Viagens/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViagem(int id, Viagem viagem)
        {
            if (id != viagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(viagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViagemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Viagens
        [HttpPost]
        public async Task<ActionResult<Viagem>> PostViagem(Viagem viagem)
        {
            _context.Viagem.Add(viagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetViagem", new { id = viagem.Id }, viagem);
        }

        // DELETE: api/Viagens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteViagem(int id)
        {
            var viagem = await _context.Viagem.FindAsync(id);
            if (viagem == null)
            {
                return NotFound();
            }

            _context.Viagem.Remove(viagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ViagemExists(int id)
        {
            return _context.Viagem.Any(e => e.Id == id);
        }
    }
}
