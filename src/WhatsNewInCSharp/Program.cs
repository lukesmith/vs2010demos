using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace WhatsNewInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Action> actions = new List<Action>();
            actions.Add(new Action(DoNamedParameters));
            actions.Add(new Action(DoOptionalArguments));
            actions.Add(new Action(ParallelLinq.AsParallel));
            actions.Add(new Action(ParallelLinq.ParallelFor));
            actions.Add(new Action(ParallelLinq.ParallelAsOrdered));

            for (int i = 0; i < actions.Count; i++)
            {
                Console.WriteLine(string.Format("{0}: {1}", i, actions[i].Method.Name));
            }

            Console.Write("Choose: ");
            var choice = Console.ReadLine();
            
            Console.WriteLine();
            Execute(actions[Convert.ToInt32(choice)]);

            Console.ReadLine();
        }

        public static void Execute(Action action)
        {
            Console.WriteLine(action.Method.Name);
            action.Invoke();
        }

        public static void DoNamedParameters()
        {
            NamedParameters.SomeMethod(a: 5, c: 3, b: 1);
        }

        public static void DoOptionalArguments()
        {
            OptionalArguments.SomeMethod(4);
            OptionalArguments.SomeMethod(4, "John");
        }
    }
}
