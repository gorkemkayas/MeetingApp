using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    // {controller}/{action}/{id?}
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Adjust login message according to time.
        
            int clock = DateTime.Now.Hour;

            ViewBag.Greeting = clock > 12 ? "Have a nice day":"Good Morning";
            ViewBag.userCount = Repository.Users.Where(info => info.WillAttend == "true").Count();

            // Create a meeting and forward it Views/Home/Index.cshtml
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul, Harbiye Oditoryumu",
                Date = new DateTime(2024,05,08,13,0,0),
                NumberOfPeople = ViewBag.userCount
            };
            return View(meetingInfo);
        }
    }
}