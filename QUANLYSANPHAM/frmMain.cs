using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYSANPHAM.EF;
using QUANLYSANPHAM.Model;

namespace QUANLYSANPHAM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool them;
        SANPHAM sanpham;
        DANHMUC danhmuc;

        public void erable()
        {
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
        }

        public void unerable()
        {
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (them)
            {
                tbl_SanPham sp1 = new tbl_SanPham();
                sp1.TenSP = txtTenSP.Text;
                sp1.GiaSP = int.Parse(txtGiaSP.Text);
                sp1.NgaySX = dtNgaysx.Value;
                sp1.Soluong = int.Parse(txtSoluong.Text);
                sp1.IDDM = int.Parse(cboDanhmuc.SelectedValue.ToString());
                sanpham.add(sp1 );
            }
            else
            {
                int selectID = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                tbl_SanPham sp1 = sanpham.getItem(selectID);
                sp1.TenSP = txtTenSP.Text;
                sp1.GiaSP = int.Parse(txtGiaSP.Text);
                sp1.NgaySX = dtNgaysx.Value;
                sp1.Soluong = int.Parse(txtSoluong.Text);
                sp1.IDDM = int.Parse(cboDanhmuc.SelectedValue.ToString());
                sanpham.update(sp1);
            }
            them = true;
            unerable();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            unerable();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            erable();
            them = false;
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            erable();
            them = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            danhmuc = new DANHMUC();
            sanpham = new SANPHAM();
            erable();

            cboDanhmuc.DataSource = danhmuc.getList();
            cboDanhmuc.DisplayMember = "TenDM";
            cboDanhmuc.ValueMember = "IDDM";
            LoadData();
        }

        public void LoadData()
        {
            List<tbl_SanPham> selectList = sanpham.getList();
            dataGridView1.DataSource = selectList;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
