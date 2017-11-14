using System.Collections.Generic;

namespace Proxy.Classes
{
    public class PageContext
    {
        public List<Page> Pages { get; set; } = new List<Page>
        {
            new Page
            {
                Id = 0,
                Number = 0,
                Text = "Text 1"
            },
            new Page
            {
                Id = 1,
                Number = 1,
                Text = "Text 2"
            },
            new Page
            {
                Id = 2,
                Number = 2,
                Text = "Text 3"
            }
        };
    }
}