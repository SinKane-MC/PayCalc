using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            const decimal FTHOURS = 37.5m;
            decimal regHours, otHours, regPay, otPay, rate, total;
            if (Convert.ToDecimal(txtHours.Text) >= FTHOURS)
            {
                otHours = Convert.ToDecimal(txtHours.Text) - FTHOURS;
                regHours = Convert.ToDecimal(txtHours.Text);
                rate = Convert.ToDecimal(txtRate.Text);
                lblOTPay.Visible = true;
                lblRegPay.Visible = true;
                regPay = regHours * rate;
                otPay = otHours * (rate * 1.5m);
                lblRegPay.Text = regPay.ToString("c");
                lblOTPay.Text = otPay.ToString("c");
                total = regPay + otPay;
                lblTotal.Text = total.ToString("c");
            }
            else
            {
                regHours = Convert.ToDecimal(txtHours.Text);
                rate = Convert.ToDecimal(txtRate.Text);
                regPay = regHours * rate;
                lblTotal.Text = regPay.ToString("c");
            }





        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOTPay.Visible = false;
            lblRegPay.Visible = false;
            lblRegPay.Text = "";
            lblOTPay.Text ="";
            lblTotal.Text = "";
            txtHours.Text = "";
            txtRate.Text = "";
            txtHours.Focus();
        }
    }
}
