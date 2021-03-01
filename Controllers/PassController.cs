using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RTS_Term_Project.Controllers
{
    public class PassController : Controller
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
            if (name != null && cnic != null && contact != null && mail != null && password != null && r_password != null)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                con.Open();
                SqlCommand check_User_Email = new SqlCommand("SELECT * FROM Log_in WHERE ([email] = @d)", con);
                check_User_Email.Parameters.AddWithValue("@d", mail);
                SqlDataAdapter adapter1 = new SqlDataAdapter(check_User_Email);
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1);

                if (ds1.Tables[0].Rows.Count > 0)
                {
                    Response.WriteAsync("alert('This email is already used!')");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("insert into Register values(@a, @b, @c)", con);
                    SqlCommand cmd2 = new SqlCommand("insert into Log_in(email, login_password, cnic) values(@d, @e, @a)", con);
                    SqlCommand cmd3 = new SqlCommand("insert into Passenger(cnic) values(@a)", con);
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
                }
                //SqlDataReader reader = check_User_Email.ExecuteReader();
                //if (reader.HasRows)
                //{
                //    Response.WriteAsync("alert('This email is already used!')");
                //    reader.Close();
                //}

                con.Close();

            }

            return View("~/Views/Home/UserLogin.cshtml");
        }
        public IActionResult PPayment()
        {
            return View();
        }
        public IActionResult PTicketView()
        {
            return View();
        }

    }
}
