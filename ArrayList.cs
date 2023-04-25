using System;
using System.Collections;
using System.Collections.Generic;
namespace learn
{
    //K nen su dung ararylist vi no la tap cac doi tuong k dong nhat anh huong den hieu suat
    class NArrayList
    {
        public void ArryListN()
        {
            var arrayList = new ArrayList();
            arrayList.Add("Le Khac Ninh");
            arrayList.Add(21);
            string name = "Le Khac Ninh";
            int age = 20;
            var quen = new Queue();
            quen.Enqueue("12A6");
            quen.Enqueue("12A3");
            arrayList.AddRange(quen);
            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item);
            }
            //contanis tra ve xem co nam trong arraylist k tra ve true neu co va false neu k co
            System.Console.WriteLine(arrayList.Contains(name));
            System.Console.WriteLine(arrayList.Contains(age));

        }
    }
    class aList
    {
        //list<=> arraylist trong sytem.coletion.genric hieu suat nhanh hon so voi arraylist co cau truc truy van linq
        public void anList()
        {
            List<int> MyList = new List<int>();
            List<Studen> mListStuden = new List<Studen>
            {
                new Studen ("Le Khac Ninh",20,"2151062844",3.2),
                new Studen ("Le Khac Nam",23,"21578932",3.5),
                new Studen ("Le Khac Ninh",23,"21578932",3.5)
            };
            var releture = from item in mListStuden
                           where item.name == "Le Khac Ninh"
                           select item;
            foreach (var item in releture)
            {
                System.Console.WriteLine(item.name + " " + item.gpa);
            }
        }
    }
}