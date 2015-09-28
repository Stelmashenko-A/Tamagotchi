using System;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        public bool IsAlive => _liveTime != 0;

        public void TimeDec()
        {
            _liveTime--;
        }
        private int _liveTime = 7;

        public bool CanSurvive(int i)
        {
            return i < _energy;
        }

        private int _energy = 100;

        public void SearchFood(int i)
        {
            _energy -= i;
        }
        public void PushFood(Food food)
        {

            Console.WriteLine("Food  " + food.Name + " is eaten");
        }
    }
}
