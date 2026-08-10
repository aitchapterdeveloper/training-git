using System;
using GitTrainingDemo.Interfaces;
public class MessageServices
{
    public class SMSMessaging: ISendMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{message} sent through SMS");
        }
    }
    public class WAMessaging : ISendMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{message} sent through WhatsApp");
        }
    }
    public class DiscordMessaging : ISendMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{message} sent through Discord");
        }
    }
}