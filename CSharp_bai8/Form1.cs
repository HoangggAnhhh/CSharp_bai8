using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string can, chi;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(txtDuongLich.Text.Substring(3, 1)))
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
                    can = "Quý";
                    break;
                case 4:
                    can = "giáp";
                    break;
                case 5:
                    can = "ất";
                    break;
                case 6:
                    can = "bính";
                    break;
                case 7:
                    can = "đinh";
                    break;
                case 8:
                    can = "mậu";
                    break;
                case 9:
                    can = "kỷ";
                    break;
            }
            switch (Convert.ToInt32(txtDuongLich.Text) % 12)
            {
                case 0:
                    chi = "thân";
                    break;
                case 1:
                    chi = "dậu";
                    break;
                case 2:
                    chi = "tuất";
                    break;
                case 3:
                    chi = "hợi";
                    break;
                case 4:
                    chi = "tý";
                    break;
                case 5:
                    chi = "sửu";
                    break;
                case 6:
                    chi = "dần";
                    break;
                case 7:
                    chi = "mão";
                    break;
                case 8:
                    chi = "thìn";
                    break;
                case 9:
                    chi = "tỵ";
                    break;
                case 10:
                    chi = "ngọ";
                    break;
                case 11:
                    chi = "mùi";
                    break;
            }
            txtAmLich.Text = can + " " + chi;

        }
    }
}