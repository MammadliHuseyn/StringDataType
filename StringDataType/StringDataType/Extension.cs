using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType
{
    public static class Extension
    {
        public static void CharAt(this string str,int index)
        {
            Console.WriteLine(str[index]);
        }
    }
}
