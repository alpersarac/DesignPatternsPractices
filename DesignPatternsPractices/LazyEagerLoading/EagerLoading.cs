using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractices.EasyEagerLoading
{
    public sealed class EagerLoading
    {
        //Eager Loading is thread safe
        //Lazy Loading vs. Eager Loading. While lazy loading delays the initialization of a resource, eager loading initializes or loads a resource as soon as the code is executed.

        private static int counter = 0;
        private static EagerLoading instance = new EagerLoading();
        
        public static EagerLoading GetInstance
        {
            get
            {
                return instance;
            }
        }
        private EagerLoading()
        {
            counter++;
            Console.WriteLine(counter);
        }
        public void PrintDetails(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
