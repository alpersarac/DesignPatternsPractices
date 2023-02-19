using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractices
{
    public class Singleton
    {
        //It is a pattern that allows you to use only one instance during the application usage.
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance{
            get 
            {
                if (instance==null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
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
