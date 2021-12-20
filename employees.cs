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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }


        private Form activeForm = null;
        private void DoctorAndNursesPnel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Add(childForm);
            guna2Panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private Form activeForm1 = null;
        private void CookersPanel(Form childForm)
        {
            if (activeForm1 != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Add(childForm);
            guna2Panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }





        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DoctorAndNursesPnel(new DoctorAndNurses());

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            CookersPanel(new Cookers());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
