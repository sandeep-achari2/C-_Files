using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_programs
{
    public class Maths
    {
        /*public int Add(int a,int b)
        {
            return a + b;
        }
        public int Add(int a, int b,int c)
        {
            return a+b+c;
        }
        public int Add(int a,int b, float c)
        {
            return a + b + (int)c;
        }*/
        public virtual string display()
        {
            return "Iam a parent class";
        }
    }
    public class Algebra : Maths
    {
        //public string display()
        //{
        //    return "Iam a child class";
        //}
        public override string display()//
        {
            return "Iam a child override";
        }
    }
}
