using System.Collections.Generic;
using Tamagotchi.Modifiers;

namespace Tamagotchi
{
    public class TamagotchiFactory
    {
        public Tamagotchi GetNext()
        {
            IDictionary<Food,IStateModifier> tmp = new Dictionary<Food, IStateModifier>();
            tmp.Add(new Food("food1"),new EnergyIncrementModifier());
            return new Tamagotchi(new State(20, 100), new EnergyDecrementModifier(), new LifeTimeDecrementModifier(),
                tmp);
        }
    }
}
