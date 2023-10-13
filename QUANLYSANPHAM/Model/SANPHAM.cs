using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYSANPHAM.EF;

namespace QUANLYSANPHAM.Model
{
    public class SANPHAM
    {
        QLSPEntities db = new QLSPEntities();
        public tbl_SanPham getItem(int id)
        {
            return db.tbl_SanPham.FirstOrDefault(x=>x.ID == id);
        }

        public List<tbl_SanPham> getList()
        {
            return db.tbl_SanPham.ToList();
        }

        public tbl_SanPham add(tbl_SanPham sp1)
        {
            try
            {
                db.tbl_SanPham.Add(sp1);
                db.SaveChanges();
                return sp1;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu!" + ex.Message);
            }
        }

        public tbl_SanPham update(tbl_SanPham sp1)
        {
            try
            {
                var sp2 = db.tbl_SanPham.FirstOrDefault(x => x.ID == sp1.ID);
                sp2.TenSP = sp1.TenSP;
                sp2.GiaSP = sp1.GiaSP;
                sp2.NgaySX = sp1.NgaySX;
                sp2.Soluong = sp1.Soluong;
                db.SaveChanges();
                return sp1;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu!" + ex.Message);
            }
        }
         
        public tbl_SanPham delete(int id)
        {
            try
            {
                var sp2 = db.tbl_SanPham.FirstOrDefault(x=>x.ID == id);
                db.tbl_SanPham.Remove(sp2);
                return sp2;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu!" + ex.Message);
            }
        }
    }
}
