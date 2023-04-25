using System;
using System.Collections.Generic;
using System.Collections;
namespace learn
{
    static class ListStaff
    {
        public static List<Staff> NewListStaff = new List<Staff>();
        public static void Input(ref List<Staff> NewListStaff)
        {
            bool react = true;
            while (react)
            {
                System.Console.WriteLine("Ban co muon nhap thong tin cong nhan khong ");
                System.Console.Write("Chon y de co va n de khong ");
                char? choose = null;
                choose = Convert.ToChar(Console.ReadLine());
                if (choose == 'n')
                {
                    react = false;
                }
                else
                {
                    Staff staff = new Staff();
                    System.Console.Write("Nhap vao ten cua ban ");
                    staff.name = Console.ReadLine();
                    System.Console.Write("Nhap vao tuoi cua ban ");
                    staff.age = Convert.ToInt32(Console.ReadLine());
                    System.Console.Write("Nhap vao id cua ban ");
                    staff.ID = Console.ReadLine();
                    System.Console.Write("Nhap vao GPAm dai hoc cua ban ");
                    staff.gpa = Convert.ToDouble(Console.ReadLine());
                    System.Console.Write("Nhap vao tien luong mot thang cua ban ");
                    staff.money = Convert.ToInt64(Console.ReadLine());
                    NewListStaff.Add(staff);
                }

            }
        }
        public static void Output(List<Staff> NewListStaff)
        {
            foreach (var item in NewListStaff)
            {
                System.Console.WriteLine($"Hello {item.name} you have ${item.money} a month");
            }
        }
        public static void SearchForID(string id, List<Staff> NewListStaff)
        {
            System.Console.WriteLine("Nhap vao id ma ban muon tim ");
            id = Console.ReadLine();
            var item = from staff in NewListStaff
                       where staff.ID == id
                       select staff;
            foreach (var i in item)
            {
                System.Console.WriteLine($"Hello {i.name} you are people choose");
            }
            NewListStaff.TrimExcess();
        }
        //Clear xoA het cac phan tu trong list
        public static SortedList<int, Staff> SortListStaff = new SortedList<int, Staff>();//khai boa sortList int key and value Staff
        public static void SortList(ref SortedList<string, Staff> SortListStaff, List<Staff> NewListStaff)
        {
            //Ne dung SortList<T Key and T value> thay vi sortlist ve cac van de lien quan den hieu suat va sort list cung de bi hong
            //SortLIst sap xep tang dan Key la duy nhat va co the rong gia tri co the la null hoac trung lap
            //Nhanh Hon trong viec truy xuat du lieu va cham hon trong viec chen xoa SortDictinary
            SortListStaff.Add("one", NewListStaff[0]);
            SortListStaff.Add("three", NewListStaff[1]);
            SortListStaff.Add("aplabest", NewListStaff[0]);
            foreach (var item in SortListStaff)
            {
                System.Console.WriteLine("STT: " + item.Key + "Your name " + item.Value.name + "Your Money a month is " + item.Value.money);
            }
            //co the truy cap theo key 
            //Khi cap nhat du lieu neu Key co roi thi cap nhat du lieu con chua co se tao key va gan bien cho key do
            //ContainsKey kiem tra xem da co key do chua neu chua co key thi tra ve false and da co tra ve true
            //Dung count de dem so phan tu giong nhu lengt tring string
            //removekey and removeat(step) xoa 2 vi tri dau tien vi tri 0 va vi tri step
            if (!SortListStaff.ContainsKey("two"))
            {
                SortListStaff.Add("two", NewListStaff[0]);
            }
            System.Console.WriteLine(SortListStaff["two"].name + @"\\\\I leran C# and its is very dificult and very more key");
        }
        public static void Dinctionry(ref Dictionary<string, string> dictionary)
        {
            //kha giong voi sortlist ve cac phuong thuc tuy nhien no se bi loi khi gan gia tri cho mot key ma no chua duoc dinh nghia
            //key co the string no k sap xep theo key giong trong sortLists
        }
        public static void Hastable(ref Hashtable hashtable, ref Dictionary<string, string> dictionary)
        {
            //Hastable bang bam
            //luu tru kha giong dictionary and sortlist deu co key duy nhat va mot value tuong ung
            //co the bao gom tat ca phan tu cua Dictionary
            hashtable = new Hashtable(dictionary);
        }
        public static void stacK(Stack<int> stack, int[] array)
        {
            //stack ngan xep push pop
            // co the tao ngan xep tu mang
            stack = new Stack<int>(array);
            //coutn dem phan tu
            //Peek return top stack
            //Contains check value tra ve true neu co trong stack and false neu k co trong stack and clear
        }
        public static void queue(ref Queue<int> queuE, int[] array)
        {
            //queue enqueun and dequeun
            //Peek tra ve fist queeu
            //Khong ho tro tri muc giong stack 
            queuE = new Queue<int>(array);
        }
    }
}