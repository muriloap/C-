using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvMilhasQuilometros
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal milhas = Convert.ToDecimal(txtValorMilhas.Text);
            decimal quilometros = milhas * 0.6214m;
            MessageBox.Show("A distância de milhas em quilometros é: " + quilometros.ToString()); 
        }
    }
}
