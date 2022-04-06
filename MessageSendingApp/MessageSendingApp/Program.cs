using System;
using MessageSendingApp.Models;

namespace MessageSendingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Menu:\n1.Send message by email\n2.Send message by sms\n0.Quit\n\n");
                Console.Write("Menu contenti secin : ");
                int content = int.Parse(Console.ReadLine());

                if (content == 0)
                {
                    return;
                }
                else if (content == 1)
                {
                    EmailSender emailSender = new EmailSender();
                    emailSender.SendMessage();
                }
                else if (content == 2)
                {
                    SmsSender smsSender = new SmsSender();
                    smsSender.SendMessage();
                }
                else
                {
                    Console.WriteLine("Menuda olan bir content secin!");
                }
            }
            
        }
    }
}
