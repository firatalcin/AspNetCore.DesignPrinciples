using System.Security.Cryptography.X509Certificates;

namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailService mailService = new MailService();
            mailService.SendMail(new GMail(), "...", "...");
        }
    }


    class MailService
    {
        public void SendMail(IMailService mailService, string to, string body)
        {
            mailService.Send(to, body);
        }
    }

    interface IMailService
    {
        void Send(string to, string body);
    }

    class GMail : IMailService
    {
        public void Send(string to, string body)
        {
            Console.WriteLine("GMail ile gönderildi");
        }
    }

    class Outlook : IMailService
    {
        public void Send(string to, string body)
        {
            Console.WriteLine("Outlook ile gönderildi");
        }
    }

    class Yandex : IMailService
    {
        public void Send(string to, string body)
        {
            Console.WriteLine("Yandex ile gönderildi");
        }
    }
}
