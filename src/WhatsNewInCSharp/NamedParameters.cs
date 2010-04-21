using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatsNewInCSharp
{
    public class NamedParameters
    {
        public static void SomeMethod(int a, int b, int c)
        {
            Console.WriteLine(string.Format("a = {0}", a));
            Console.WriteLine(string.Format("a = {0}", a));
            Console.WriteLine(string.Format("b = {0}", b));
        }
    }

    public class OptionalArguments
    {
        public static void SomeMethod(int a, string name = "Frank")
        {
            Console.WriteLine(string.Format("a = {0}", a));
            Console.WriteLine(string.Format("name = {0}", name));
        }
    }
}
