using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ITaiKhoanrepos
    {
        public List<Taikhoan> Getall();
        public Taikhoan GetByUserandPasswoss(string user, string Passwoss);
    }
}
