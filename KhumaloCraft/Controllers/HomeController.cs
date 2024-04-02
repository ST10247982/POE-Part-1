using KhumaloCraft.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using static System.Net.WebRequestMethods;

namespace KhumaloCraft.Controllers
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

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
			//      Socials social = new Socials(
			//"https://www.instagram.com/instagram/",
			//"https://mail.google.com/mail/u/0/#inbox",
			//"068 065 5284",
			//"123 fake street",
			// "https://www.facebook.com/");
			ContactForm contactForm = new ContactForm();
			return View(contactForm);
        }
		[HttpPost]
		public IActionResult Contact(ContactForm form)
		{
            if (ModelState.IsValid)
            {
   
                string name = form.Name;
                string surname = form.Surname;
                string emailAddress = form.EmailAddress;
                string subject = form.Subject;
                string body = form.Body;

                string message = $"Form submitted successfully!\nName: {form.Name}\nSurname: {form.Surname}\nEmail Address: {form.EmailAddress}\nSubject: {form.Subject}\nBody: {form.Body}";
                return Content(message);
            }
            else
            {
                
                return View(form);
            }


        }



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
