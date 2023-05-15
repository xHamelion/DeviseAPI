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
using DeviseAPI.Models;

namespace DeviseAPI.Controllers
{
    public class View_Sost_Naklad_ProdagController : ApiController
    {
        private DeviseEntities1 db = new DeviseEntities1();

        // GET: api/View_Sost_Naklad_Prodag
        public IQueryable<View_Sost_Naklad_Prodag> GetView_Sost_Naklad_Prodag()
        {
            return db.View_Sost_Naklad_Prodag;
        }

        // GET: api/View_Sost_Naklad_Prodag/5
        [ResponseType(typeof(View_Sost_Naklad_Prodag))]
        public IHttpActionResult GetView_Sost_Naklad_Prodag(int id)
        {
            var k = db.View_Sost_Naklad_Prodag.Where(p => p.ID_Naklad_Prodag == id).ToList().ConvertAll(p => new ViewSostavNakladn(p));
            if (k.Count != 0)
                return Ok(k);
            else
                return Ok(0);
        }

        // PUT: api/View_Sost_Naklad_Prodag/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutView_Sost_Naklad_Prodag(int id, View_Sost_Naklad_Prodag view_Sost_Naklad_Prodag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_Sost_Naklad_Prodag.ID_Naklad_Prodag)
            {
                return BadRequest();
            }

            db.Entry(view_Sost_Naklad_Prodag).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_Sost_Naklad_ProdagExists(id))
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

        // POST: api/View_Sost_Naklad_Prodag
        [ResponseType(typeof(View_Sost_Naklad_Prodag))]
        public IHttpActionResult PostView_Sost_Naklad_Prodag(View_Sost_Naklad_Prodag view_Sost_Naklad_Prodag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_Sost_Naklad_Prodag.Add(view_Sost_Naklad_Prodag);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (View_Sost_Naklad_ProdagExists(view_Sost_Naklad_Prodag.ID_Naklad_Prodag))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = view_Sost_Naklad_Prodag.ID_Naklad_Prodag }, view_Sost_Naklad_Prodag);
        }

        // DELETE: api/View_Sost_Naklad_Prodag/5
        [ResponseType(typeof(View_Sost_Naklad_Prodag))]
        public IHttpActionResult DeleteView_Sost_Naklad_Prodag(int id)
        {
            View_Sost_Naklad_Prodag view_Sost_Naklad_Prodag = db.View_Sost_Naklad_Prodag.Find(id);
            if (view_Sost_Naklad_Prodag == null)
            {
                return NotFound();
            }

            db.View_Sost_Naklad_Prodag.Remove(view_Sost_Naklad_Prodag);
            db.SaveChanges();

            return Ok(view_Sost_Naklad_Prodag);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_Sost_Naklad_ProdagExists(int id)
        {
            return db.View_Sost_Naklad_Prodag.Count(e => e.ID_Naklad_Prodag == id) > 0;
        }
    }
}