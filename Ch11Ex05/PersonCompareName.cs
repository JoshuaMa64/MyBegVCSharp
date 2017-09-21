using System;
using System.Collections;

namespace Ch11Ex05
{
    public class PersonCompareName : IComparer
    {
        public static IComparer Default = new PersonCompareName();
        public int Compare(object x, object y)
        {
            if (x is Person && y is Person)
            {
                return Comparer.Default.Compare(
                    ((Person) x).Name, ((Person) y).Name);
            }
            throw new ArgumentException(
                "One or both objects to compare are not Person objects.");
        }
    }
}
