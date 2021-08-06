using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerDigitalWatch
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblTime.Text = "";
            timer1.Interval = 1000;//1초
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Location = new Point(ClientSize.Width / 2 - lblTime.Width / 2, ClientSize.Height / 2 - lblTime.Height / 2);
            lblTime.Font = new Font("맑은 고딕", 30, FontStyle.Bold);
            lblTime.Text = DateTime.Now.ToString();
            timer1.Tick += timer1_Tick;

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
