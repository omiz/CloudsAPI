using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Clouds.Models;

namespace Clouds.API
{
    public class AirportsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Airports
        public IQueryable<Airport> GetAirports()
        {
            return db.Airports;
        }

        // GET: api/Airports/5
        [ResponseType(typeof(Airport))]
        public async Task<IHttpActionResult> GetAirport(int id)
        {
            Airport airport = await db.Airports.FindAsync(id);
            if (airport == null)
            {
                return NotFound();
            }

            return Ok(airport);
        }

        // PUT: api/Airports/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAirport(int id, Airport airport)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != airport.Id)
            {
                return BadRequest();
            }

            db.Entry(airport).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AirportExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Airports
        [ResponseType(typeof(Airport))]
        public async Task<IHttpActionResult> PostAirport(Airport airport)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Airports.Add(airport);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = airport.Id }, airport);
        }

        // DELETE: api/Airports/5
        [ResponseType(typeof(Airport))]
        public async Task<IHttpActionResult> DeleteAirport(int id)
        {
            Airport airport = await db.Airports.FindAsync(id);
            if (airport == null)
            {
                return NotFound();
            }

            db.Airports.Remove(airport);
            await db.SaveChangesAsync();

            return Ok(airport);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AirportExists(int id)
        {
            return db.Airports.Count(e => e.Id == id) > 0;
        }
    }
}