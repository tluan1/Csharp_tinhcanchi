using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tinhcanchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 2000; i <= 2050; i++)
            {
                lbs.Items.Add(i.Tostring() + lblnam.ToString());
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            string chi = " ", can = " ";
            switch (Convert.ToInt32(txtnam.Text) % 12)
            {
                case 0:
                    chi = "Thân";
                    break;
                case 1:
                    chi = "Dậu";
                    break;
                case 2:
                    chi = "Tuất";
                    break;
                case 3:
                    chi = "Hợi";
                    break;
                case 4:
                    chi = "Tý";
                    break;
                case 5:
                    chi = "Sửu";
                    break;
                case 6:
                    chi = "Dần";
                    break;
                case 7:
                    chi = "Mão";
                    break;
                case 8:
                    chi = "Thìn";
                    break;
                case 9:
                    chi = "Tỵ";
                    break;
                case 10:
                    chi = "Ngọ";
                    break;
                case 11:
                    chi = "Mùi";
                    break;
            }
            switch (Convert.ToInt32(txtnam.Text) % 10)
            {
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can = "Tân";
                    break;
                case 2:
                    can = "Nhâm";
                    break;
                case 3:
                    can = "Qúy";
                    break;
                case 4:
                    can = "Gíap";
                    break;
                case 5:
                    can = "Ất";
                    break;
                case 6:
                    can = "Bính";
                    break;
                case 7:
                    can = "Đinh";
                    break;
                case 8:
                    can = "Mậu";
                    break;
                case 9:
                    can = "Kỷ";
                    break;
            }
            txtketqua.Text = can + " " + chi;
            for (int txtnam = 2000; txtnam <= 2050; txtnam++)
            {
                int indexcan = txtnam % 10;
                int indexchi = txtnam % 12;
            }
        }
    }
}
