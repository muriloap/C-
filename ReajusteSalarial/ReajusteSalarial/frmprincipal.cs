using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteSalarial
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtValorSalario.Text);
            decimal acrescimo = valor * 0.15m;
            decimal valoracrescimo = valor + acrescimo;
            MessageBox.Show("O salário do funcionário é de R$" + valor.ToString() + "\n" + "Acréscimo (15%): R$" + acrescimo.ToString() + "\n" + "O salário do funcionário com o acréscimo é de: R$" + valoracrescimo.ToString());
        }
    }
}
