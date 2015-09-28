using System;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private readonly State _state;

        public Tamagotchi()
        {
            _state = new State
            {
                Energy = 100,
                LiveTime = 7
            };
        }

        public bool IsAlive => _state.LiveTime != 0;

        public void TimeDec()
        {
            _state.LiveTime--;
        }

        public bool CanSurvive(int i)
        {
            return i < _state.Energy;
        }


        public void SearchFood(int i)
        {
            _state.Energy -= i;
        }

        public void PushFood(Food food)
        {

            Console.WriteLine("Food  " + food.Name + " is eaten");
        }
    }
}
