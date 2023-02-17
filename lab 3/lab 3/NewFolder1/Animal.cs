using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.NewFolder1
{
    abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        public abstract void Eat();

        public int Height { get; set; }
        public virtual string Cry()
        {
            return "The animal cries.";
        }
    }
}
