using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Double n1 = 0, n2 = 0, soma = 0;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            soma = n1 + n2;
            lblResultCalc.Text = Math.Round(soma,2).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Double n1 = 0, n2 = 0, sub = 0;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            sub = n1 - n2;
            lblResultCalc.Text = Math.Round(sub, 2).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Double n1 = 0, n2 = 0, mult = 0;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            mult = n1 * n2;
            lblResultCalc.Text = Math.Round(mult, 2).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Double n1 = 0, n2 = 0, div = 0;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            div = n1 / n2;
            lblResultCalc.Text = Math.Round(div, 2).ToString();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblResultCalc.Text = "";
        }
    }
}
