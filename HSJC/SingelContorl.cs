using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSJC
{
    public partial class SingelContorl : Form
    {
        public SingelContorl()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)  //W轴伺服
        {
            if(button9.Text == "开伺服")
            {
                Commondata.GalilControler.GCommand("SHW");
                button9.Text = "关伺服";
                button7.Enabled = true;
                button8.Enabled = true;
            }
            else
            {
                Commondata.GalilControler.GCommand("STW");
                Thread.Sleep(500);
                Commondata.GalilControler.GCommand("MOW");
                button9.Text = "开伺服";
                button7.Enabled = false;
                button8.Enabled = false;
            }

        }

        private void button8_Click(object sender, EventArgs e)   //W轴反转
        {
            string NowPosition = Commondata.GalilControler.GCommand("TPW");
            decimal NewPosition;
            NewPosition = Convert.ToDecimal(NowPosition) - (8192 * numericUpDown3.Value);
            string com = "#A\nPAW = " + NewPosition + "\nSPW = 20000\nBGW";
            Commondata.GalilControler.GProgramDownload(com);
            Commondata.GalilControler.GProgramUpload();
            Commondata.GalilControler.GCommand("XQ#A");
        }

        private void SingelContorl_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)   //W轴正转
        {
            string NowPosition = Commondata.GalilControler.GCommand("TPW");
            decimal NewPosition;
            NewPosition = Convert.ToDecimal(NowPosition) + (8192 * numericUpDown3.Value);
            string com = "#A\nPAW = " + NewPosition + "\nSPW = 20000\nBGW";
            Commondata.GalilControler.GProgramDownload(com);
            Commondata.GalilControler.GProgramUpload();
            Commondata.GalilControler.GCommand("XQ#A");
        }

        private void button1_Click(object sender, EventArgs e)  //Y轴伺服
        {
            if (button1.Text == "开伺服")
            {
                Commondata.GalilControler.GCommand("SHY");
                button1.Text = "关伺服";
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                Commondata.GalilControler.GCommand("STY");
                Thread.Sleep(500);
                Commondata.GalilControler.GCommand("MOY");
                button1.Text = "开伺服";
                button2.Enabled = false;
                button3.Enabled = false;
            }

        }

        private void button6_Click(object sender, EventArgs e)  //Z轴伺服
        {
            if (button6.Text == "开伺服")
            {
                Commondata.GalilControler.GCommand("SHZ");
                button6.Text = "关伺服";
                button4.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                Commondata.GalilControler.GCommand("STZ");
                Thread.Sleep(500);
                Commondata.GalilControler.GCommand("MOZ");
                button6.Text = "开伺服";
                button4.Enabled = false;
                button5.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)   //Y轴反转
        {
            string NowPosition = Commondata.GalilControler.GCommand("TPY");
            decimal NewPosition;
            NewPosition = Convert.ToDecimal(NowPosition) - (8192 * numericUpDown1.Value);
            string com = "#A\nPAY = " + NewPosition + "\nSPY = 20000\nBGY";
            Commondata.GalilControler.GProgramDownload(com);
            Commondata.GalilControler.GProgramUpload();
            Commondata.GalilControler.GCommand("XQ#A");
        }

        private void button3_Click(object sender, EventArgs e)   //Y轴正转
        {
            string NowPosition = Commondata.GalilControler.GCommand("TPY");
            decimal NewPosition;
            NewPosition = Convert.ToDecimal(NowPosition) + (8192 * numericUpDown1.Value);
            string com = "#A\nPAY = " + NewPosition + "\nSPY = 20000\nBGY";
            Commondata.GalilControler.GProgramDownload(com);
            Commondata.GalilControler.GProgramUpload();
            Commondata.GalilControler.GCommand("XQ#A");
        }

        private void button5_Click(object sender, EventArgs e)   //Z轴反转
        {
            string NowPosition = Commondata.GalilControler.GCommand("TPZ");
            decimal NewPosition;
            NewPosition = Convert.ToDecimal(NowPosition) - (8192 * numericUpDown2.Value);
            string com = "#A\nPAZ = " + NewPosition + "\nSPZ = 20000\nBGZ";
            Commondata.GalilControler.GProgramDownload(com);
            Commondata.GalilControler.GProgramUpload();
            Commondata.GalilControler.GCommand("XQ#A");
        }

        private void button4_Click(object sender, EventArgs e)   //Z轴正转
        {
            string NowPosition = Commondata.GalilControler.GCommand("TPZ");
            decimal NewPosition;
            NewPosition = Convert.ToDecimal(NowPosition) + (8192 * numericUpDown2.Value);
            string com = "#A\nPAZ = " + NewPosition + "\nSPZ = 20000\nBGZ";
            Commondata.GalilControler.GProgramDownload(com);
            Commondata.GalilControler.GProgramUpload();
            Commondata.GalilControler.GCommand("XQ#A");
        }
    }
}
