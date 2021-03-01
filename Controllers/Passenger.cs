using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RTS_Term_Project.Models;

namespace RTS_Term_Project.Controllers
{
    public class Passenger : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult afterUserLogin()
        {
            return View();
        }
        public IActionResult Register(string name, string cnic, string contact, string mail, string password, string r_password)
        {
            if(name != null && cnic !=null && contact !=null &&  mail !=null && password !=null && r_password !=null)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Register values(@a, @b, @c)", con);
                SqlCommand cmd2 = new SqlCommand("insert into Log_in(email, login_password, cnic) values(@d, @e, @a)", con);
                SqlCommand cmd3 = new SqlCommand("insert into Passenger(cnic) values(@a)");
                cmd1.Parameters.AddWithValue("@a", cnic);
                cmd1.Parameters.AddWithValue("@b", name);
                cmd1.Parameters.AddWithValue("@c", contact);
                cmd2.Parameters.AddWithValue("@d", mail);
                cmd2.Parameters.AddWithValue("@e", password);
                cmd2.Parameters.AddWithValue("@a", cnic);
                cmd3.Parameters.AddWithValue("@a", cnic);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                con.Close();

            }

            return View();
        }
        //public IActionResult PPayment()
        //{
        //    return View();
        //}
        //public IActionResult PTicketView()
        //{
        //    return View();
        //}
    }
}
