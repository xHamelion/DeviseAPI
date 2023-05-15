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
    public class View_SkladController : ApiController
    {
        private DeviseEntities db = new DeviseEntities();

        // GET: api/View_Sklad
        //public IQueryable<View_Sklad> GetView_Sklad()
        //{
        //    return db.View_Sklad;
        //}

        [ResponseType(typeof(List<View_Sklad>))]
        public IHttpActionResult GetView_Sklad()
        {
            return Ok(db.View_Sklad.ToList().ConvertAll(p=>new SkladDate(p)));

        }

        // GET: api/View_Sklad/5
        [ResponseType(typeof(View_Sklad))]
        public IHttpActionResult GetView_Sklad(int id)
        {
            View_Sklad view_Sklad = db.View_Sklad.Find(id);
            if (view_Sklad == null)
            {
                return NotFound();
            }

            return Ok(view_Sklad);
        }

        // PUT: api/View_Sklad/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutView_Sklad(int id, View_Sklad view_Sklad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_Sklad.ID_Sklad)
            {
                return BadRequest();
            }

            db.Entry(view_Sklad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_SkladExists(id))
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

        // POST: api/View_Sklad
        [ResponseType(typeof(View_Sklad))]
        public IHttpActionResult PostView_Sklad(View_Sklad view_Sklad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_Sklad.Add(view_Sklad);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (View_SkladExists(view_Sklad.ID_Sklad))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = view_Sklad.ID_Sklad }, view_Sklad);
        }

        // DELETE: api/View_Sklad/5
        [ResponseType(typeof(View_Sklad))]
        public IHttpActionResult DeleteView_Sklad(int id)
        {
            View_Sklad view_Sklad = db.View_Sklad.Find(id);
            if (view_Sklad == null)
            {
                return NotFound();
            }

            db.View_Sklad.Remove(view_Sklad);
            db.SaveChanges();

            return Ok(view_Sklad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_SkladExists(int id)
        {
            return db.View_Sklad.Count(e => e.ID_Sklad == id) > 0;
        }
    }
}