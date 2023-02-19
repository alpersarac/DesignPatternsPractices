using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractices
{
    public sealed class SingletonThreadSafe
    {
        //It is a pattern that allows you to use only one instance during the application usage.
        //Thread safe example showed below.
        //first if (instance == null) condition is way to avoid rudandant lock usage. if the instance is not initiated no need to lock the object.
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
