using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractices
{
    public sealed class SingletonThreadSafe
    {
        private static int counter = 0;
        private static SingletonThreadSafe instance = null;
        private static readonly Object obj = new Object();
        public static SingletonThreadSafe GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonThreadSafe();
                        }
                    }
                }

                return instance;
            }
        }
        private SingletonThreadSafe()
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
