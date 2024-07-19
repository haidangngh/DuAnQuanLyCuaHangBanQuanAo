using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Salesanpham
    {
        public string MaSale { get; set; } = null!;
        public string GiaTri { get; set; } = null!;
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string MoTa { get; set; } = null!;
    }
}
