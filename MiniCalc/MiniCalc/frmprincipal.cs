using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalc
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(txtValor1.Text);
            decimal n2 = Convert.ToDecimal(txtValor2.Text);
            decimal sub = n1 - n2;
            lblResult.Text = sub.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            decimal n1 = Convert.ToDecimal(txtValor1.Text);
            decimal n2 = Convert.ToDecimal(txtValor2.Text);
            decimal plus = n1 + n2;
            lblResult.Text = plus.ToString();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(txtValor1.Text);
            decimal n2 = Convert.ToDecimal(txtValor2.Text);
            decimal mult = n1 * n2;
            lblResult.Text = mult.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(txtValor1.Text);
            decimal n2 = Convert.ToDecimal(txtValor2.Text);

            if (n2 == 0)
            {
                MessageBox.Show("Divisão por 0 proibida");
                lblResult.Text = "0";
            }
            else
            {
                decimal resultado = n1 / n2;
                lblResult.Text = resultado.ToString();
            }
        }
    }
}
