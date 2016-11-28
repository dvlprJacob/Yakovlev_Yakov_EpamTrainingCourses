using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_3
{
    public class Shape
    {
        protected string Name { set; get; }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
