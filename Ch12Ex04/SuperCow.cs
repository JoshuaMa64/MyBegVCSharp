using static System.Console;
namespace Ch12Ex04
{
    public class SuperCow : Cow
    {
        public SuperCow(string newName) : base(newName) { }
        public void Fly() => WriteLine($"{name} if flying!");
        public override void MakeNoise() => WriteLine($"{name} says 'here I come to save the day'");
    }
}