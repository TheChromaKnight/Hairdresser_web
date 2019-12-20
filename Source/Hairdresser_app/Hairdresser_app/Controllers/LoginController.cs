using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hairdresser_app.Models;

namespace Hairdresser_app.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidateLogin(Models.Users userModel)
        {
            using (HairdresserEntities db = new HairdresserEntities())
            {
                var userDetails = db.Users.Where(x => x.User_Name == userModel.User_Name).FirstOrDefault();
                
                if(userDetails == null)
                {
                    userModel.User_Name_Errormessage = "Wrong username or password!";
                    return View("Index", userModel);
                }
                else if(userDetails.User_Rank_Id == 1)
                {
                    Session["userId"] = userDetails.User_id;
                    Session["userRank"] = userDetails.User_Rank_Id;
                    return RedirectToAction("Index", "AdminHome");
                }
                else
                {
                    Session["userId"] = userDetails.User_id;
                    Session["userRank"] = userDetails.User_Rank_Id;

                    return RedirectToAction("Index", "Home");
                }
            }
        }
    }
}