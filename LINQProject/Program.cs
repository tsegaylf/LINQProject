using System;
using System.Linq;
using CSharp2SqlLibrary;
using LINQProject;

namespace LINQProject {

    class Program {

        void Run() {

            var Connection = new Connection("localhost\\sqlexpress", "PrsDB");
            Connection.Open();
            //Users.Connection = Connection;
            //Vendors.Connection = Connection;
            Products.Connection = Connection;

            #region Syntax Examples 
            //var reviewer = from u in Users.GetAll()
            //               where u.IsReviewer
            //               select u;

            //var admins = from u in Users.GetAll()
            //             where u.IsAdmin
            //             select u;
            //foreach (var user in admins) {
            //Console.WriteLine($"{user.FirstName} {user.LastName} is admin");

            //var usr = from u in Users.GetAll()
            //          where u.Username.StartsWith("ABC")
            //          //where u.Username.Equals("John1234") // checking equality between strings 
            //          select u;

            //var total = (from p in Products.GetAll()
            //             select p).Sum(u => u.Price);

            //Console.WriteLine($"The total of all is {total}");


            //var products = from p in Products.GetAll()
            //               join v in Vendors.GetAll()
            //               on p.VendorID equals v.ID
            //               select new {
            //                   Product = p.Name,
            //                   Vendor = v.Name,
            //                   Price = p.Price
            //               };
            //foreach (var p in products) {
            //    Console.WriteLine($"{p.Product} is priced at {p.Price} from {p.Vendor}");
            //}

            #endregion


            var products = Products.GetAll();
            products.Print();

            Connection.Close();
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
