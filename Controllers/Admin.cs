using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RTS_Term_Project.Models;

namespace RTS_Term_Project.Controllers
{
    public class Admin : Controller
    {
        private readonly StationContext _Db;
        public Admin(StationContext Db) => _Db = Db;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AfterAdminLogin()
        {
            return View();
        }
        public IActionResult ManageAccounts(string name, string cnic, string contact, string mail, string password, string r_password, string selectThis)
        {

            if (name != null && cnic != null && contact != null && mail != null && password != null && r_password != null)
            {
                if (selectThis == "opt1")
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
                        return View();
                    }
                    else
                    {
                        SqlCommand cmd1 = new SqlCommand("insert into Register values(@a, @b, @c)", con);
                        SqlCommand cmd2 = new SqlCommand("insert into Log_in(email, login_password, cnic) values(@d, @e, @a)", con);
                        SqlCommand cmd3 = new SqlCommand("insert into Administrator(cnic) values(@a)", con);
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
                }

                else if (selectThis == "opt2")
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
                        con.Close();
                    }
                }
            }

            return View();
        }
        public IActionResult ManageTrainsSchedule(string avbl, string sc_no, string tr_id, string tr_name, string f_time, string t_time, string dt, string f_st, string t_st, string sc_p, string button1)
        {
            if (button1 == "Save2")
            {
                if (tr_id != null && tr_name != null && f_time !=null && t_time != null && dt !=null && f_st != null && t_st != null && sc_p != null)
                {

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Train_Schedule set from_schedule_time = @time, to_schedule_time= @time1, schedule_date = @sd, from_station_id = (Select station_id from Station where station_name = @fs), to_station_id = (Select station_id from Station where station_name = @ts), price_per_person = @ppp where train_id = @id", con);
                     cmd.Parameters.AddWithValue("@time", f_time);
                    cmd.Parameters.AddWithValue("@time1", t_time);
                    cmd.Parameters.AddWithValue("@sd", dt);
                    cmd.Parameters.AddWithValue("@fs", f_st);
                    cmd.Parameters.AddWithValue("@ts", t_st);
                    cmd.Parameters.AddWithValue("@ppp", sc_p);
                    cmd.Parameters.AddWithValue("@id", tr_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return View("~/Views/Admin/ManageTrainsSchedule.cshtml");
            }

            else if (button1 == "Insert2")
            {
                if (tr_name != null && f_time != null && t_time != null && dt != null && f_st != null && t_st != null && sc_p != null)
                {

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Train_Schedule(train_id, from_schedule_time, to_schedule_time, schedule_date, from_station_id, to_station_id, price_per_person) values((Select train_id from Train where train_name = @name), @ft, @tt, @sd, (Select station_id from Station where station_name =@fs), (Select station_id from Station where station_name =@ts), @pp)", con);
                    cmd.Parameters.AddWithValue("@name", tr_name);
                    cmd.Parameters.AddWithValue("@ft", f_time);
                    cmd.Parameters.AddWithValue("@tt", t_time);
                    cmd.Parameters.AddWithValue("@sd", dt);
                    cmd.Parameters.AddWithValue("@fs", f_st);
                    cmd.Parameters.AddWithValue("@ts", t_st);
                    cmd.Parameters.AddWithValue("@pp", sc_p);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            else if (button1 == "Delete2")
            {
                if (sc_no != null)
                {
                    SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("delete from Train_Schedule where train_id = @id", con1);
                    cmd1.Parameters.AddWithValue("@id", sc_no);
                    cmd1.ExecuteNonQuery();
                    con1.Close();
                    return View("~/Views/Admin/ManageTrainsSchedule.cshtml");
                }
            }
            return View();
        }
        
        public IActionResult ManageStations(string st_name, string st_address, string st_no, string pressButton, string stat_no)
        {
            if(pressButton == "Save")
            {
                if (st_name != null && st_address != null)
                {

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Station set station_name = @name, Station_city= @city where station_id = @id", con);
                    cmd.Parameters.AddWithValue("@name", st_name);
                    cmd.Parameters.AddWithValue("@city", st_address);
                    cmd.Parameters.AddWithValue("@id", stat_no);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return View("~/Views/Admin/ManageStations.cshtml");
            }
            
            else if(pressButton == "Insert")
            {
                if (st_name != null && st_address != null)
                {

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Station(station_name, Station_city) values(@a,@b)", con);
                    cmd.Parameters.AddWithValue("@a", st_name);
                    cmd.Parameters.AddWithValue("@b", st_address);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            else if(pressButton == "Delete")
            {
                if (st_no != null)
                {
                    SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("delete from Station where station_id = @station_id", con1);
                    cmd1.Parameters.AddWithValue("@station_id", st_no);
                    cmd1.ExecuteNonQuery();
                    con1.Close();
                    // return View();
                }
            }
            return View();
        }
        public IActionResult ManageTrains(string t_name, string tot_seats, string avail_seats, string t_no, string thisButton, string tr_id)
        {

            if (thisButton == "Save1")
            {
                if (t_name != null && tot_seats != null && avail_seats != null && tr_id != null)
                {

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Train set train_name = @name, total_seats= @totalSeats, available_seats = @availableSeats where train_id = @id", con);
                    cmd.Parameters.AddWithValue("@name", t_name);
                    cmd.Parameters.AddWithValue("@totalSeats", tot_seats);
                    cmd.Parameters.AddWithValue("@availableSeats", avail_seats);
                    cmd.Parameters.AddWithValue("@id", tr_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return View("~/Views/Admin/ManageTrains.cshtml");
            }

            else if (thisButton == "Insert1")
            {
                if (t_name != null && tot_seats != null && avail_seats != null)
                {

                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Train(train_name, total_seats, available_seats) values(@name, @totalSeats, @availableSeats)", con);
                    cmd.Parameters.AddWithValue("@name", t_name);
                    cmd.Parameters.AddWithValue("@totalSeats", tot_seats);
                    cmd.Parameters.AddWithValue("@availableSeats", avail_seats);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            else if (thisButton == "Delete1")
            {
                if (t_no != null)
                {
                    SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("delete from Train where train_id = @id", con1);
                    cmd1.Parameters.AddWithValue("@id", t_no);
                    cmd1.ExecuteNonQuery();
                    con1.Close();
                    // return View();
                }
            }
            return View();
        }
        

        public IActionResult PassengerRecord()
        {
            if()
            {

            }
            return View();
        }
    }
}
