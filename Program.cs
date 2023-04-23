using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LearnArray();
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
    }
}