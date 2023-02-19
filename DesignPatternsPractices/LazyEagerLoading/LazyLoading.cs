using DesignPatternsPractices.EasyEagerLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractices.LazyEagerLoading
{
    public class LazyLoading
    {
        //Lazy Loading is thread safe
        //Lazy Loading vs. Eager Loading.
        //While lazy loading delays the initialization of a resource, eager loading initializes or loads a resource as soon as the code is executed.
        private static int counter = 0;
        private static Lazy<LazyLoading> instance = new Lazy<LazyLoading>(()=> new LazyLoading());

        public static LazyLoading GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        private LazyLoading()
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
