using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    internal class Staff:Studen
    {
        public long money;
        public Staff(string aName, int aAge, string Id, double Gpa, long aMoney) : base(aName, aAge, Id, Gpa)=>this.money = aMoney;
        public Staff() { }
    }
}
