using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day2_programs
{
    public class UGstudent
    {
        public string Name { get; set; }
        public int RollNo { get; set; } // Fix: Corrected property name to match the type signature

    }
    public class ListingSamples
    {
        public void SampleMethod()
        {
            List<UGstudent> students = new List<UGstudent>
                {
                    new UGstudent() { Name = "Anu", RollNo = 1 }, // Fix: Corrected property name to match the type signature
                    new UGstudent() { Name = "Bhanu", RollNo = 2 }, // Fix: Corrected property name to match the type signature
                    new UGstudent() { Name = "Chinnu", RollNo = 3 }, // Fix: Corrected property name to match the type signature
                    new UGstudent() { Name = "Dinu", RollNo = 4 }, // Fix: Corrected property name to match the type signature
                    new UGstudent() { Name = "Esw", RollNo = 5 } // Fix: Corrected property name to match the type signature
                };

            var filterNames = from student in students
                              where student.RollNo >= 3 // Fix: Corrected property name to match the type signature
                              select student.Name;

            foreach (var name in filterNames)
            {
                Console.WriteLine(name);
            }
        }
    }


    }
}
