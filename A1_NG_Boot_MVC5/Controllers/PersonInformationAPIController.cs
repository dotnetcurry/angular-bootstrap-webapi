using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using A1_NG_Boot_MVC5.Models;

namespace A1_NG_Boot_MVC5.Controllers
{
    public class PersonInformationAPIController : ApiController
    {
        private ApplicationEDMXEntities db = new ApplicationEDMXEntities();

        // GET: api/PersonInformationAPI
        public IQueryable<PersonInformation> GetPersonInformations()
        {
            return db.PersonInformations;
        }

        // GET: api/PersonInformationAPI/5
        [ResponseType(typeof(PersonInformation))]
        public IHttpActionResult GetPersonInformation(int id)
        {
            PersonInformation personInformation = db.PersonInformations.Find(id);
            if (personInformation == null)
            {
                return NotFound();
            }

            return Ok(personInformation);
        }

        // PUT: api/PersonInformationAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPersonInformation(int id, PersonInformation personInformation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != personInformation.PersonId)
            {
                return BadRequest();
            }

            db.Entry(personInformation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonInformationExists(id))
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

        // POST: api/PersonInformationAPI
        [ResponseType(typeof(PersonInformation))]
        public IHttpActionResult PostPersonInformation(PersonInformation personInformation)
        {
            //var ReceivedDateYear = personInformation.BirthDate.Year;
          
            //var CurrentDateYear = DateTime.Now.Year;
            

            //var Age = CurrentDateYear - ReceivedDateYear;

            //personInformation.Age = Age;


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PersonInformations.Add(personInformation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = personInformation.PersonId }, personInformation);
        }

        // DELETE: api/PersonInformationAPI/5
        [ResponseType(typeof(PersonInformation))]
        public IHttpActionResult DeletePersonInformation(int id)
        {
            PersonInformation personInformation = db.PersonInformations.Find(id);
            if (personInformation == null)
            {
                return NotFound();
            }

            db.PersonInformations.Remove(personInformation);
            db.SaveChanges();

            return Ok(personInformation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PersonInformationExists(int id)
        {
            return db.PersonInformations.Count(e => e.PersonId == id) > 0;
        }
    }
}