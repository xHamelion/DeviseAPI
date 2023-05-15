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
using DeviseAPI.Entity;

namespace DeviseAPI.Controllers
{
    public class SNPControl : ApiController
    {
        private DeviseEntities1 db = new DeviseEntities1();

        // GET: api/SNPControl
        public IQueryable<Sost_Naklad_Prodag> GetSost_Naklad_Prodag()
        {
            return db.Sost_Naklad_Prodag;
        }

        // GET: api/SNPControl/5
        [ResponseType(typeof(Sost_Naklad_Prodag))]
        public IHttpActionResult GetSost_Naklad_Prodag(int id)
        {
            Sost_Naklad_Prodag sost_Naklad_Prodag = db.Sost_Naklad_Prodag.Find(id);
            if (sost_Naklad_Prodag == null)
            {
                return NotFound();
            }

            return Ok(sost_Naklad_Prodag);
        }

        // PUT: api/SNPControl/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSost_Naklad_Prodag(int id, Sost_Naklad_Prodag sost_Naklad_Prodag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sost_Naklad_Prodag.ID_Naklad_Prodag)
            {
                return BadRequest();
            }

            db.Entry(sost_Naklad_Prodag).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Sost_Naklad_ProdagExists(id))
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

        // POST: api/SNPControl
        [ResponseType(typeof(Sost_Naklad_Prodag))]
        public IHttpActionResult PostSost_Naklad_Prodag(Sost_Naklad_Prodag sost_Naklad_Prodag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sost_Naklad_Prodag.Add(sost_Naklad_Prodag);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Sost_Naklad_ProdagExists(sost_Naklad_Prodag.ID_Naklad_Prodag))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sost_Naklad_Prodag.ID_Naklad_Prodag }, sost_Naklad_Prodag);
        }

      

        // DELETE: api/SNPControl/5
        [ResponseType(typeof(Sost_Naklad_Prodag))]
        public IHttpActionResult DeleteSost_Naklad_Prodag(int ID_Nakl,int ID_Tov)
        {
            var sost_Naklad_Prodag = db.Sost_Naklad_Prodag.Where(p=>p.ID_Naklad_Prodag == ID_Nakl
            && p.ID_Tovar == ID_Tov);
            if (sost_Naklad_Prodag == null)
            {
                return NotFound();
            }

            db.Sost_Naklad_Prodag.Remove((Sost_Naklad_Prodag)sost_Naklad_Prodag);
            db.SaveChanges();

            return Ok(sost_Naklad_Prodag);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Sost_Naklad_ProdagExists(int id)
        {
            return db.Sost_Naklad_Prodag.Count(e => e.ID_Naklad_Prodag == id) > 0;
        }
    }
}