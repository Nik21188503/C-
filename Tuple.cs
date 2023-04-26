using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace learn
{
    class MTuple
    {
        //Tuple co the co toi da tam phan tu
        //truy cap bang Item<index> and with phan tu thu 8 dung Rest
        //Co the long du lieu de co the luu tru nhieu hon 8 phan tu ta long vao phan tu thu 8 rest truy cap rest.Item
        public void MYTUPLE()
        {
            var people = Tuple.Create("Le Khac Ninh", 20, 18, "2151062844", 3.2, 200, "N", Tuple.Create("12A3", "12A6", "63CNTT3", "ThuyLoi university"));
            System.Console.WriteLine("My name is " + people.Item1);
            System.Console.WriteLine($"I was learn at {people.Rest.Item1.Item1} and {people.Rest.Item1.Item2} and now i learn at {people.Rest.Item1.Item4} and my class is {people.Rest.Item1.Item3}");
            // have return nhieu gia tri
            //Truyen nhieu gia tri qua mot funtion
            //tam luu ban ghi co so du lieu hoac gia tri k can tao lop rieng
        }
        public Tuple<string, int> MyTupLE()
        {
            return Tuple.Create("Le Khac Ninh", 20);
        }

    }
}