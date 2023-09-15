using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class btnLimpa : Form
    {

        public btnLimpa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblMat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Double n1 = 0, n2 = 0, n3 = 0, media = 0;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            n3 = Convert.ToDouble(txtN3.Text);

            media = (n1 + n2 + n3) / 3;
            lblMediaCalc.Text = Math.Round(media,2).ToString();

            if (media < 7.0)
            {
                lblStatus.Text = "REPROVADO";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = "APROVADO";
                lblStatus.ForeColor = Color.Green; 
            }
        }

        private void limpaBtn_Click(object sender, EventArgs e)
        {
            lblMediaCalc.Text = "";
            lblStatus.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtNome.Text = "";
            txtMat.Text = "";
        }
    }
}
