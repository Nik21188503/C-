using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    //internal truy cap noi bo
    // class
    class People
    {
        public  string name;
        public int age;
        private string id;
        //Khoi tao hai tham so
        public People(string nName,int aAge, string Id)
        {
            this.name = nName;
            this.age = aAge;
            ID = Id;
        }
        //Khoi tao khong tham so
        public People() { }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public virtual void Say() {
            Console.WriteLine("I have simple people have name have age and id");
        }
    }
}
