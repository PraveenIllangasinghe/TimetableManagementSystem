using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableManagementSystem
{
    public partial class NewUI : Form
    {

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public NewUI()
        {
            InitializeComponent();
        }

        private void NewUI_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            testtab p = new testtab();
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewSubjects pn = new NewSubjects();
            pn.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GenarateTimetable pnn = new GenarateTimetable();
            pnn.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewWorkingDays wd = new NewWorkingDays();
            wd.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NewSession nss = new NewSession();
            nss.Show();
            this.Hide();
        }
    }
}
