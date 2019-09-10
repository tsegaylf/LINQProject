using System;
using System.Linq;
using CSharp2SqlLibrary;

namespace LINQProject {

    class Program {
        void Run() {

            var Connection = new Connection(@"localhost\\sqlexpress", "PrsDB");

        }

        static void Main(string[] args) {
            var pgm = new Program();
                pgm.Run();



            //int[] ints = { 2, 4, 6, 8, 7, 5, 3, 1 };

            //var ascInts = (from i in ints // can't do AVG with the Querey syntax, you will need a mathod syntax
            //               where i % 2 == 1 && i < 7
            //               orderby i descending
            //               select i);

            //var avg = ascInts.Average(i => i);
            //Console.WriteLine($"Average of odds less that 7 is {avg}");

            //foreach (var i in ascInts) {
            //    Console.WriteLine($"{i}");
            //}

        }
    }
}
