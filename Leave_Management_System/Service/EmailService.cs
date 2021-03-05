using Leave_Management_System.Models.ViewModel;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Service
{
    public class EmailService : IEmailService
    {
        private const string templetePath = @"EmailTemplete/{0}.html";
        private readonly SMTPConfigru _smtpconfigru;
        public EmailService(IOptions<SMTPConfigru> smtpconfig)
        {
            _smtpconfigru = smtpconfig.Value;
        }
        public async Task ForgotpasswordEmail(UserEmail userEmail)
        {
            userEmail.Subject = "Forgot Password link";
            userEmail.Body = UpdatePlaceHolder(GetEmailBody("ForgotPassword"), userEmail.PlaceHolder);
            await sendEmail(userEmail);
        }
        public async Task SendLeaveUpdateEmail(UserEmail userEmail)
        {
            userEmail.Subject = "Update Leave";
            userEmail.Body = UpdatePlaceHolder(GetEmailBody("LeaveUpdate"), userEmail.PlaceHolder);
            await sendEmail(userEmail);
        }
        public async Task SendLeaveCancelEmail(UserEmail userEmail)
        {
            userEmail.Subject = "Cancel Leave";
            userEmail.Body = UpdatePlaceHolder(GetEmailBody("LeaveDeleteMail"), userEmail.PlaceHolder);
            await sendEmail(userEmail);
        }
        public async Task SendTestEmail(UserEmail userEmail)
        {
            userEmail.Subject = "Test Email";
            userEmail.Body = UpdatePlaceHolder(GetEmailBody("Test"),userEmail.PlaceHolder);
            await sendEmail(userEmail);
        }
        private async Task sendEmail(UserEmail userEmail)
        {
            MailMessage mail = new MailMessage
            {
                Subject = userEmail.Subject,
                Body = userEmail.Body,
                From = new MailAddress(_smtpconfigru.SenderAddress, _smtpconfigru.SenderDisplyName),
                IsBodyHtml = _smtpconfigru.IsBodyHTML,

            };
            mail.To.Add(userEmail.ToEmail);
            NetworkCredential networkCredential = new NetworkCredential
            {
                UserName = _smtpconfigru.UserName,
                Password = _smtpconfigru.Password,

            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpconfigru.Host,
                Port = _smtpconfigru.Port,
                EnableSsl = _smtpconfigru.EnableSSL,
                UseDefaultCredentials = _smtpconfigru.UserDefaultCredentils,
                Credentials = networkCredential,
            };
            mail.BodyEncoding = Encoding.Default;
            await smtpClient.SendMailAsync(mail);
        }
        private string GetEmailBody(string templetName)
        {
            var body = File.ReadAllText(string.Format(templetePath, templetName));
            return body;
        }
        private string  UpdatePlaceHolder(string text,List<KeyValuePair<string,string>> KeyvaluePair)
        {
            if(!string.IsNullOrEmpty(text) && KeyvaluePair != null)
            {
                foreach(var placeholder in KeyvaluePair)
                {
                    if(text.Contains(placeholder.Key))
                    {
                        text = text.Replace(placeholder.Key, placeholder.Value);
                    }
                }
            }
            return text;
        }
    }
}
