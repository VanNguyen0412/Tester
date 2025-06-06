using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTPM_BaiTapLon;

namespace KTPM_BaiTapLon
{
    public partial class NUnit : Form
    {
        public NUnit()
        {
            InitializeComponent();
        }
        TinhToanVoiTamGiac tinh = new TinhToanVoiTamGiac();
        private void btnKTra_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            double c = double.Parse(txtSo3.Text);
           
            string triangleType = tinh.DetermineTriangleType(a, b, c);
            txtKTra.Text = triangleType;
            
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            double c = double.Parse(txtSo3.Text);
            string area = tinh.CalculateArea(a, b, c);
            txtDienTich.Text = area;
           
        }
    }
}
