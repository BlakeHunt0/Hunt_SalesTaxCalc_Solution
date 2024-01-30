using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunt_SalesTaxCalc_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            if (sBasePriceTxtBox.Text != "")
            {
                //base price
                double dbp = double.Parse(sBasePriceTxtBox.Text);

                //working price
                double dwp = dbp;

                if (sWarrantyCombo.Text != "")
                {
                    //one year warranty
                    if (sWarrantyCombo.Text == "One Year")
                    {
                        dwp = dwp + 1000;
                    }

                    //two year warranty
                    if (sWarrantyCombo.Text == "Two Years")
                    {
                        dwp = dwp + 2000;
                    }

                    //three year warranty
                    if (sWarrantyCombo.Text == "Three Years")
                    {
                        dwp = dwp + 3000;
                    }
                }
                double wpTax = dwp * 0.086;

                if (sStateCombo.Text == "WA")
                {
                    dwp = dwp + wpTax;
                }

                dwp = Math.Round((double)dwp, 2);

                //learned how to do this on the microsoft page
                //https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
                sFinalPrice.Text = (dwp.ToString("C2"));
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            sFinalPrice.Text = null;
            sStateCombo.Text = "WA";
            sWarrantyCombo.Text = null;
            sBasePriceTxtBox.Text = null;
            ActiveControl = sBasePriceTxtBox;
        }
    }
}
