using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divisao
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtValor.Text);
            int quociente = numero / 3;
            int resto = numero % 3;

            MessageBox.Show("Número inteiro digitao: " + numero.ToString() + "\nQuociente da divisão por 3: " + quociente.ToString() + "\nResto da divisão por 3: " + resto.ToString());

        }
    }
}
