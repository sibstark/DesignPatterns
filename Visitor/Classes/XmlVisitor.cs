using System;

namespace Visitor.Classes
{
    public class XmlVisitor : IVisitor
    {
        public void VisitCompanyAc(Company acc)
        {
            string result = "<Company><Name>" + acc.Name + "</Name>" + "<RegNumber>" + acc.RegNumber + "</RegNumber>" + "<Number>" + acc.Number + "</Number><Company>";
            Console.WriteLine(result);
        }

        public void VisitPersonAcc(Person acc)
        {
            string result = "<Person><Name>" + acc.Name + "</Name>" + "<Number>" + acc.Number + "</Number><Person>";
            Console.WriteLine(result);
        }
    }
}
