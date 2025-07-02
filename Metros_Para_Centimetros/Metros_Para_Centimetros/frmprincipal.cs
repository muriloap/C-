using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metros_Para_Centimetros
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnCovert_Click(object sender, EventArgs e)
        {
            int Metros = Convert.ToInt16(txtValor1.Text);
            int cent = Metros * 100;

            MessageBox.Show("O valor em centímetros é: " + cent + "cm");
        }
    }
}
