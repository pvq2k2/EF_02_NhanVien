using EF_02_NhanVien.Helper;
using EF_02_NhanVien.IServices;
using EF_02_NhanVien.Models;
using EF_02_NhanVien.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Services
{
    public class NhanVienServices : INhanVienServices
    {
        private readonly AppDbContext dbContext;

        public NhanVienServices()
        {
            dbContext = new AppDbContext();
        }

        public LogType SuaThongTinDuAn(int DuAnId)
        {
            var FindDuAn = dbContext.DuAn.FirstOrDefault(x => x.DuAnId == DuAnId);
            if (FindDuAn == null) return LogType.KhongTimThayDuAn;
            DuAn duAn = new DuAn();
            duAn.TenDuAn = InputHelper.InputString(NhanVienRes.TenDuAn, NhanVienRes.ErrDoDaiTenDuAn, maxValue: 10);
            duAn.MoTa = InputHelper.InputString(NhanVienRes.MoTa);
            duAn.GhiChu = InputHelper.InputString(NhanVienRes.GhiChu);

            FindDuAn.TenDuAn = duAn.TenDuAn;
            FindDuAn.MoTa = duAn.MoTa;
            FindDuAn.GhiChu = duAn.GhiChu;
            dbContext.DuAn.Update(FindDuAn);
            dbContext.SaveChanges();

            return LogType.ThanhCong;

        }

        public LogType ThemNhanVienVaoDuAn(int NhanVienId, int DuAnId)
        {
            var FindNhanVien = dbContext.NhanVien.FirstOrDefault(x => x.NhanVienId == NhanVienId);
            var FindDuAn = dbContext.DuAn.FirstOrDefault(x => x.DuAnId == DuAnId);

            if (FindNhanVien == null) return LogType.KhongTimThayNhanVien;
            if (FindDuAn == null) return LogType.KhongTimThayDuAn;

            InputHelper.KiemTraNhanVien(FindNhanVien);
            if (FindDuAn.TenDuAn.Length > 10) return LogType.ErrDoDaiTenDuAn;

            PhanCong phanCong = new PhanCong();
            phanCong.NhanVienId = NhanVienId;
            phanCong.DuAnId = DuAnId;
            phanCong.SoGioLam = InputHelper.InputInt(NhanVienRes.SoGioLam, NhanVienRes.ErrSoGioLam, 0);

            if (phanCong.SoGioLam < 0) return LogType.ErrSoGioLam; 

            dbContext.PhanCong.Add(phanCong);
            dbContext.SaveChanges();
            return LogType.ThanhCong;
        }

        public LogType TinhLuong()
        {
            var ListNhanVien = dbContext.NhanVien.Include(x => x.ListPhanCong).ToList();
            if (ListNhanVien.Count == 0) return LogType.DanhSachTrong;
            ListNhanVien.ForEach (nhanVien =>
            {
                double LuongNhanNien = 0;
                nhanVien.ListPhanCong.ForEach (phanCong =>
                {
                    LuongNhanNien += nhanVien.HeSoLuong * 15 * phanCong.SoGioLam;
                }) ;
                Console.WriteLine($"Nhan vien co id: {nhanVien.NhanVienId} co luong la: {LuongNhanNien}");
            });
            return LogType.ThanhCong;
        }

        public LogType XoaNhanVien(int NhanVienId)
        {
            var FindNhanVien = dbContext.NhanVien.FirstOrDefault(x => x.NhanVienId == NhanVienId);
            if (FindNhanVien == null) return LogType.KhongTimThayNhanVien;

            dbContext.NhanVien.Remove(FindNhanVien);
            dbContext.SaveChanges();
            Console.WriteLine($"Da xoa nhan vien co ten '{FindNhanVien.HoTen}' co id la {FindNhanVien.NhanVienId}");

            return LogType.ThanhCong;
        }
    }
}
