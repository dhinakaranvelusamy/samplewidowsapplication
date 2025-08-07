using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplewidowsapplication
{
    class variable2
    {
        string name = "teddy";

        public void method1()
        {
            string name = "toys";
            name = "deer";
            Console.WriteLine(this.name+ name);
            method2();
            method3();

        }
        private void method2()
        {
            int v = 56;
            int d = 67;
            Console.WriteLine(v = d);
            name = "honeybacth";
            Console.WriteLine(this.name + name);
            
        }
        public void method3()
        {
            string _name = "lion";
            _name = "tigar";

            Console.WriteLine(_name+_name );
            Console.WriteLine(_name);
            
        }
    }
    
}
