using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.Validation
{
    internal class MyLib
    {
        public static bool IsListEmpty<T>(List<T> values,string messageIfEmpty)
        {
            if (values.Count() == 0)
            {
                Console.WriteLine(messageIfEmpty);
                return true;
            }
            return false;
        }
    }
}
