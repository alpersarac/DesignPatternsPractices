using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using static System.Console;
using DesignPatternsPractices.EasyEagerLoading;

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
            EagerLoading singleton = EagerLoading.GetInstance;
            singleton.PrintDetails("Second Message");
        }

        private static void First()
        {
            EagerLoading singleton = EagerLoading.GetInstance;
            singleton.PrintDetails("First Message");
        }
    }
    



}
