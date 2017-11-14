using System;

namespace Proxy.Classes
{
    public interface IBook : IDisposable
    {
         Page GetPage(int number);
    }
}