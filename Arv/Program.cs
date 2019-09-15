using System;

namespace Arv
{

    class Program
    {

        static void Main(string[] args)
        {
            Bird parrot = new Bird()
            {
                Color = "Omae",
                Name = "Yoshi",
                Age = 14,
                Weight = 2,
                Alive = true
            };
            Fish cod = new Fish()
            {
                Species = "Cod",
                Name = "Jeff",
                Age = 1,
                Weight = 4,
                Alive = true
            };
            Fish salmon = new Fish()
            {
                Species = "Salmon",
                Name = "Elias",
                Age = 3,
                Weight = 4,
                Alive = false
            };




        }
    }
}
