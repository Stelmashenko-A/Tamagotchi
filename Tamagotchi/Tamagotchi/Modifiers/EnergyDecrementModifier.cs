namespace Tamagotchi.Modifiers
{
    public class EnergyDecrementModifier : IStateModifier
    {
        public State Modify(State state)
        {
            var newState = new State(state.LiveTime, state.Energy - 1);
            return newState;
        }
    }
}