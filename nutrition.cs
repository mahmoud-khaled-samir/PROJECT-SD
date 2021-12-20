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
    public partial class nutrition : Form
    {
        public nutrition()
        {
            InitializeComponent();
        }




        private Form activeForm = null;
        private void guna2Panel1(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panelnutrition.Controls.Add(childForm);
            Panelnutrition.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            guna2Panel1(new employees());
        }

        private void Panelnutrition_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            guna2Panel1(new nutritions());

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            guna2Panel1(new patients());

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            guna2Panel1(new administration());

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            guna2Panel1(new Eat_Table());

        }
    }
}
