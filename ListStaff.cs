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
        public static void SearchForID(string id, ref List<Staff> NewListStaff)
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
            NewListStaff.Clear();
        }
    }
}