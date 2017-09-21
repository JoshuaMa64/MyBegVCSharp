using static System.Console;

namespace Ch11Ex01
{
    public class Cow : Animal
    {
        public void Milk() => WriteLine($"{name} has been fed.");
        public Cow(string newName) : base(newName) { }
    }
}
