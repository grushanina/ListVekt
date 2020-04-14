using System;

namespace ConsoleApp2
{
    class Program
    {
        delegate int tr(int x);
        delegate int sum(int x, int y);
        static void Main()
        {
            //var el = new System.Collections.Generic.List<int>() { 1, 2, 3, 4 };
            //int od = el.Find(x => x % 2 != 0);
            //Console.Write(od);

            //Func<int, int, int> f1 = (x, y) => x * y;
            //Action<int, int> f2 = (x, y) => { var z = x + y; Console.WriteLine("x+y" + z); };
            //f2(5, 5);
            //sum p = (x, y) => x + y;
            //tr sq = x => x * x;
            //Console.WriteLine(sq(3));
            //Console.WriteLine(p(3,2));

            var lst = new List<string>();
            lst.Add("1");
            lst.Add("2");
            lst.Add("3");
            //lst[0] = "uio";
            //lst.Insert(1, "f");
            //lst.RemoveAt(2);
            //lst.Clear();
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine(lst[i]);
            //}
            //Console.WriteLine();

            //Console.WriteLine(lst.Constains(x => x == "2"));

            //Console.WriteLine(lst.IndexOf("4"));

            //lst.ForEach(n=>Console.WriteLine(n));

            //Console.WriteLine(lst.Find(x => x == "2"));

            Console.WriteLine(lst.FindIndex(x => x == "2"));
        }
    }
}
