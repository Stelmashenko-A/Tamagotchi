using System;
using Tamagotchi.Modifiers;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private State _state;

        private readonly IStateModifier _energyModifier;

        private readonly IStateModifier _timeModifier;

        public Tamagotchi(State state, IStateModifier energyModifier, IStateModifier timeModifier)
        {
            _state = state;
            _energyModifier = energyModifier;
            _timeModifier = timeModifier;
        }

        public bool IsAlive => _state.LiveTime != 0;

        public void TimeDec()
        {
            _state = _timeModifier.Modify(_state);
        }

        public bool CanSurvive(int i)
        {
            return i < _state.Energy;
        }


        public void SearchFood(int time)
        {
            for (var i = 0; i < time; i++)
            {
                _state = _energyModifier.Modify(_state);
            }
        }

        public void PushFood(Food food)
        {
            Console.WriteLine("Food  " + food.Name + " is eaten");
        }
    }
}
