using System;
using Environment = Tamagotchi.Environment;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var en = new Environment();
            if (args == null) throw new ArgumentNullException(nameof(args));
            for (var i = 0; i < 5; i++)
            {
                var counter = 0;
                var t = new Tamagotchi.Tamagotchi();
                var time = en.CreateTimeForNextFood();
                while (t.CanSurvive(time))
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
