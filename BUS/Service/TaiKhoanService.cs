
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class TaiKhoanService
    {
        TaiKhoanrepos _repos = new TaiKhoanrepos();
        public TaiKhoanService()
        {
            
        }

        public TaiKhoanService(TaiKhoanrepos repos)
        {
            _repos = repos;
        }
        public List<Taikhoan> GetAll()
        {
        return _repos.Getall().ToList();
        }
        public Taikhoan GetByUserandPasswoss(string user, string Passwoss)
        {
            return _repos.GetByUserandPasswoss(user, Passwoss);
        }

    }
}
