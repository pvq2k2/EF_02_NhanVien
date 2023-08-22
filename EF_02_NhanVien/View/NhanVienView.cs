using EF_02_NhanVien.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.View
{
    public class NhanVienView
    {
        NhanVienController controller;

        public NhanVienView()
        {
            controller = new NhanVienController();
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------Menu----------");
                Console.WriteLine("1. Them mot nhan vien vao du an");
                Console.WriteLine("2. Sua thong tin du an");
                Console.WriteLine("3. Xoa nhan vien");
                Console.WriteLine("4. Tinh luong cac nhan vien");
                Console.WriteLine("5. Thoat");
                Console.Write("Chon chuc nang: ");
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                controller.ThucThi(c);
            }
        }
    }
}
