/*
 * Created by: Allison Cook
 * Created on: 21 February, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Changing Area and perimeter
 * This program calculates area and perimeter based on user input
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingAreaAllisonC
{
    public partial class frmChangingArea : Form
    {
        //setting varriables
        double width, lenght, area, perimeter;

        public frmChangingArea()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //convert the input to number from string but only if it's a number
            try
            {
                lenght = double.Parse(txtLenght.Text);
                width = double.Parse(txtWidth.Text);

            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }
            //do the calculations 
            area = width * lenght;
            perimeter = 2 * width + 2 * lenght;

            //insert to the text
            lblAreaAnswer.Text = Convert.ToString(area) + " squared meters";
            lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " meters";

        
        }
    }
}
