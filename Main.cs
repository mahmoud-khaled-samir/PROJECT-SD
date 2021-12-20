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
    public partial class Main : Form
    {
       


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

      
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LogIn f = new LogIn();
            f.Show();
            this.Hide();

        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch1.Checked)
            {
                this.BackColor = Color.Black;
            }

            else
            {
                this.BackColor = Color.Black;
            }
            

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LogIn f = new LogIn();
            f.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new nutrition());

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new nutrition());



        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new BackMain());
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            LogIn f = new LogIn();
            f.Show();
            this.Hide();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new nutrition());

        }

        private void guna2Chip2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Chip3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }




    }
}
