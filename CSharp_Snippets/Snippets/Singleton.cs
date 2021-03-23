using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    public sealed class Singleton
    {

        //its not thread safe
        private static int counter = 0;
        private static Singleton instance = null;
        public static readonly Object Instance = new object();  // this will make it threadsafe

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock(Instance)
                    {
                    if (instance == null)
                        instance = new Singleton();
                    
                    }
                }
                return instance;
            }
                    
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }   

        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
