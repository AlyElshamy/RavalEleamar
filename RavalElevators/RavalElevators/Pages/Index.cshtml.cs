using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using SmtpClient = System.Net.Mail.SmtpClient;

namespace RavalElevators.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
       
        public void OnGet()


        
            {
            

//var from = "alielshamy900@gmail.com";
//        var to = "M.Elshamy@ravalelevators.com";
//        var subject = "Test mail";
//        var body = "Test body";

//        var username = "M.Elshamy@ravalelevators.com"; // get from Mailtrap
//        var password = "RrMf86931618"; // get from Mailtrap

//        var host = "smtp.mailtrap.io";
//        var port = 2525;

//        var client = new SmtpClient(host, port)
//        {
//            Credentials = new NetworkCredential(username, password),
//            EnableSsl = true
//        };
//            client.UseDefaultCredentials = true;
//            client.Send(from, to, subject, body);

            //var mailMessage = new MailMessage
            //{
            //    From = new MailAddress("email"),
            //    Subject = "subject",
            //    Body = "<h1>Hello</h1>",
            //    IsBodyHtml = true,
            //};
            //mailMessage.To.Add("recipient");

            //smtpClient.Send(mailMessage);

            //SmtpClient smtp = new SmtpClient("smtp.mailtrap.io", 2525);
            //smtp.EnableSsl = true;
            //smtp.Credentials = new NetworkCredential("M.Elshamy@ravalelevators.com", "RrMf86931618");
            //String from = "alielshamy900@gmail.email";
            //String to = "M.Elshamy@ravalelevators.com";
            //String subject = "Pics from the royal wedding";
            //String messageBody = "Charles, sending you a quick sneak peek of the pictures" +
            //"we took at the last royal wedding. ";
            //MailMessage message = new MailMessage(from, to, subject, messageBody);

            //AlternateView htmlView = AlternateView.CreateAlternateViewFromString(
            //  $"{messageBody} <br> <img src=\"cid:Wedding\">",
            //  null,
            //  "text/html"
            //);

            //LinkedResource LinkedImage = new LinkedResource("wwwroot/Images/18990a6c-28cb-4fb9-b7ce-93ef6cba8890.jfif");
            //LinkedImage.ContentId = "Wedding";

            //htmlView.LinkedResources.Add(LinkedImage);
            //message.AlternateViews.Add(htmlView);

            //try
            //{
            //    smtp.Send(message);
            //}
            //catch (SmtpException ex)
            //{
            //    //return ex.ToString();
            //}
        }
    }
}