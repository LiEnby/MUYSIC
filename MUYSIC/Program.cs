using System;

namespace MUYSIC
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed;
            if(args.Length == 0)
            {
                //Randomly get a seed
                seed = new Random().Next();
            }
            else
            {
                seed = Convert.ToInt32(args[0]);
            }

            Random Rand = new Random(seed);

            Console.WriteLine("Using seed "+seed.ToString()+"\nYou can specify a seed as a launch argument");

            while (true)
            {
                int dur = Rand.Next(100, 150);
                int freq = Rand.Next(100, 5000);
                Console.Beep(freq, dur);
            }

        }
    }
}
