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

            Console.WriteLine($"Занятая память со всеми объектами: {GC.GetTotalMemory(true)}");

            d = null;
            GC.Collect();
            Console.WriteLine($"Занятая память без 1 объекта: {GC.GetTotalMemory(true)}");

            d2 = null;
            GC.Collect();
            Console.WriteLine($"Занятая память без объектов: {GC.GetTotalMemory(true)}");

            Console.ReadKey();
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
            //SomeGlobalClass.Instance.OnSomething += EventHandler; !!! Связь с глобальным классом
        }

        public void EventHandler()
        {

        }
    }
}
