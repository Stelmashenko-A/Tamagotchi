using System;

namespace Tamagotchi
{
    public class Environment
    {
        public Food CreateFood()
        {
            return new Food("food1");
        }


        private Random r = new Random();
        public int CreateTimeForNextFood()
        {
            return r.Next() % 15;
        }
    }
}