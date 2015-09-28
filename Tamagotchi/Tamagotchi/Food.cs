namespace Tamagotchi
{
    public class Food
    {
        public string Name { get; protected set; }

        public Food(string name)
        {
            Name = name;
        }
    }
}
