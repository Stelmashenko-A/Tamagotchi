using System;
using Tamagotchi;
using Environment = Tamagotchi.Environment;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var en = new Environment();
            if (args == null) throw new ArgumentNullException(nameof(args));
            var tamagotchiFactory = new TamagotchiFactory();
            for (var i = 0; i < 5; i++)
            {
                var counter = 0;
                var t = tamagotchiFactory.GetNext();
                var time = en.CreateTimeForNextFood();
                while (t.CanSurvive(time) && t.IsAlive)
                {
                    t.SearchFood(time);
                    t.TimeDec();
                    t.PushFood(en.CreateFood());
                    counter++;
                    time = en.CreateTimeForNextFood();
                }
                Console.WriteLine("Tamagochi is dead it live " + counter);
            }
            Console.ReadLine();
        }
    }
}
