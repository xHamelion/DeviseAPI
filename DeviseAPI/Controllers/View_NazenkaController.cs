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
    public class View_NazenkaController : ApiController
    {
        private DeviseEntities2 db = new DeviseEntities2();

        // GET: api/View_Nazenka
        //public IQueryable<View_Nazenka> GetView_Nazenka()
        //{
        //    return db.View_Nazenka;
        //}

        [Route("api/Nazenka")]
        public IHttpActionResult GetView_Nazenka()
        {
            var inter = db.View_Nazenka.ToList().Where(p=>p.Nazenka!=0).ToList().Last();
            int i = (int)inter.Nazenka;
             
                return Ok($"{i}");
            
        }
        // GET: api/View_Nazenka/5
        [ResponseType(typeof(View_Nazenka))]
        public IHttpActionResult GetView_Nazenka(int id)
        {
            View_Nazenka view_Nazenka = db.View_Nazenka.Find(id);
            if (view_Nazenka == null)
            {
                return NotFound();
            }

            return Ok(view_Nazenka);
        }

        // PUT: api/View_Nazenka/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutView_Nazenka(int id, View_Nazenka view_Nazenka)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_Nazenka.ID_Sklad)
            {
                return BadRequest();
            }

            db.Entry(view_Nazenka).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_NazenkaExists(id))
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

        // POST: api/View_Nazenka
        [ResponseType(typeof(View_Nazenka))]
        public IHttpActionResult PostView_Nazenka(View_Nazenka view_Nazenka)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_Nazenka.Add(view_Nazenka);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (View_NazenkaExists(view_Nazenka.ID_Sklad))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = view_Nazenka.ID_Sklad }, view_Nazenka);
        }

        // DELETE: api/View_Nazenka/5
        [ResponseType(typeof(View_Nazenka))]
        public IHttpActionResult DeleteView_Nazenka(int id)
        {
            View_Nazenka view_Nazenka = db.View_Nazenka.Find(id);
            if (view_Nazenka == null)
            {
                return NotFound();
            }

            db.View_Nazenka.Remove(view_Nazenka);
            db.SaveChanges();

            return Ok(view_Nazenka);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_NazenkaExists(int id)
        {
            return db.View_Nazenka.Count(e => e.ID_Sklad == id) > 0;
        }
    }
}