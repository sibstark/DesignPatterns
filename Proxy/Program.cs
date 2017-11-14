using System;
using Proxy.Classes;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IBook book = new BookStoreProxy())
            {
                // read the first page
                Page page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);
                // read the second page
                Page page2 = book.GetPage(2);
                Console.WriteLine(page2.Text);
                // return back the first page
                page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);
            }

            Console.Read();
        }
    }
}
