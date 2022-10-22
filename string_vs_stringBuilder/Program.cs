using System.Diagnostics;
using System.Text;

namespace string_vs_stringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region strvsstrbuilder
            /*MyClass m1 = new();

            Stopwatch sw = Stopwatch.StartNew();


            int counter = 100000;
            string test = "";
            for (int i = 0; i < m1.counter; i++)
            {
                test += i;

            }
            Console.WriteLine(test + "\t");
            sw.Stop();
            long sbMsS = sw.ElapsedMilliseconds;
            sw.Restart();
            StringBuilder sb = new();
            for (int i = 0; i < m1.counter; i++)
            {
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine($"Total Ms for StringBuilder:{sbMsS}\t");
            Console.WriteLine($"Total Ms for String:{sw.ElapsedMilliseconds}\t");*/


            #endregion
          
        }

        class MyClass
        {
            public int counter { get; set; } = 100000;
        }
    }
}