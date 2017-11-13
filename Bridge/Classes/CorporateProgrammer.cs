using System;

namespace Bridge.Classes
{
    public class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang) : base(lang)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Получаем в конце месяца зарплату");
        }
    }
}
