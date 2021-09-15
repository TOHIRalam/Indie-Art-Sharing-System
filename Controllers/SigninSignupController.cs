using Indie_Art_Sharing_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace Indie_Art_Sharing_System.Controllers
{
    public class SigninSignupController : Controller
    {
        private readonly ILogger<SigninSignupController> _logger;

        public SigninSignupController(ILogger<SigninSignupController> logger)
        {
            _logger = logger;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Complete(User user)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(user.Email);
            mailMessage.From = new MailAddress("alomhero435@gmail.com");
            mailMessage.Subject = "Verification Code";
            mailMessage.Body = $"Hi {user.Name},\nCongratulations! You are successfully registered on Indie Arts\n\n@Regards from <span style='color: Blue'>Hero Alom</span>";
            mailMessage.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("alomhero435@gmail.com", "Heroalom1122"); ;
            smtp.Send(mailMessage);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
