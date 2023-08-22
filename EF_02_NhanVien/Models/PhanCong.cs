using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Models
{
    public class PhanCong
    {
        public int PhanCongId { get; set; }
        public int SoGioLam { get; set; }
        public int NhanVienId { get; set; }
        public NhanVien nhanVien { get; set; }
        public int DuAnId { get; set; }
        public DuAn duAn { get; set; }
    }
}
