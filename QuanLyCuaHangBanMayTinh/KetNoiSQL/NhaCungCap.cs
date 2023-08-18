using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanMayTinh.KetNoiSQL
{
    class NhaCungCap
    {
        LopDungChung lopchung = new LopDungChung();

        public int Themncc(string mancc, string tenncc)
        {

            string sql = "Insert into NHACUNGCAP values(N'" + mancc + "',N'" + tenncc + "')";
            return lopchung.ThemXoaSua(sql);
        }

        public int Suancc(string mancc, string tenncc)
        {
            string sql = "Update NHACUNGCAP set TENNCC =N'" + tenncc + "'where MANCC = '" + mancc + "'";
            return lopchung.ThemXoaSua(sql);
        }

        public int Xoancc(string mancc)
        {
            string sql = "Delete NHACUNGCAP where MANCC = N'" + mancc + "'";
            return lopchung.ThemXoaSua(sql);

        }

        public DataTable Loadncc()
        {
            string sql = "Select * from NHACUNGCAP";
            return lopchung.LoadDuLieu(sql);
        }
    }
}
