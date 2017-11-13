using System;

namespace Bridge.Classes
{
    public class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage lang) : base(lang)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Получаем оплату за выполненный заказ");
        }
    }
}
