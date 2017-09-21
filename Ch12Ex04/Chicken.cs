using static System.Console;

namespace Ch12Ex04
{
    public class Chicken : Animal
    {
        public void LayEgg() => WriteLine($"{name} has laid an egg.");
        public Chicken(string newName) : base(newName) { }
        public override void MakeNoise()
        {
            WriteLine($"{name} says 'cluck!'");
        }
    }
}
