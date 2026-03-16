using GIT_Practice.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Net.Mail;

namespace GIT_Practice.Services
{
    public class EmailService
    {
        public bool SendBookingEmail(RideBooking ride)
        {
            try
            {
                var message = new MimeMessage();

                message.From.Add(new MailboxAddress("Ride Booking System", "rajsahurealid@gmail.com"));
                message.To.Add(new MailboxAddress("Developer", "rsdevilyt@gmail.com"));

                message.Subject = "🚗 New Ride Booking Notification";

                message.Body = new TextPart("html")
                {
                    Text = $@"
                    <h2>New Ride Booking Received</h2>
                    <p><b>Name:</b> {ride.Name}</p>
                    <p><b>Email:</b> {ride.Email}</p>
                    <p><b>Car:</b> {ride.Car}</p>
                    <p><b>Ride Date:</b> {ride.RideDate:dd MMMM yyyy}</p>
                    "
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate("rajsahurealid@gmail.com", "your-app-password");
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true; // email sent
            }
            catch (Exception ex)
            {
                Console.WriteLine("Email failed: " + ex.Message);
                return false; // email failed
            }
        }
    }
}