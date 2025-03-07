using System.Diagnostics;

using Day2_programs;

namespace Day2_programs
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    //Maths obj1 = new Maths();
        //    //Console.WriteLine(obj1.display());  // Calls the base class method

        //    //Algebra obj2 = new Algebra();
        //    //Console.WriteLine(obj2.display());  // Calls the overridden method in the child class

        //    //Maths obj3 = new Algebra();
        //    //Console.WriteLine(obj3.display());  // Runtime polymorphism: Calls the overridden method in the child class

        //    //Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    BankAccount obj = new BankAccount();
        //    obj.AccountId = "1234567890";
        //    Console.WriteLine(obj.AccountId);
        //    obj.AccountId = "123456789";
        //    Console.WriteLine(obj.AccountId);
        //}

        //code to get the list of processes running in the system

        //static void Main(String[] args)
        //{
        //    var pros = from p in Process.GetProcesses()
        //               select new { p.ProcessName, p.WorkingSet64 };
        //    foreach (var pro in pros)
        //    {
        //        Console.WriteLine(pro.ProcessName);
        //    }
        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            ListingSamples listingSamples = new ListingSamples();
            listingSamples.SampleMethod();
        }

    }
}
