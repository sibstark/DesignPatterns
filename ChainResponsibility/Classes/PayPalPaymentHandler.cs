using System;

namespace ChainResponsibility.Classes
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("PayPal processing");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}