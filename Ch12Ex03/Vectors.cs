using System.Collections.Generic;
using System.Text;

namespace Ch12Ex03
{
    public class Vectors : List<Vector>
    {
        public Vectors() { }

        public Vectors(IEnumerable<Vector> initialItems)
        {
            foreach (var vector in initialItems)
            {
                Add(vector);
            }
        }

        public string Sum()
        {
            var sb = new StringBuilder();
            var currentPoint = new Vector(0.0, 0.0);
            sb.Append("origin");
            foreach (var vector in this)
            {
                sb.AppendFormat($" + {vector}");
                currentPoint += vector;
            }
            sb.AppendFormat($" = {currentPoint}");
            return sb.ToString();
        }
    }
}
