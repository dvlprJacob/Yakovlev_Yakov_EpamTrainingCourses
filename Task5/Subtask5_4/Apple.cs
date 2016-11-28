using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_4
{
    class Apple : Bonus
    {
       public Apple() { }
       public bool IsUsed()
        {
            if (HealthApp == 0)
                return true;
            return false;
        }
    }
}
