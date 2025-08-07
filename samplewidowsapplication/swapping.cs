using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace samplewidowsapplication
{
     
    class swapping
    {
        public void Swapping()
        {
            int a = 67;
            int b = 21;
            int c = a = a + b;
            c = b = c + b;
            a = b - a;
            b = a - c;


            Console.WriteLine(c);
            Console.WriteLine(b);
        }
    }

}