using System;

namespace csharp_generics
{
    class Program
    {
        static void Main(string[] args)

        {
            generics<string> check = new generics<string>();
            bool res = check.compar("a", "a");
            Console.WriteLine(res);

            values obj1 = new values(dela.add);
            int res1 = obj1(30, 400);
            Console.WriteLine("result{0}\n", res1);

            values obj2 = new values(dela.sub);
            int res2 = obj2(100,50);
            Console.WriteLine("result{0}\n", res2);

           



            Console.ReadKey();
        }
    }
    public  class generics<T>
    {
        public  bool compar(T a, T b)
        {
           if(a.Equals(b))
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}
