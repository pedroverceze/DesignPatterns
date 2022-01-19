using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Logger
    {
        private static Logger logger;
        private static Logger instance; 
        
        
        public static Logger Instance{ 
            get
            {
                if (instance is null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        private Logger()
        { }

        public static Logger GetInstance()
        {
            if(logger is null)
            {
                logger = new Logger();
            }

            return logger;
        }
    }
}
