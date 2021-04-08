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
    public partial class LocationPortal : MetroFramework.Forms.MetroForm
    {
        public LocationPortal()
        {
            InitializeComponent();
        }

        private void LocationPortal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h6 = new Home();
            h6.Show();
            this.Hide();
        }
    }
}
