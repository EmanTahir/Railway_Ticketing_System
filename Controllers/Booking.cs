using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RTS_Term_Project.Controllers
{
    public class Booking : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookTicket(string search, string From, string To, string Date, string email, string bookbutton, string r, string nfp)
        {
            ViewData["emaill"] = email;
            ViewData["Pasengers"] = nfp;
            ViewData["BDate"] = Date;
            if(bookbutton == "Nextt")
            {
               // string d = "1-30-2021";
                string a = "0";
                string ac = "NULL";
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Booking(cnic,amount, booking_date, no_of_passenger, booking_type, account)values((select cnic from Log_in where email = @e),@am,@date , @n, @t, @accoun)", con);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@n", nfp);
                cmd.Parameters.AddWithValue("@t", r);
                cmd.Parameters.AddWithValue("@date", Date);
                cmd.Parameters.AddWithValue("@am", a);
                cmd.Parameters.AddWithValue("@accoun", ac);
                cmd.ExecuteNonQuery();
                con.Close();
                return View("~/Views/Booking/SelectTrain.cshtml");
            }
            

            return View();
        }
        public IActionResult SelectTrain(string checklist, string email, string price,string sbutton, string nfp)
        {
            ViewData["emaill"] = email;
            ViewData["Pasengers"] = nfp;
            SqlConnection newCon = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
            newCon.Open();
            SqlCommand newCmd = new SqlCommand("select price_per_person from Train_Schedule where schedule_id = @id", newCon);
            newCmd.Parameters.AddWithValue("@id", checklist);
            SqlDataAdapter adapter1 = new SqlDataAdapter(newCmd);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    price = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                }
                int pay = Int16.Parse(price) * Int16.Parse(nfp);
                ViewData["pricePerPerson"] = pay;
                newCon.Close();
            }
            //ViewData["pricePerPerson"] = price;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Booking set schedule_id = @scid where booking_id = (Select Max(Booking_id) from Booking)", con);
            cmd.Parameters.AddWithValue("@scid", checklist);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.ExecuteNonQuery();
            SqlCommand cmd4 = new SqlCommand("insert into Ticket(station_id, schedule_id, booking_id)values((select from_station_id from Train_Schedule where schedule_id = @check), @check, (Select Max(Booking_id) from Booking ))", con);
            cmd4.Parameters.AddWithValue("@check", checklist);
            cmd4.Parameters.AddWithValue("@e", email);
            cmd4.ExecuteNonQuery();
            con.Close();
            if (sbutton == "yes")
            {
                return View("~/Views/Booking/Payment.cshtml");
            }
            else if(sbutton == "no")
            {
                string ans = "No";
                SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("Update Booking set online_booking = @n where booking_id =(Select Max(Booking_id) from Booking)", con1);
                cmd1.Parameters.AddWithValue("@n", ans);
                cmd1.Parameters.AddWithValue("@e", email);
                cmd1.ExecuteNonQuery();
                con1.Close();
                return View("~/Views/Home/UserLogin.cshtml");
            }
            return View();
        }
        public IActionResult Payment(string nfp, string price, string email, string number, string pmail, string pAccount, string pCNIC)
        {
            if (pCNIC != null)
            {
                int pay = 0;
                ViewData["emaill"] = email;
                ViewData["pricePerPerson"] = price;
                ViewData["Pasengers"] = nfp;
                pay = Int16.Parse(price) * Int16.Parse(nfp);
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFAV4Q6\\SQLEXPRESS;Initial Catalog=RTS;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Payment(pay_cnic, pay_contact, pay_email)values(@c, @cont, @m)", con);
                cmd.Parameters.AddWithValue("@c", pCNIC);
                cmd.Parameters.AddWithValue("@cont", number);
                cmd.Parameters.AddWithValue("@m", pmail);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("update Booking set payment_id = (select payment_id from Payment where pay_cnic = @c), account = @ac where booking_id = (Select Max(Booking_id) from Booking)", con);
                cmd2.Parameters.AddWithValue("@mount", pay);
                cmd2.Parameters.AddWithValue("@e", email);
                cmd2.Parameters.AddWithValue("@ac", pAccount);
                cmd2.Parameters.AddWithValue("@c", pCNIC);
                cmd2.ExecuteNonQuery();
                con.Close();
                return View("~/Views/Booking/TicketView.cshtml");
            }
            else
                return View();    
        }
        public IActionResult TicketView()
        {
            return View();
        }
    }
}
