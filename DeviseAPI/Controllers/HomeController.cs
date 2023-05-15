using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeviseAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ControlsTableStatic();
            return View();
        }
        SqlConnection ms = new SQLconsect().Sql();
        SqlCommand com;
        private void ControlsTableStatic()
        {
            //интернет пользователь - локальный ПК
            ms.Open();
            com = new SqlCommand($"select count(*) from [InternetUser] where(Familia = 'Локальный пользователь' and Imia = 'Локальный пользователь')", ms);
            if (Convert.ToInt32(com.ExecuteScalar()) == 0)
            {
                ms.Close();
                ms.Open();
                //NLdOb2OyN2k#icJFCh$
                com = new SqlCommand($"insert into [InternetUser] values('Локальный пользователь','Локальный пользователь','Локальный пользователь','Локальный пользователь','LocalUserPKDevise','NLdOb2OyN2k#icJFCh$')", ms);
                com.ExecuteNonQuery();
                ms.Close();
            }
            else
                ms.Close();

            //Покупатель - интеренет пользователь
            ms.Open();
            com = new SqlCommand($"select count(*) from [Pokup] where(Familia = 'Интернер' and Imia = 'пользовать')", ms);
            if (Convert.ToInt32(com.ExecuteScalar()) == 0)
            {
                ms.Close();
                ms.Open();
                com = new SqlCommand($"insert into [Pokup] values('Интернер','пользовать','м.п.','+0(000)-000-00-00')", ms);
                com.ExecuteNonQuery();
                ms.Close();
            }
            else
                ms.Close();

            //сотрудник - интеренет пользователь
            ms.Open();
            com = new SqlCommand($"select count(*) from [Sotrudnic] where(Familia = 'онлайн' and Imia = 'заказ' and Otzh = 'м.п.' )", ms);
            if (Convert.ToInt32(com.ExecuteScalar()) == 0)
            {
                ms.Close();
                ms.Open();
                com = new SqlCommand($"insert into [Sotrudnic] values('онлайн','заказ','м.п.','+0(000)-000-00-00')", ms);
                com.ExecuteNonQuery();
                ms.Close();
            }
            else
                ms.Close();
        }
    }
}
