namespace Tamagotchi
{
    public class State
    {
        public State(int liveTime, int energy)
        {
            LiveTime = liveTime;
            Energy = energy;
        }

        public int LiveTime { get; }

        public int Energy { get; }
    }
}
