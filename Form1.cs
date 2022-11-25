using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Comment header
//Daniel Oliveira
//10/05/2022
//This program will multiplie numbers, it'll show a pic and i'll provide information about this picture
namespace OliveiraLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare and set variables
            int num1= Convert.ToInt32(txtNumber.Text), num2= Convert.ToInt32(txtMultiplier.Text), answer;

            //do the math
            answer = num1 * num2;

            //display the answer-convertion-formatting
            lblAnswer.Text = answer.ToString();
            lblAnswer.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the numbers-move the cursor on txt.Number
            lblAnswer.Text = " ";
            txtNumber.Text = " ";
            txtMultiplier.Text = " ";
            txtNumber.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            //show picture and hide data
            picBox.Visible = true;
            lblData.Visible = false;
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //show data and hide picture
            picBox.Visible = false;
            lblData.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //hide both picture and data
            picBox.Visible=false;
            lblData.Visible=false;
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            //display a message box
            MessageBox.Show("A prove that cats are liquids!", "Daniel");
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure that the input is numbers
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch !=46)
            {
                e.Handled = true;
            }

        }

        private void txtMultiplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Make sure that the input is numbers
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
