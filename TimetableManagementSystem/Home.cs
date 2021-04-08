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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatisticsPortal stp = new StatisticsPortal();
            stp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentGroupPortal sgp = new StudentGroupPortal();
            sgp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Subjects sp = new Subjects();
            sp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WorkingDaysAndHoursPortal wdh = new WorkingDaysAndHoursPortal();
            wdh.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateTimetables gt = new GenerateTimetables();
            gt.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TagPortal tp = new TagPortal();
            tp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddLecturers al = new AddLecturers();
            al.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LocationPortal lcp = new LocationPortal();
            lcp.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            NewUI p = new NewUI();
            p.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
