using Microsoft.AspNetCore.Mvc;
using WebASPApplication1.Models;

namespace WebASPApplication1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult GetGuestMessage(string Email, string Fio, string Phone, string Subject, string Message)
        {
            Console.WriteLine(Email, Fio, Phone, Subject, Message);
            return View("Thanks");
        }*/


        [HttpPost]
        public IActionResult GetGuestMessage(GuestMessage guestMessage)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestMessage);
            }
            else
            {
                return View("Failure", guestMessage);
            }
        }

        /*[HttpPost]
        public IActionResult GetGuestMessage(GuestMessage message)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks",message);
            }
            else
            {
                return View("Failure", message);
            }
        }*/
    }
}
