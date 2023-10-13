using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYSANPHAM.EF;

namespace QUANLYSANPHAM.Model
{
    public class DANHMUC
    {
        QLSPEntities db = new QLSPEntities();
        public List<tbl_DanhMuc> getList()
        {
            return db.tbl_DanhMuc.ToList();
        }
    }
}
