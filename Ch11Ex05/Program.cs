using System.Collections;
using static System.Console;

namespace Ch11Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Person("Rual", 30));
            list.Add(new Person("Donna", 25));
            list.Add(new Person("Mary", 27));
            list.Add(new Person("Ben", 44));
            WriteLine("Unsorted people:");
            foreach (Person t in list)
            {
                WriteLine($"{t.Name} ({t.Age})");
            }
            WriteLine();
            WriteLine("People sorted with default comparer (by age):");
            list.Sort();
            foreach (Person t in list)
            {
                WriteLine($"{t.Name} ({t.Age})");
            }
            WriteLine();
            WriteLine("People sorted with default comparer (by name):");
            list.Sort(PersonCompareName.Default);
            foreach (Person t in list)
            {
                WriteLine($"{t.Name} ({t.Age})");
            }
            ReadKey();
        }
    }
}
