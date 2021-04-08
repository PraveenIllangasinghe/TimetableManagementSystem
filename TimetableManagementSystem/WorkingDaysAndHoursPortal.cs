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
    public partial class WorkingDaysAndHoursPortal : MetroFramework.Forms.MetroForm
    {
        public WorkingDaysAndHoursPortal()
        {
            InitializeComponent();
        }

        private void WorkingDaysAndHoursPortal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h4 = new Home();
            h4.Show();
            this.Hide();
        }
    }
}
