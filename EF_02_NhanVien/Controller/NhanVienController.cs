using EF_02_NhanVien.Helper;
using EF_02_NhanVien.Resources;
using EF_02_NhanVien.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Controller
{
    public class NhanVienController
    {
        NhanVienServices services;

        public NhanVienController()
        {
            services = new NhanVienServices();
        }

        public void ThucThi(char c)
        {
            switch (c)
            {
                case '1':
                    int NhanVienID_Add = InputHelper.InputInt(NhanVienRes.NhanVienId, NhanVienRes.ErrID);
                    int DuAnID_Add = InputHelper.InputInt(NhanVienRes.DuAnId, NhanVienRes.ErrID);
                    LogHelper.NhanVienLog(services.ThemNhanVienVaoDuAn(NhanVienID_Add, DuAnID_Add));
                    break;
                case '2':
                    int DuAnID_Update = InputHelper.InputInt(NhanVienRes.DuAnId, NhanVienRes.ErrID);
                    LogHelper.NhanVienLog(services.SuaThongTinDuAn(DuAnID_Update));
                    break;
                case '3':
                    int NhanVienID_Remove = InputHelper.InputInt(NhanVienRes.NhanVienId, NhanVienRes.ErrID);
                    LogHelper.NhanVienLog(services.XoaNhanVien(NhanVienID_Remove));
                    break;
                case '4':
                    LogHelper.NhanVienLog(services.TinhLuong());
                    break;
                case '5':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Khong co chuc nang nay, vui long nhap lai!");
                    break;
            }
            Console.WriteLine("\nNhan phim bat ky de tiep tuc!");
            Console.ReadKey();
        }
    }
}
