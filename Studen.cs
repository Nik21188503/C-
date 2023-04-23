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
    }
}
