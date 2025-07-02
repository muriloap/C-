using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal altura = Convert.ToDecimal(txtValorAltura.Text);
            decimal peso = Convert.ToDecimal(txtValorPeso.Text);
            decimal imc = peso / (altura * altura);
            
            if (imc < 18)
            {
                MessageBox.Show("Seu imc é: " + imc.ToString() + " (Abaixo do peso)");
            }
            else if (imc < 25)
            {
                MessageBox.Show("Seu imc é: " + imc.ToString() + " (Peso normal)");
            }
            else if (imc < 30)
            {
                MessageBox.Show("Seu imc é: " + imc.ToString() + " (Sobrepeso)");
            }
            else if (imc < 35)
            {
                MessageBox.Show("Seu imc é: " + imc.ToString() + " (Obesidade Grau I)");
            }
            else if (imc < 40)
            {
                MessageBox.Show("Seu imc é: " + imc.ToString() + " (Obesidade Grau II)");
            }
            else if (imc >= 40)
            {
                MessageBox.Show("Seu imc é: " + imc.ToString() + " (Obesidade Mórbida)");
            }
        }
    }
}
