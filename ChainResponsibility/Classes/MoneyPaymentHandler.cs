using System;

namespace ChainResponsibility.Classes
{
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Money transfering processing");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}