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
    public class View_PodTipController : ApiController
    {
        private DeviseEntities db = new DeviseEntities();

        // GET: api/View_PodTip
        [ResponseType(typeof(List<View_PodTip>))]
        public IHttpActionResult GetView_PodTip()
        {
            return Ok(db.View_PodTip.ToList().ConvertAll(p => new TipDate(p)));
        }

        // GET: api/View_PodTip/5
        [ResponseType(typeof(View_PodTip))]
        public IHttpActionResult GetView_PodTip(int id)
        {
            View_PodTip view_PodTip = db.View_PodTip.Find(id);
            if (view_PodTip == null)
            {
                return NotFound();
            }

            return Ok(view_PodTip);
        }

        // PUT: api/View_PodTip/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutView_PodTip(int id, View_PodTip view_PodTip)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_PodTip.ID_PodTip)
            {
                return BadRequest();
            }

            db.Entry(view_PodTip).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_PodTipExists(id))
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

        // POST: api/View_PodTip
        [ResponseType(typeof(View_PodTip))]
        public IHttpActionResult PostView_PodTip(View_PodTip view_PodTip)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_PodTip.Add(view_PodTip);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (View_PodTipExists(view_PodTip.ID_PodTip))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = view_PodTip.ID_PodTip }, view_PodTip);
        }

        // DELETE: api/View_PodTip/5
        [ResponseType(typeof(View_PodTip))]
        public IHttpActionResult DeleteView_PodTip(int id)
        {
            View_PodTip view_PodTip = db.View_PodTip.Find(id);
            if (view_PodTip == null)
            {
                return NotFound();
            }

            db.View_PodTip.Remove(view_PodTip);
            db.SaveChanges();

            return Ok(view_PodTip);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_PodTipExists(int id)
        {
            return db.View_PodTip.Count(e => e.ID_PodTip == id) > 0;
        }
    }
}