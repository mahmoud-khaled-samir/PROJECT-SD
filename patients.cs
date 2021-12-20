using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL__TEAM_WORK
{
    public partial class patients : Form
    {
        public patients()
        {
            InitializeComponent();
        }

        private void patients_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            insert_patient form2 = new insert_patient();
            form2.ShowDialog();  
        }
    }
}
