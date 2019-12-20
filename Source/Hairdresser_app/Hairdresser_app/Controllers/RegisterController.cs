using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hairdresser_app.Models;

namespace Hairdresser_app.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidateRegister(Models.Users userModel)
        {
            using (HairdresserEntities db = new HairdresserEntities())
            {
                var userDetails = db.Users.Where(x => x.User_Name == userModel.User_Name).FirstOrDefault();

                if(ModelState.IsValid)
                {
                    if (userDetails == null)
                    {
                        try
                        {
                            db.Users.Add(userModel);
                            db.SaveChanges();

                            return RedirectToAction("Index", "Login");
                        }
                        catch
                        {
                            return View("Index", userModel);
                        }
                    }
                    else
                    {
                        userModel.User_Name_Errormessage = "This username has already been taken!";
                        return View("Index", userModel);
                    }
                }
                else
                { 
                    return View("Index", userModel);
                }
               
            }
        }
    }
}