using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
namespace learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LearnArray();
            //ForegroundColor som mau reset
            Console.ForegroundColor = ConsoleColor.Blue;

            //var SNinh = new Studen("Le Khac Ninh", 20, "2151062844", 2.8);
            //Console.WriteLine(SNinh.gpa);
            //LearnString();
            //sealed k cho lop con ke thua 
            //Console.WriteLine(Intro.plus);
            /*Staff staff = new Staff("Le Khac Nam",23,"0123456789",3.4,300);
            Console.WriteLine(staff.money+"$");
            int a = 5;
            int b = 18;
            SwapGenericTemplate<int>(ref a, ref b);
            Console.WriteLine(a);*/
            //AnonymousType();

            /*int? age;
            age = null;
            //hasvalue kiem tra xem du lieu co bang null neu null tra ve false va neu k null tra ve true
            if (age.HasValue)
            {
                Console.WriteLine("Not Null");
            }
            else
            {
                Console.WriteLine("null");
            }
            Console.WriteLine(age);*/
            Studen studen = new Studen();
            studen.Say();

        }

        static void LearnArray()
        {
            int[] array = { 1, 2, 5, 4 };
            int[] cpArray=new int[array.Length];

            //method in arry have sum min max binarysearch sort revers ...copyto...
            Console.WriteLine(array.Sum());
            Console.WriteLine(Array.BinarySearch(array,1));
            array.CopyTo(cpArray,0);
            foreach(int i in cpArray)
            {
                Console.WriteLine(i);
            }
            Array.Sort(array);
            Array.Reverse(array);
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
        static void LearnString()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string name = "Lê Khắc Ninh";
            string myClass = "12A3";
            string[] MyFavoriteColor = { "Light Blue", " Biques", "Orange" };
            //path
            Console.WriteLine(@$"User\{name}\Desktop\LearnCShape");
            //Concat simpe + string
            Console.WriteLine(String.Concat($" Hello My name is {name} and I have learn {myClass}"));
            //indexof di xuoi
            Console.WriteLine($"Vi tri dau tien cua chu N trong ten la {name.IndexOf("N")}");
            //lastindexof di nguoc
            Console.WriteLine($"Vi tri cuoi cung cua chu \" \" trong ten la {name.LastIndexOf(" ")}");
            //Insert chen
            Console.WriteLine("Hello this is Insert on String" + name.Insert(name.Length, myClass));
            //Pad chen ki tu vao hai dau
            var PadLeft = name.PadLeft(20, '*');
            Console.WriteLine(PadLeft);
            //Replace
            Console.WriteLine("I have brothes and your name is {0}", name.Replace("Ninh", "Nam"));
            //Split tach chuoi thanh mang
            var StringName = name.Split(' ');
            foreach (var strName in StringName)
            {
                Console.WriteLine(strName);
            }
            //tolower to upper viet hoa va viet thuong remove
            //Trim cat bo hai dau ki tu
            Console.WriteLine("This is trim: "+PadLeft.Trim('*'));
            //substring cat chuoi 
            Console.WriteLine("Ten dem cua toi: " + name.Substring(name.IndexOf(' ') + 1, name.LastIndexOf(' ') - name.IndexOf(' ') - 1));
            //Joiin
            Console.WriteLine("My favorite color is: "+String.Join(" ",MyFavoriteColor));
            //worker with stringbulilder vs string binh thuong khi ta thay doi thanh chuoi khac thi ram no se cap phap bo nho moi cho chuoi lam cho hieu suat co the kem di con stringbulder thi ram k can cap phat bo nho ma viet tiep vao cho den khi day se cap phat bo nho moi
            StringBuilder stringBuil=   new StringBuilder(50);
            for(int i = 0; i < 1000; i++)
            {
                stringBuil.Append(i);
            }
            Console.WriteLine($"lenght stringbuilder is:{stringBuil.Length}");
            stringBuil.Remove(0, stringBuil.Length);
            Console.WriteLine("My name is "+stringBuil.Append("Le Khac Ninh").ToString());

        }
        //ref <=> & c++ lam bien tham tti
        //Generic or Template co the co 1 option hoac nnhieu option apple or class
        static void SwapGenericTemplate<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a=b; b=temp;
        }
        //kieu vo danh
        static void AnonymousType()
        {
            var obj = new
            {
                name="Le Khac Ninh",
                age = 20,
                nowMyClass = "63CNTT3",
                Say ="Hello World",

            };
            Console.WriteLine(obj.Say+" by "+obj.name);

        }

    }
}