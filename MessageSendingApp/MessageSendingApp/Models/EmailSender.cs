using System;
using System.Collections.Generic;
using System.Text;

namespace MessageSendingApp.Models
{
    internal class EmailSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("\nMessage sended via Email\n");
        }
    }
}
