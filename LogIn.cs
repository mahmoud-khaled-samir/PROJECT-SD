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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Switch1_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch1.Checked)
            {
                guna2Chip1.FillColor = Color.Black;
                /*
                label1.ForeColor = Color.White;
                label1.BackColor = Color.Black;
                 */
                guna2GradientButton1.BackColor = Color.Black;
                guna2GradientButton2.BackColor = Color.Black;
                PassWord.FillColor = Color.Black;
                UserName.FillColor = Color.Black;
                label2.BackColor = Color.Black;
                label2.ForeColor = Color.White;
                guna2CustomRadioButton1.BackColor = Color.Black;
                gunaLabel1.BackColor = Color.Black;
                gunaLabel1.ForeColor = Color.DimGray;
                Switch1.BackColor = Color.Black;
                guna2HtmlLabel1.BackColor = Color.Black;
                guna2HtmlLabel1.ForeColor = Color.White;
                label3.BackColor = Color.Black;
                label3.ForeColor = Color.White;
                guna2PictureBox1.BackColor = Color.Black;
                guna2Separator1.BackColor = Color.Black;


            }

            else
            {
                guna2Chip1.FillColor = Color.White;
                /*
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.White;
                 */
                guna2GradientButton1.BackColor = Color.White;
                guna2GradientButton2.BackColor = Color.White;
                PassWord.FillColor = Color.White;
                UserName.FillColor = Color.White;
                label2.BackColor = Color.White;
                label2.ForeColor = Color.Black;
                guna2CustomRadioButton1.BackColor = Color.White;
                gunaLabel1.BackColor = Color.White;
                Switch1.BackColor = Color.White;
                guna2HtmlLabel1.BackColor = Color.White;
                guna2HtmlLabel1.ForeColor = Color.Black;
                label3.BackColor = Color.White;
                label3.ForeColor = Color.Black;
                guna2PictureBox1.BackColor = Color.White;
                guna2Separator1.BackColor = Color.White;



            }
            
        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "MET" && PassWord.Text=="2000")
            {
                Main f = new Main();
                f.Show();
            }
            else
            {
                MessageBox.Show("أسم المستخدم أو كلمه المرور خطأ");
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
