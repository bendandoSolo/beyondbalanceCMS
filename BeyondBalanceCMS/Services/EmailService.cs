using MalcolmWall.Models;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BeyondBalance.Services
{
    public class EmailService
    {
        //Asynchronous method to send emaill based on ContactForm object
        public async static Task SendContactForm(Email email){
            //Constructing the email

            MailMessage message = new MailMessage("no_replay@bendandotest.com", "info@beyondbalance.co.uk");
            message.Subject = "Message From Beyondbalance.co.uk Contact Form";
           
            message.Body = $"<div>Name: {email.Name}<br/>Subject: {email.Subject}<br/>Email: {email.EmailAddress}<br/>Enquiry: {email.Enquiry}</div>";

            message.IsBodyHtml = true;

            //Attempting to send the email
            using (SmtpClient smtpClient = new SmtpClient())
            {
                await smtpClient.SendMailAsync(message);
            }
        }


        public async static Task SendAddSubscriberEmailAddress(string emailAddress)
        {
            //Constructing the email

            MailMessage message = new MailMessage("no_replay@bendandotest.com",  "info@beyondbalance.co.uk");
            message.Subject = "Message From Beyondbalance.co.uk Mailing List";

            message.Body = $"<div>Please add {emailAddress} to your Mailing List<br/></div>";

            message.IsBodyHtml = true;

            //Attempting to send the email
            using (SmtpClient smtpClient = new SmtpClient())
            {
                await smtpClient.SendMailAsync(message);
            }
        }



    }
}