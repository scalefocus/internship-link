using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional
{
    // Defines a prototype of a function that has a double argument and returns the result as a double value
    delegate double MyFunc(double x);

    class Program
    {
        static void Main(string[] args)
        {
            MyFunc f = Math.Sin;
            double value = 0;

            value = f(4);
            Console.WriteLine("Value is:" + value);

            f = Math.Exp;
            value = f(4);

            Console.WriteLine("Value is:" + value);


            // 2. Instead of strongly typed delegates you can use generic function types
            Func<double, double> sin = Math.Sin;

            // 3. Predicate
            Action<string> write = Console.Write;

            // 4. Action
            Predicate<string> pred = string.IsNullOrEmpty;

            // 5. Invoke function and get value

            bool isEmpty = pred("");

            // 6. Anonymous delegates

            //Func<double, double> f1 = (x) x + 10;

            Example.Test(delegate (double x) { return x + 10; });
            Example.Test(x => x + 10);

            // 7. Lambda expressions

            Func<double, double, double> sum = (x, y) =>
            {
                double v = x + y;
                return v;
            };

            Action a1 = () => { Console.WriteLine(""); };

            // 8. Functional arithmetic

            Func<double, double> sn = (x) => Math.Sin(x);
            Func<double, double> wr = (x) => {
                Console.WriteLine(x);
                return x;
            };
            var t = sn + wr;
            var d = t(4);

            //Console.WriteLine(d);

            //Console.WriteLine("---------------------");
            t -= wr;
            d = t(4);
            //Console.WriteLine(d);
            d = wr(sn(4));

            // 9. Linq - language integrated query
            int[] items = new int[] { 1, 2, 3, 11, 20 };

            var buff = new StringBuilder();
            buff.Append("").Append("").ToString();

            int xx = default(int);

            var selected = items
                //.Select(x => x.ToString())
                //.Join()
                //.Where(x => x > 10)
                //.OrderByDescending(x => x)
                //.First()
                .FirstOrDefault(x => x > 10)
                //.ToList()
                ;

            var sql = from i in items
                      where i > 10
                      select i
                      ;

            foreach (var item in sql)
            {
                Console.WriteLine(item);
            }


            //var fb =  an.FirstName;

            

            

            Console.ReadKey();
        }

        class Example
        {
            string[] items = new string[] { "1", "2", "3" };

            public static void Test(Func<double, double> f)
            {
                // TODO
            }
        }


    }
}
