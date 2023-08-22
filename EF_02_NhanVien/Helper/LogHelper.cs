using EF_02_NhanVien.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Helper
{
    public enum LogType
    {
        ThanhCong,
        ErrDoDaiTen,
        ErrDoDaiTenDuAn,
        ErrSoTu,
        ErrNgaySinh,
        ErrSoGioLam,
        KhongTimThayDuAn,
        KhongTimThayNhanVien,
        DanhSachTrong,
        Pass
    }
    public class LogHelper
    {
        public static void NhanVienLog(LogType log)
        {
            switch (log)
            {
                case LogType.ThanhCong:
                    Console.WriteLine(NhanVienRes.ThanhCong);
                    break;
                case LogType.ErrDoDaiTen:
                    Console.WriteLine(NhanVienRes.ErrDoDaiTen);
                    break;
                case LogType.ErrDoDaiTenDuAn:
                    Console.WriteLine(NhanVienRes.ErrDoDaiTenDuAn);
                    break;
                case LogType.ErrSoTu:
                    Console.WriteLine(NhanVienRes.ErrSoTu);
                    break;
                case LogType.ErrNgaySinh:
                    Console.WriteLine(NhanVienRes.ErrNgaySinh);
                    break;
                case LogType.ErrSoGioLam:
                    Console.WriteLine(NhanVienRes.ErrSoGioLam);
                    break;
                case LogType.KhongTimThayDuAn:
                    Console.WriteLine(NhanVienRes.KhongTimThayDuAn);
                    break;
                case LogType.KhongTimThayNhanVien:
                    Console.WriteLine(NhanVienRes.KhongTimThayNhanVien);
                    break;
                case LogType.DanhSachTrong:
                    Console.WriteLine(NhanVienRes.DanhSachTrong);
                    break;
            }
        }
    }
}
