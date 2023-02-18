using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using static System.Console;

namespace DesignPatternsPractices
{
    public class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(() => First(), () => Second());
           
            Console.ReadLine();
        }

        private static void Second()
        {
            Singleton singleton = Singleton.GetInstance;
            singleton.PrintDetails("Second Message");
        }

        private static void First()
        {
            Singleton singleton = Singleton.GetInstance;
            singleton.PrintDetails("First Message");
        }
    }
    



}
