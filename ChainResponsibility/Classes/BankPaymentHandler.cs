using System;

namespace ChainResponsibility.Classes
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Bank processing");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}