using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Demo
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (ckbTinHocA.Checked)
                s += int.Parse(lblTienTHA.Text.Split('.')[0]);
            if (ckbTinHocB.Checked)
                s += int.Parse(lblTienTHB.Text.Split('.')[0]);
            if (ckbTiengAnhA.Checked)
                s += int.Parse(lblTienTAA.Text.Split('.')[0]);
            if (ckbTiengAnhB.Checked)
                s += int.Parse(lblTienTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 dồng";
        }
        private void Reset()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.ckbTinHocA.Checked = false;
            this.ckbTinHocB.Checked = false;
            this.ckbTiengAnhA.Checked = false;
            this.ckbTiengAnhB.Checked = false;
            this.txtTongTien.Text = "";
        }
    }
}
