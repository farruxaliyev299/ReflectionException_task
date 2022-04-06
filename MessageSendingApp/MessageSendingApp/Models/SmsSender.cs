using System;
using System.Collections.Generic;
using System.Text;

namespace MessageSendingApp.Models
{
    internal class SmsSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("\nMessage sended via SMS\n");
        }
    }
}
