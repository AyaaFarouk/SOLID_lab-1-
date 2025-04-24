using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface IEmailValidator
    {
        bool ValidateEmail(string email);
    }
    public class ValidateEmails : IEmailValidator
    {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
    //-------------------------------------------------
    public interface IEmailSend
    {
        bool SendEmail(MailMessage message);
    }

    public class SendEmails : IEmailSend
    {
        private SmtpClient _smtpClient;

        public SendEmails(SmtpClient smtp)
        {
            _smtpClient = smtp;
        }
        public bool SendEmail(MailMessage message)
        {
            try
            {
                _smtpClient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
    //--------------------------------------------------------------------------
    public class User
    {
        public string Email { get; }
        public string Password { get; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
    //---------------------------------------------------------
    public interface IRegister
    {
        void Register(string email, string password);
    }
    public class RegisterService : IRegister
    {
        private readonly IEmailValidator _emailValidator;
        private readonly IEmailSend _emailService;
        public void Register(string email, string password)
        {
            if (!_emailValidator.ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new User(email, password);

            _emailService.SendEmail(new MailMessage("mysite@nowhere.com", email){ Subject = "HEllo foo"});
        }
    }

}
