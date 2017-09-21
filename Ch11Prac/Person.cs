using System;

namespace Ch11Prac
{
    public class Person : ICloneable
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static bool operator >(Person p1, Person p2) => p1.Age > p2.Age;
        public static bool operator <(Person p1, Person p2) => !(p1 >= p2);
        public static bool operator >=(Person p1, Person p2) => p1.Age >= p2.Age;
        public static bool operator <=(Person p1, Person p2) => !(p1 > p2);
        public object Clone() => MemberwiseClone();
    }
}