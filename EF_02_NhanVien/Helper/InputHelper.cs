using EF_02_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Helper
{
    public class InputHelper
    {
        public static LogType KiemTraNhanVien(NhanVien nhanVien) 
        { 
            if (nhanVien.HoTen.Length > 20) return LogType.ErrDoDaiTen;
            if (nhanVien.HoTen.Split("").Length < 2) return LogType.ErrSoTu;
            if (nhanVien.NgaySinh.Year < 1970 && nhanVien.NgaySinh.Year > 2000) return LogType.ErrNgaySinh;
            return LogType.Pass;
        }

        public static int InputInt(string message, string error, int minValue = int.MinValue, int maxValue = int.MaxValue, string errorValue = "")
        {
            string num;
            bool isNum;
            int numResult;
            do
            {
                Console.Write(message);
                num = Console.ReadLine();
                isNum = int.TryParse(num, out numResult);
                if (!isNum)
                {
                    Console.WriteLine(error);
                }
                else if (numResult < minValue && numResult > maxValue)
                {
                    Console.WriteLine(errorValue);
                }
            } while (!isNum);

            return numResult;
        }

        public static string InputString(string message, string error = "", int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            string str;
            bool isValid = false;
            do
            {
                Console.Write(message);
                str = Console.ReadLine();
                if (str.Length < minValue || str.Length > maxValue)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            return str;
        }
    }
}
