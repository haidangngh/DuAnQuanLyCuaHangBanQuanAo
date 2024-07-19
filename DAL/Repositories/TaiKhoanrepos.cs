using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TaiKhoanrepos : ITaiKhoanrepos
    {
        DUAN1_QL_BANQUANAOContext _dbcontext;
        public TaiKhoanrepos()
        {
            
        }
        public TaiKhoanrepos(DUAN1_QL_BANQUANAOContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public List<Taikhoan> Getall()
        {
            List<Taikhoan> taikhoanslist = _dbcontext.Taikhoans.ToList();
            return taikhoanslist;
        }

        public Taikhoan GetByUserandPasswoss(string user, string Passwoss)
        {
            Taikhoan taikhoan = _dbcontext.Taikhoans.FirstOrDefault(t => t.TenDangNhap == user && t.MatKhau == Passwoss);
            return taikhoan;
        }
    }
}
