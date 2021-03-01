using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RTS_Term_Project.Models;

namespace RTS_Term_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs(string search, string From, string To, string Date)
        {
            ViewData["Query"] = "None";
            if (search == "Submit" || From != null || To != null || Date != null)
            {
                string query = "select Train.train_id, train_name, available_seats, from_schedule_time, to_schedule_time, schedule_date, (Select station_name from Station where station_id = Train_Schedule.from_station_id) as from_station, (Select station_name from Station where station_id = Train_Schedule.to_station_id) as to_station, Train_Schedule.price_per_person from Train inner join Train_Schedule ON(Train.train_id = Train_Schedule.train_id) where Train_Schedule.from_station_id = (Select TOP 1 station_id from Station where Station_city = \'" + From + "\') and Train_Schedule.to_station_id = (Select Top 1 station_id from Station where Station_city = \'" + To + "\') and Train_Schedule.schedule_date = \'" + Date + "\'";
                //Console.WriteLine(query);
                ViewData["Query"] = query;
                return View("~/Views/Home/viewTrains.cshtml");
                //return RedirectToAction("viewTrains", "HomeController");
            }

            return View();

        }
        public IActionResult viewStations(string City, string search)
        {

            ViewData["Query"] = "None";
            if (search == "Submit" || City != null)
            {
                string query = "Select * from Station where Station_city= \'" + City + "\'";
                Console.WriteLine(query);
                ViewData["Query"] = query;

            }

            return View();
        }
        public IActionResult viewTrains(string search, string From, string To, string Date)
        {
            ViewData["Query"] = "None";
            if (search == "Submit" || From != null || To != null || Date != null)
            {
                string query = "select Train.train_id, train_name, available_seats, from_schedule_time, to_schedule_time, schedule_date, (Select station_name from Station where station_id = Train_Schedule.from_station_id) as from_station, (Select station_name from Station where station_id = Train_Schedule.to_station_id) as to_station, Train_Schedule.price_per_person from Train inner join Train_Schedule ON(Train.train_id = Train_Schedule.train_id) where Train_Schedule.from_station_id = (Select TOP 1 station_id from Station where Station_city = \'" + From + "\') and Train_Schedule.to_station_id = (Select Top 1 station_id from Station where Station_city = \'" + To + "\')";
                //Console.WriteLine(query);
                ViewData["Query"] = query;

            }

            return View();
        }
            public IActionResult UserLogin(string email, string password)
        {
         
            if (email != null && password != null)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select email, login_password from Log_in where email = @emailCheck and login_password = @passwordCheck", con);

                cmd.Parameters.AddWithValue("@emailCheck", email);
                cmd.Parameters.AddWithValue("@passwordCheck", password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ViewData["emaill"] = email;
                adapter.Fill(ds);
                //con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string u_name = "", u_pass = "";
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        u_name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        u_pass = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    }
                    if (u_name == email && u_pass == password)
                    {
                        SqlCommand cmd1 = new SqlCommand("select Passenger.pass_id from Log_in inner join Passenger on Passenger.cnic = (select cnic from log_in where email = @emailCheck)", con);
                        cmd1.Parameters.AddWithValue("@emailCheck", email);
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                        DataSet ds1 = new DataSet();
                        adapter1.Fill(ds1);
                        
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            con.Close();
                            return View("~/Views/Passenger/afterUserLogin.cshtml");
                        }
                        else
                        {
                            SqlCommand cmd2 = new SqlCommand("select Administrator.admin_id from Log_in inner join Administrator on Administrator.cnic = (select cnic from log_in where email = @emailCheck)", con);
                            cmd2.Parameters.AddWithValue("@emailCheck", email);
                            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd2);
                            DataSet ds3 = new DataSet();
                            adapter3.Fill(ds3);
                            if (ds3.Tables[0].Rows.Count > 0)
                            {
                                con.Close();
                                return View("~/Views/Admin/AfterAdminLogin.cshtml");
                            }
                        }
                        
                    }
                }

            }
            return View();
        }
        public IActionResult ResetPassword(string password, string confrimPassword, string options, string mail, string pressButton, string option, string emailchk)
        {
            if (pressButton == "Done")
            {
                if (password != null && confrimPassword != null)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("Select * from Log_in where email = @a",con);
                    cmd2.Parameters.AddWithValue("@a", mail);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd2);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    if(ds.Tables[0].Rows.Count > 0)
                    {
                        SqlCommand cmd = new SqlCommand("Update Log_in set login_password = @pass where email = @a", con);
                        cmd.Parameters.AddWithValue("@pass", password);
                        cmd.Parameters.AddWithValue("@a", mail);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        return View("~/Views/Home/UserLogin.cshtml");
                    }
                    
                }
            }
            else if(pressButton == "Next")
            {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                con.Open();
                SqlCommand cmd3 = new SqlCommand("Select * from Log_in where email = @a", con);
                cmd3.Parameters.AddWithValue("@a", emailchk);
                SqlDataAdapter adpt3 = new SqlDataAdapter(cmd3);
                DataSet ds3 = new DataSet();
                adpt3.Fill(ds3);
                if (ds3.Tables[0].Rows.Count > 0)
                {
                    con.Close();
                    return View();
                }
                else if(ds3.Tables[0].Rows.Count == 0)
                {
                    return View("~/Views/Home/UserLogin.cshtml");
                }
            }
            //return View("~/Views/HomeController/UserLogin.cshtml");
            return View();		

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
