using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class Japan : Form
    {
        public Japan()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainUC1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(japanUC1);
            bunifuTransition1.ShowSync(firstUC1);
        }



        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(firstUC1);
            bunifuTransition1.ShowSync(japanUC1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기

            Second frm = new Second(); // 새 폼 생성

            frm.Owner = this; // 새 폼의 오너를 현재 폼으로

            frm.Show(); // 새폼 보여 주 기
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
