using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAtv
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(txtValor1.Text);
            decimal n2 = Convert.ToDecimal(txtValor2.Text);
            decimal n3 = Convert.ToDecimal(txtValor3.Text);
            decimal n4 = Convert.ToDecimal(txtValor4.Text);
            decimal Media = (n1 + n2 + n3 + n4) / 4;

            MessageBox.Show("A média é: " + Media.ToString());
        }
    }
}
