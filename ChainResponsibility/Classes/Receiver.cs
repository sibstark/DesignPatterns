namespace ChainResponsibility.Classes
{
    public class Receiver
    {
        public bool BankTransfer { get; }
        public bool MoneyTransfer { get; }
        public bool PayPalTransfer { get; }

        public Receiver(bool bt, bool mt, bool ppt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
    }
}