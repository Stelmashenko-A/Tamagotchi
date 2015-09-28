using System;
using System.Collections.Generic;
using Tamagotchi.Modifiers;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private State _state;

        private readonly IStateModifier _energyDecrementModifierModifier;

        private readonly IStateModifier _timeModifier;

        private readonly IDictionary<Food, IStateModifier> _foodReaction;

        public Tamagotchi(State state, IStateModifier energyDecrementModifierModifier, IStateModifier timeModifier,
            IDictionary<Food, IStateModifier> foodReaction)
        {
            _state = state;
            _energyDecrementModifierModifier = energyDecrementModifierModifier;
            _timeModifier = timeModifier;
            _foodReaction = foodReaction;
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
                _state = _energyDecrementModifierModifier.Modify(_state);
            }
        }

        public void PushFood(Food food)
        {
            _state = _foodReaction[food].Modify(_state);
            Console.WriteLine("Food  " + food.Name + " is eaten");
        }
    }
}
