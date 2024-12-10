using System;

namespace MessengerApp
{
    public interface IMessage
    {
        string Content { get; }
    }

    public class Letter : IMessage
    {
        public string Content { get; }

        public Letter(string content)
        {
            Content = content;
        }
    }

    public class Email : IMessage
    {
        public string Content { get; }

        public Email(string content)
        {
            Content = content;
        }
    }

    public class SMS : IMessage
    {
        public string Content { get; }

        public SMS(string content)
        {
            Content = content;
        }
    }

    public class Messenger<T> where T : IMessage
    {
        public void Send(T message)
        {
            Console.WriteLine($"Sending {message.GetType().Name}: {message.Content}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var letter = new Letter("Secret content of the letter.");
            var email = new Email("This is an email content.");
            var sms = new SMS("This is an SMS content.");

            var letterMessenger = new Messenger<Letter>();
            letterMessenger.Send(letter);

            var emailMessenger = new Messenger<Email>();
            emailMessenger.Send(email);

            var smsMessenger = new Messenger<SMS>();
            smsMessenger.Send(sms);
        }
    }
}
