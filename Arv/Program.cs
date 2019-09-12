using System;

namespace Arv
{
    class Program
    {
        static Fish[,] arrayFish = new Fish[10, 10];
        static Bird[,] arrayBird = new Bird[10, 10];
        static int birdCount = 0;
        static int fishCount = 0;
        static void Main(string[] args)
        {
            StartingPopulation();
            int count = 0;
            for (int x = 0; x < 100000; x++)
            {
                fishCount = 0;
                birdCount = 0;
                for (int i = 0; i < arrayFish.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayFish.GetLength(1); j++)
                    {
                        if (arrayBird[i, j] != null)
                        {
                            Console.Write(1);
                        }
                        else
                        {
                            Console.Write(0);
                        }
                        if (arrayFish[i, j] != null)
                        {
                            Console.Write(1 + "\t");
                        }
                        else
                        {
                            Console.Write(0 + "\t");
                        }
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (arrayFish[i, j] != null && arrayBird[i, j] != null)
                        {
                            arrayFish[i, j] = null;
                            birdCount++;
                            BirthBird();
                            break;
                        }
                        if (arrayBird[i, j] != null)
                        {
                            arrayBird[i, j] = null;
                        }
                        if (arrayFish[i, j] != null)
                        {
                            fishCount++;
                            BirthFish();
                        }

                    }
                }
                Console.WriteLine("");
                count++;
                Console.WriteLine(count);
                Console.WriteLine(fishCount + " " + birdCount);
                Console.WriteLine("");
            }
        }
        static void StartingPopulation()
        {

            Fish fish = new Fish();
            Bird bird = new Bird();
            for (int i = 0; i < 30; i++)
            {
                fishCount++;
                Random random = new Random();
                arrayFish[random.Next(0, 10), random.Next(0, 9)] = fish;
            }
            for (int i = 0; i < 30; i++)
            {
                birdCount++;
                Random random = new Random();
                arrayBird[random.Next(0, 10), random.Next(0, 10)] = bird;
            }
        }
        static void BirthFish()
        {
            fishCount++;
            Random random = new Random();
            Fish fish = new Fish();
            arrayFish[random.Next(0, 10), random.Next(0, 10)] = fish;
        }
        static void BirthBird()
        {
            Random random = new Random();
            Bird bird = new Bird();
            if(random.Next(0,9) < 8)
            {
                birdCount++;
                arrayBird[random.Next(0, 10), random.Next(0, 10)] = bird;
            }
        }
    }
}
