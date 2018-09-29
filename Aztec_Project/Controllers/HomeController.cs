using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Aztec_Project.Models;
//using Aztec_Project.ViewModel;
namespace Aztec_Project.Controllers
{
    public class HomeController : Controller
    {
        private AztecDatabaseEntities mdb = new AztecDatabaseEntities();

        public ActionResult Index()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult Start()
        {
            return View();
        }


        //Content
        public ActionResult More()
        {
            //AztecDatabaseEntities adb = new AztecDatabaseEntities();
            //var mymodel = new Multipledata();
            //mymodel.cinemaaa = adb.Cinemas.ToList();
            //mymodel.showingmovieee = adb.ShowingMovies.ToList();
            //mymodel.comingsoonmovieee = adb.ComingSoonMovies.ToList();
            //return View(mymodel);
            return View(mdb.Cinemas.ToList());
        }

        public ActionResult CinemaDetail(int CID, string CN, string CNum, string Add, float Lat, float Lon)
        {
            Cinema c = new Cinema();
            c.CinemaID = CID;
            c.CinemaName = CN;
            c.ContactNumber = CNum;
            c.Address = Add;
            c.Latitude = Lat;
            c.Longitude = Lon;

            return View(c);
        }

        public ActionResult MoreSMovies()
        {
            return View(mdb.ShowingMovies.ToList());
        }

        public ActionResult ShowingMovies(int SMID, string SMN, TimeSpan SMT, string SC)
        {
            ShowingMovie sm = new ShowingMovie();
            sm.ShowingMovieID = SMID;
            sm.MovieName = SMN;
            sm.ShowTime = SMT;
            sm.Cinemas = SC;

            return View(sm);
        }

        public ActionResult ComingSoonMovies()
        {
            return View(mdb.ComingSoonMovies.ToList());
        }

        public ActionResult ComingSoonDetail(int CMID, string CM, DateTime CD, string CMR)
        {
            ComingSoonMovie cm = new ComingSoonMovie();
            cm.ComingMovieID = CMID;
            cm.ComingSoonMovies = CM;
            cm.Date = CD;
            cm.MovieReview = CMR;

            return View(cm);
        }

        

        //[HttpPost]
        //public ActionResult TicketBooking()
        //{
        //    //TicketBooking tb = new TicketBooking();

        //    //tb.ID = int.Parse(User.Identity.Name);
        //    //tb.MovieName = Request.Form["mname"].ToString();
        //    //tb.Date = Request.Form["date"].ToString();
        //    //tb.SeatNo = Request.Form["seatnumber"].ToString();
        //    //tb.SeatStatus = Request.Form["seatstatus"].ToString();
        //    //tb.CustomerName = Request["customername"].ToString();
        //    //tb.PhoneNumber = Request["phonenumber"].ToString();

        //    //mdb.TicketBookings.Add(tb);
        //    //mdb.SaveChanges();
        //    return View();
        //}


        //Booking
        public ActionResult Detail()
        {

            var mo = new SelectList(mdb.TicketBookings.ToList().Where(g => g.SeatStatus == "Available"), "MovieName", "MovieName");
            ViewData["aa"] = mo;

            var da = new SelectList(mdb.TicketBookings.ToList().Where(g => g.SeatStatus == "Available"), "Date", "Date");
            ViewData["d"] = da;
            //var data = mdb.Seats.Where(g => g.SeatStatus == "Available");
            var d = new SelectList(mdb.TicketBookings.ToList().Where(g => g.SeatStatus == "Available"), "SeatNo", "SeatNo");
            ViewData["a"] = d;

            return View();
            
        }

        //public ActionResult BookNow()
        //{
        //    TicketBooking tb = new TicketBooking();

        //    tb.MovieName = Request.Form["moviename"].ToString();
        //    tb.Date = Request.Form["date"].ToString();
        //    tb.SeatNo = Request.Form["seatno"].ToString();

        //    mdb.TicketBookings.Add(tb);
        //    mdb.SaveChanges();

        //    //AztecDatabaseEntities addb = new AztecDatabaseEntities();
        //    //var v = addb.TicketBookings.Add(tb);
        //    //addb.SaveChanges();
        //    return View();
        //}

        //public ActionResult Booking()
        //{
        //    return View();
        //}

        //Register,Login,Logout

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User_Profile UP)
        {
            if (ModelState.IsValid)
            {
                using (AztecDatabaseEntities ad = new AztecDatabaseEntities())
                {
                    ad.User_Profile.Add(UP);
                    ad.SaveChanges();
                    ModelState.Clear();
                    UP = null;
                    ViewBag.Message = "Successfully Register !";
                }
            }
            return View(UP);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User_Profile log)
        {
            if (ModelState.IsValid)
            {
                using (AztecDatabaseEntities adb = new AztecDatabaseEntities())
                {
                    var obj = adb.User_Profile.Where(a => a.UserName.Equals(log.UserName) && a.Password.Equals(log.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserName"] = obj.UserName.ToString();
                        Session["Password"] = obj.Password.ToString();

                        return RedirectToAction("Index");
                    }
                    
                }
            }
            return View(log);    
        }

        //public ActionResult Continue()
        //{
        //    if (Session["UserName"] != null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index");
        //    }
               
        //}

        public ActionResult Logout()
        {
            Session.Remove("UserName");
            return RedirectToAction("Login");
        }

    }
}
