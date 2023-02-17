using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.NewFolder1
{
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public override string Cry()
        {
            return "Woof!";
        }
    }
}
    
