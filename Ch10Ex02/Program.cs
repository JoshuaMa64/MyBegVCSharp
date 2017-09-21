using static System.Console;

namespace Ch10Ex02
{
    public class ClassA
    {
        private int state = -1;

        public int State
        {
            get { return state; }
        }
        public class ClassB
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }
    }


    static class Program
    {
        static void Main(string[] args)
        {
            var myObject = new ClassA();
            WriteLine($"myObject.State = {myObject.State}");
            var myOtherObject = new ClassA.ClassB();
            myOtherObject.SetPrivateState(myObject, 999);
            WriteLine($"myObject.State = {myObject.State}");
            ReadKey();
        }
    }
}
