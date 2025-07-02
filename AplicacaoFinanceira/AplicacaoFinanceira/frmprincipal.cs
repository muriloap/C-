using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoFinanceira
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            decimal deposito = Convert.ToDecimal(txtValorDeposito.Text);
            decimal juros = deposito * 0.05m; // 5% de juros
            decimal total = deposito + juros;
            MessageBox.Show("Valor depositado no começo do mês: R$" + deposito.ToString() + "\nJuros obtido (5%): R$" + juros.ToString() + "\nTotal no final do mês: R$" + total.ToString());
        }
    }
}
