using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Models
{
    public class NhanVien
    {
        public int NhanVienId { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public double HeSoLuong { get; set; }

        public List<PhanCong> ListPhanCong { get; set; }
    }
}
