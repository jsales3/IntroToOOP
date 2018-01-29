using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat();

            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";
            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());

            secondCat.Meow();

            Dog myDog = new Dog();

            myDog.Height = 1;
            myDog.Weight = 20;
            myDog.Run();
            myDog.Bark();
            myDog.Potty();
            myDog.Cuddle();

        }
    }
}
