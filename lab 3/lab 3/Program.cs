using lab_3.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a name for the dog:");
            string dogName = Console.ReadLine();

            Dog dog = new Dog();
            dog.Name = dogName;
            dog.Age = 69;
            dog.Colour = "brown";

            Console.WriteLine("Dog name: " + dog.Name);
            Console.WriteLine("Dog age: " + dog.Age);
            Console.WriteLine("Dog colour: " + dog.Colour);
            dog.Eat();

            Console.WriteLine();

            Console.WriteLine("Enter a name for the cat:");
            string catName = Console.ReadLine();

            Cat cat = new Cat();
            cat.Name = catName;
            cat.Age = 69;
            cat.Colour = "black";

            Console.WriteLine("Cat name: " + cat.Name);
            Console.WriteLine("Cat age: " + cat.Age);
            Console.WriteLine("Cat colour: " + cat.Colour);
            cat.Eat();

            Dog myDog = new Dog();
            Console.WriteLine("Enter a name for the dog:");
            myDog.Name = Console.ReadLine();
            Console.WriteLine("Enter a color for the dog:");
            myDog.Colour = Console.ReadLine();
            Console.WriteLine("Enter an age for the dog:");
            myDog.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a height for the dog in ft:");
            myDog.Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dog properties:");
            Console.WriteLine("Name: " + myDog.Name);
            Console.WriteLine("Color: " + myDog.Colour);
            Console.WriteLine("Age: " + myDog.Age);
            Console.WriteLine("Height: " + myDog.Height);
            myDog.Eat();
            Console.WriteLine("Cry: " + myDog.Cry());

            Cat myCat = new Cat();
            Console.WriteLine("Enter a name for the cat:");
            myCat.Name = Console.ReadLine();
            Console.WriteLine("Enter a color for the cat:");
            myCat.Colour = Console.ReadLine();
            Console.WriteLine("Enter an age for the cat:");
            myCat.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a height for the cat in ft:");
            myCat.Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cat properties:");
            Console.WriteLine("Name: " + myCat.Name);
            Console.WriteLine("Color: " + myCat.Colour);
            Console.WriteLine("Age: " + myCat.Age);
            Console.WriteLine("Height: " + myCat.Height);
            myCat.Eat();
            Console.WriteLine("Cry: " + myCat.Cry());

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(myDog);
            animals.Add(myCat);

            Console.WriteLine("List of animal names:");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}



    

