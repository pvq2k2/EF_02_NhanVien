using EF_02_NhanVien.Helper;
using EF_02_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.IServices
{
    public interface INhanVienServices
    {
        LogType ThemNhanVienVaoDuAn(int NhanVienId, int DuAnId);
        LogType SuaThongTinDuAn(int DuAnId);
        LogType XoaNhanVien(int NhanVienId);
        LogType TinhLuong();
    }
}
