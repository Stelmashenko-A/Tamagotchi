using Tamagotchi.Modifiers;

namespace Tamagotchi
{
    public class TamagotchiFactory
    {
        public Tamagotchi GetNext()
        {
            return new Tamagotchi(new State(20,100),new EnergyDecrementModifier(), new LifeTimeDecrementModifier());
        }
    }
}
