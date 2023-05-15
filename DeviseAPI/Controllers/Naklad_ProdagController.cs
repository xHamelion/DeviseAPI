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
    public class Naklad_ProdagController : ApiController
    {
        private DeviseEntities1 db = new DeviseEntities1();

        // GET: api/Naklad_Prodag
        public IQueryable<Naklad_Prodag> GetNaklad_Prodag()
        {
            return db.Naklad_Prodag;
        }

        // GET: api/Naklad_Prodag/5


     

        [ResponseType(typeof(List<Naklad_Prodag>))]
        public IHttpActionResult GetNaklad_Prodag(int id)
        {
            var k = db.Naklad_Prodag.Where(p => p.ID_InternetUser == id).ToList().ConvertAll(p => new NakladProd(p));
            if (k.Count != 0)
                return Ok(k[0].ID_Zakaz +"*" + k[0].Nomer);
            else
                return Ok(-1);
        }

        // PUT: api/Naklad_Prodag/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNaklad_Prodag(int id, Naklad_Prodag naklad_Prodag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != naklad_Prodag.ID_Naklad_Prodag)
            {
                return BadRequest();
            }

            db.Entry(naklad_Prodag).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Naklad_ProdagExists(id))
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



        // POST: api/Naklad_Prodag
        [ResponseType(typeof(Naklad_Prodag))]
        public IHttpActionResult PostNaklad_Prodag(Naklad_Prodag naklad_Prodag)
        {
            int id_P = 0, id_S = 0;
            SqlConnection ms = new SQLconsect().Sql();
            SqlCommand com;
            ms.Open();
            com = new SqlCommand($"select ID_Pokup from [Pokup] where(Familia = 'Интернер' and Imia = 'пользовать')", ms);
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                id_P = Convert.ToInt32(rd[0].ToString());

            }
            ms.Close();

            ms.Open();
            com = new SqlCommand($"select ID_Sotrudnic from [Sotrudnic] where(Familia = 'онлайн' and Imia = 'заказ' and Otzh = 'м.п.')", ms);
             rd = com.ExecuteReader();
            while (rd.Read())
            {
                id_S = Convert.ToInt32(rd[0].ToString());

            }
            ms.Close();


            naklad_Prodag.Data_Pokup = DateTime.Now;
            naklad_Prodag.Summa = 0;
            naklad_Prodag.Summa_Obh = 0;
            naklad_Prodag.ID_Pokup = id_P;
            naklad_Prodag.ID_Sotrudnic = id_S;
            naklad_Prodag.Dostavka = 0;
            db.Naklad_Prodag.Add(naklad_Prodag);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = naklad_Prodag.ID_Naklad_Prodag }, naklad_Prodag);
        }

        // DELETE: api/Naklad_Prodag/5
        [ResponseType(typeof(Naklad_Prodag))]
        public IHttpActionResult DeleteNaklad_Prodag(int id)
        {
            Naklad_Prodag naklad_Prodag = db.Naklad_Prodag.Find(id);
            if (naklad_Prodag == null)
            {
                return NotFound();
            }

            db.Naklad_Prodag.Remove(naklad_Prodag);
            db.SaveChanges();

            return Ok(naklad_Prodag);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Naklad_ProdagExists(int id)
        {
            return db.Naklad_Prodag.Count(e => e.ID_Naklad_Prodag == id) > 0;
        }
    }
}