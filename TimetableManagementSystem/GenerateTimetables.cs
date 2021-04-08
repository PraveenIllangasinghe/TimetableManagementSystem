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
    public partial class GenerateTimetables : MetroFramework.Forms.MetroForm
    {
        public GenerateTimetables()
        {
            InitializeComponent();
        }

        private void GenerateTimetables_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h8 = new Home();
            h8.Show();
            this.Hide();
        }
    }
}
