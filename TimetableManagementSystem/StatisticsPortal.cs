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
    public partial class StatisticsPortal : MetroFramework.Forms.MetroForm
    {
        public StatisticsPortal()
        {
            InitializeComponent();
        }

        private void StatisticsPortal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h7 = new Home();
            h7.Show();
            this.Hide();
        }
    }
}
