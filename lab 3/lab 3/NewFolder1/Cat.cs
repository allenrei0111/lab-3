using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.NewFolder1
{
    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public override string Cry()
        {
            return "Meow!";
        }
    }
}
