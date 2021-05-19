using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_generics
{
    public delegate int values(int a, int b);
    class dela
    {
        public static int add(int a, int b)
        {
            return (a + b);
        }

        public static int sub(int a, int b)
        {
            return (a - b);
        }
    }
    
}
