using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class tinhTong : Form
    {
        public tinhTong()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(soA.Text);
            double b = Double.Parse(soB.Text);
            double tong = a + b;
            txtTong.Text = "" + tong;
        }
    }
}