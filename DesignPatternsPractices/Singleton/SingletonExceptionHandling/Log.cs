using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractices.SingletonExceptionHandling
{
    public class Log : ILog
    {
        //It is a pattern that allows you to use only one instance during the application usage.
        private static Log instance = null;
        public static Log GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Log();
                }
                return instance;
            }
        }
        private Log()
        {

        }

        public void LogException(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class LogTester{
        //https://youtu.be/NjhUK68rzCs
        ILog _ILog;
        public LogTester()
        {
            _ILog = Log.GetInstance;
        }
    }
}
