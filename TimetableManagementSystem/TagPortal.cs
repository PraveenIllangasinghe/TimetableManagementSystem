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
    public partial class TagPortal : MetroFramework.Forms.MetroForm
    {
        public TagPortal()
        {
            InitializeComponent();
        }

        private void TagPortal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h5 = new Home();
            h5.Show();
            this.Hide();
        }
    }
}
