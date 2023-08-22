using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Models
{
    public class DuAn
    {
        public int DuAnId { get; set; }
        public string TenDuAn { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }

        public List<PhanCong> ListPhanCong { get; set; }
    }
}
