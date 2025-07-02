using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medias
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(txtValor1.Text);
            int n2 = Convert.ToInt16(txtValor2.Text);
            int n3 = Convert.ToInt16(txtValor3.Text);
            decimal Media = (n1 + n2 + n3) / 3;

            MessageBox.Show("A média é: " + Media.ToString());

            if (n1 < Media)
            {
                txtValor1.ForeColor = Color.Blue;
            }
            if (n2 < Media)
            {
                txtValor2.ForeColor = Color.Blue;
            }
            if (n3 < Media)
            {
                txtValor3.ForeColor = Color.Blue;
            }
        }
    }
}