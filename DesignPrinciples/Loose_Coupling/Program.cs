namespace Loose_Coupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailSender mailSender = new MailSender();
            mailSender.Send(new Outlook());
        }
    }

    class MailSender
    {
        public void Send(IMailServer mailServer)
        {
            mailServer.Send("firatalcin@gmail.com", "Onemli");
        }
    }

    interface IMailServer
    {
        void Send(string to, string body);
    }


    class Gmail : IMailServer
    {
        public void Send(string to, string body)
        {
            Console.WriteLine("Gmail Maili Atıldı");
        }
    }

    class Outlook : IMailServer
    { 
        public void Send(string to, string body)
        {
            Console.WriteLine("Outlook Maili Atıldı");
        }
    }

}
