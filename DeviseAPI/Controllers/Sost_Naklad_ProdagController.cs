using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DeviseAPI.Entity;
using DeviseAPI.Models;

namespace DeviseAPI.Controllers
{
    public class Sost_Naklad_ProdagController : ApiController
    {
        private DeviseEntities1 db = new DeviseEntities1();

        // GET: api/Sost_Naklad_Prodag
        public IQueryable<Sost_Naklad_Prodag> GetSost_Naklad_Prodag()
        {
            return db.Sost_Naklad_Prodag;
        }

        // GET: api/Sost_Naklad_Prodag/5
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

        // PUT: api/Sost_Naklad_Prodag/5
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


        [Route("api/post")]
        public IHttpActionResult GetSoStNakl_Prod(int ID_Nakl, int ID_Tov,int Koll,decimal Zena,decimal Summ)
        {

          

            var query = from  ps in db.Sost_Naklad_Prodag
                        where ps.ID_Naklad_Prodag == ID_Nakl && ps.ID_Tovar == ID_Tov
                        select ps;
            int ad = 0;
            if (query.Count() == 0)
            {
                SqlConnection ms = new SqlConnection(@"Data Source=DESKTOP-J96IBMI;Initial Catalog=Devise;Integrated Security=True");
                ms.Open();
                var com = new SqlCommand($"insert into Sost_Naklad_Prodag(ID_Naklad_Prodag, ID_Tovar, Koll, Zena ,Summa)" +
                            $" values('{ID_Nakl}','{ID_Tov}', '{Koll}','{Zena}', '{Summ}'" +
                            $" )", ms);
                try
                {
                    com.ExecuteNonQuery();
                    
                }
                catch 
                {
                ms.Close();
                    return Ok(-1);
                }
                ms.Close();
                return Ok(0);

            }
            else
                return Ok(1);


        }


        // POST: api/Sost_Naklad_Prodag
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


        [Route("api/del")]
        public IHttpActionResult GetSoStNakl_Prod(int ID_Nakl, int ID_Tov)
        {

            SqlConnection ms = new SqlConnection(@"Data Source=DESKTOP-J96IBMI;Initial Catalog=Devise;Integrated Security=True");
            ms.Open();
            var com = new SqlCommand($"delete from [Sost_Naklad_Prodag] " +
                   $"where(ID_Naklad_Prodag = '{ID_Nakl}' and ID_Tovar = '{ID_Tov}')", ms);
            com.ExecuteNonQuery();
            ms.Close();
            return Ok("0");
        }


        // DELETE: api/Sost_Naklad_Prodag/5
        [ResponseType(typeof(Sost_Naklad_Prodag))]
        public IHttpActionResult DeleteSost_Naklad_Prodag(int ID_Nakl,int ID_Tov)
        {

            var sost_Naklad_Prodag = db.Sost_Naklad_Prodag.Where(p=>p.ID_Naklad_Prodag == ID_Nakl
            && p.ID_Tovar == ID_Tov).ToList().ConvertAll(p=> new Sost_Naklad_ProdagDellAdd(p));
            //var sxost_Naklad_Prodag = db.Sost_Naklad_Prodag.Find()
            var query = from com in db.Sost_Naklad_Prodag
                        where com.ID_Naklad_Prodag == ID_Nakl && com.ID_Tovar == ID_Tov
                        select com;
            foreach (Sost_Naklad_Prodag comment in query)
            { // тут будет 1 запрос на выборку из бд
                db.Sost_Naklad_Prodag.Remove(comment);
            }
            if (sost_Naklad_Prodag == null)
            {
                return NotFound();
            }
            Sost_Naklad_Prodag newy = new Sost_Naklad_Prodag();
            newy.ID_Naklad_Prodag = sost_Naklad_Prodag[0].ID_Naklad_Prodag;
            newy.ID_Tovar = sost_Naklad_Prodag[0].ID_Tovar;
            newy.Koll = sost_Naklad_Prodag[0].Koll;
            newy.Summa = sost_Naklad_Prodag[0].Summa;
            newy.Zena = sost_Naklad_Prodag[0].Zena;
            
            //db.Sost_Naklad_Prodag.Remove(query);
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