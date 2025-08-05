using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplewidowsapplication
{
    class Hii
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to learn c#");
        }
        public void hello()
        {
            Console.WriteLine("hello");
            new Hii().Welcome();
        }
    }
}
