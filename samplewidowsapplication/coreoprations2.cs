using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplewidowsapplication
{
    class coreoprations2
    {
        public void section()
        {
            string a = "cow";
            string b = "milk";
            Console.WriteLine(a + b);
            sectionb();
            sectionc();
            sectiond();
            
        }



        public void sectionb()

        {
            int a = 19;
            int b = 65;
            Console.WriteLine(a - b);

        }

        private void sectionc()
        {
            int z = 124 / 2;
            int r = 66 % 3;
            Console.WriteLine(z);
            Console.WriteLine(r);


        }

        public void sectiond()
        {
            int a = 60;
            int b = 64;
            a = ++b;
            b = a--;
            Console.WriteLine(b = a--);
            Console.WriteLine(a = ++b);

        }
    }
 
}