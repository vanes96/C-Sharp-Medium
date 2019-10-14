using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeGlobalClass SGC = new SomeGlobalClass();
            BigData d = new BigData();
            BigData d2 = new BigData();
            d = null;
            d2 = null;

            GC.Collect();

            while (true)
            {

            }
        }
    }

    class SomeGlobalClass
    {
        public static SomeGlobalClass Instance;
        public event Action OnSomething;

        public SomeGlobalClass()
        {
            Instance = this;
        }

        public void DoSomething()
        {
            if (OnSomething != null)
            {
                OnSomething();
            }
        }
    }

    class BigData
    {
        public int[] Data;

        public BigData()
        {
            Data = new int[100000];
            SomeGlobalClass.Instance.OnSomething += EventHandler;
        }

        public void EventHandler()
        {

        }
    }
}
