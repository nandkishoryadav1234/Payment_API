using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContosoEventApp.Data;
using ContosoEventApp.Models;

namespace ContosoEventApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class theatresController : ControllerBase
    {
        private readonly ContosoEventAppContext _context;

        public theatresController(ContosoEventAppContext context)
        {
            _context = context;
        }

        // GET: api/theatres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<theatre>>> Gettheatre()
        {
            return await _context.theatre.ToListAsync();
        }

        // GET: api/theatres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<theatre>> Gettheatre(int id)
        {
            var theatre = await _context.theatre.FindAsync(id);

            if (theatre == null)
            {
                return NotFound();
            }

            return theatre;
        }

        // PUT: api/theatres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Puttheatre(int id, theatre theatre)
        {
            if (id != theatre.TheatreId)
            {
                return BadRequest();
            }

            _context.Entry(theatre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!theatreExists(id))
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

        // POST: api/theatres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<theatre>> Posttheatre(theatre theatre)
        {
            _context.theatre.Add(theatre);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Gettheatre", new { id = theatre.TheatreId }, theatre);
        }

        // DELETE: api/theatres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletetheatre(int id)
        {
            var theatre = await _context.theatre.FindAsync(id);
            if (theatre == null)
            {
                return NotFound();
            }

            _context.theatre.Remove(theatre);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool theatreExists(int id)
        {
            return _context.theatre.Any(e => e.TheatreId == id);
        }

        // GET: api/theatres/5
       /* [HttpGet]
        [Route("{idMov}/SearchByMovieId")]
       
        public async Task<ActionResult<IEnumerable<theatre>>> GettheatrebyMovie(int idMov)
        {
            
            var theatres = from d in _context.theatre select d;

            if (theatres != null)
            {
                theatres = theatres.Where(d => d.MovieId == idMov);
            }

            return  await theatres.ToListAsync();*/
        }
    }

