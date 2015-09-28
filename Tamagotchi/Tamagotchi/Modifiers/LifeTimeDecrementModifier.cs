namespace Tamagotchi.Modifiers
{
    internal class LifeTimeDecrementModifier : IStateModifier
    {
        public State Modify(State state)
        {
            var newState = new State(state.LiveTime - 1, state.Energy);
            return newState;
        }
    }
}