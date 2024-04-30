using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        // HTTP Get method to achive page informations.
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        // HTTP Post method to send informations to server-side.
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {   
            //Checking either if UserInfo properties are filled.
            if(ModelState.IsValid)
            {
            Repository.CreateUser(model);
            ViewBag.NumberOfPeople = Repository.Users.Where(info => info.WillAttend == "true").Count();   
            return View("Thanks", model);
            }
            else
            {
                return View(model);
            }
        }
        // HTTP Get method to achive page informations.
        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Users);
        }

        // HTTP Get method to achive page informations.
        [HttpGet]

        // Get User information with Id, it will be used in "Details" part.
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

    }
}