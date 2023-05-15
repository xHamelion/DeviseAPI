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
    public class InternetUsersController : ApiController
    {
        private DeviseEntities1 db = new DeviseEntities1();

        // GET: api/InternetUsers
        public IQueryable<InternetUser> GetInternetUser()
        {
            return db.InternetUser;
        }


        [Route("api/getLog")]
        public IHttpActionResult GetInternetUser(string Log, string Pass)
        {
            var inter = db.InternetUser.ToList().Where(p => p.Login == Log && p.Pass == Pass).ToList();
            int i = inter.Count;
            if(i==0)
                return Ok($"{i}-");
            else
                return Ok($"{i}-{inter[0].ID_InternetUser}");
        }

        [Route("api/getLog")]
        public IHttpActionResult GetInternetUser(string Log)
        {
            var inter = db.InternetUser.ToList().Where(p => p.Login == Log ).ToList();
            int i = inter.Count;
                return Ok($"{i}-");
            
        }


        // GET: api/InternetUsers/5
        [ResponseType(typeof(InternetUser))]
        public IHttpActionResult GetInternetUser(int id)
        {
            InternetUser internetUser = db.InternetUser.Find(id);
            if (internetUser == null)
            {
                return NotFound();
            }

            return Ok(internetUser);
        }

        // PUT: api/InternetUsers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInternetUser(int id, InternetUser internetUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != internetUser.ID_InternetUser)
            {
                return BadRequest();
            }

            db.Entry(internetUser).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InternetUserExists(id))
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

        // POST: api/InternetUsers
        [ResponseType(typeof(InternetUser))]
        public IHttpActionResult PostInternetUser(InternetUser internetUser)
        {
           

            db.InternetUser.Add(internetUser);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = internetUser.ID_InternetUser }, internetUser);
        }

        // DELETE: api/InternetUsers/5
        [ResponseType(typeof(InternetUser))]
        public IHttpActionResult DeleteInternetUser(int id)
        {
            InternetUser internetUser = db.InternetUser.Find(id);
            if (internetUser == null)
            {
                return NotFound();
            }

            db.InternetUser.Remove(internetUser);
            db.SaveChanges();

            return Ok(internetUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InternetUserExists(int id)
        {
            return db.InternetUser.Count(e => e.ID_InternetUser == id) > 0;
        }
    }
}