using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalario
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtValorHora.Text);
            decimal Mes = Convert.ToDecimal(txtHorasMes.Text);
            decimal salario = valor * Mes;

            MessageBox.Show("O salário do funcionário é de: R$" + salario.ToString());
        }
    }
}
