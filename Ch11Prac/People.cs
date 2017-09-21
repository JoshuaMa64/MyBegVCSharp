using System;
using System.Collections;

namespace Ch11Prac
{
    public class People : CollectionBase, ICloneable
    {
        public void Add(Person p)
        {
            List.Add(p);
        }

        public Person this[string name]
        {
            get { return (Person) List[List.IndexOf(name)]; }
            set { List[List.IndexOf(name)] = value; }
        }

        public object Clone()
        {
            People np = new People();
            foreach (Person p in List)
            {
                np.Add((Person) p.Clone());
            }
            return np;
        }
    }
}
