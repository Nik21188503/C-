using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    internal class Studen:People
    {
        public double gpa;
        public Studen(string aName,int aAge,string Id,double aGpa):base(aName,aAge,Id)=>this.gpa = aGpa;
        public Studen() { }
        public override void Say()
        {
            base.Say();
            Console.WriteLine("And I have Gpa I was gpa 2.5");
        }
    }
    //intsrface class phuong thuc co so dc dinh nghia o lop con
}
