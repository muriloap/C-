using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(txtValor1.Text);
            int n2 = Convert.ToInt16(txtValor2.Text);
            int resultado = n1 + n2;
            MessageBox.Show("A soma dos números " + txtValor1.Text + " " + " e " + txtValor2.Text + " é igual a: " + resultado.ToString());
        }
    }
}
