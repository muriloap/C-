using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversaoKilosDias
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal quantidadeKg = Convert.ToDecimal(txtValorKg.Text);
            decimal quantidadegramas = quantidadeKg * 1000;
            decimal dias = quantidadegramas / 50;

            MessageBox.Show("Consumo diário: 50 gramas" + "\nO alimento durará " + dias.ToString() + " dias");
        }
    }
}
