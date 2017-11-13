using Bridge.Classes;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // new c++ progere
            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            // new order, but needs C# language
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.Read();
        }
    }
}
