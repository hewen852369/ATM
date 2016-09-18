using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        // get dbcontext object to work with database
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Transcation/Deposit
        // passing checking Account id
        public ActionResult Deposit(int checkingAccountId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Deposit(Transaction transaction)
        {
            // chekcing if input is vaild (input validation should be checked at view model)
            if (ModelState.IsValid)
            {
                db.Transcations.Add(transaction);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}