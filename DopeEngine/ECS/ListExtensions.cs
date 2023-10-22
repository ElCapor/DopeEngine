using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopeEngine.ECS
{
    public static class ListExtensions
    {
        public static bool Contains<T>(this List<T> list, Func<T, bool> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
