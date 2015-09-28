namespace Tamagotchi
{
    public class Food
    {
        public string Name { get; }

        public Food(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var tmp = obj as Food;
            return tmp != null && Equals(tmp);
        }

        protected bool Equals(Food other)
        {
            return string.Equals(Name, other.Name);
        }

        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0;
        }
    }
}
