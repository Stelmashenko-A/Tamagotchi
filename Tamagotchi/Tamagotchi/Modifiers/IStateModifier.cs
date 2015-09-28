namespace Tamagotchi.Modifiers
{
    public interface IStateModifier
    {
        State Modify(State state);
    }
}
