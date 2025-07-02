using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma_II
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
            int quadrado1 = n1 * n1;
            int quadrado2 = n2 * n2;
            int soma = quadrado1 + quadrado2;
            MessageBox.Show("A soma do quadrado desses dois números é: " + soma.ToString());
            
        }
    }
}
