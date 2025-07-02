using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoArea
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lado = Convert.ToInt16(txtValor1.Text);
            int area = lado * lado;
            int dobro = area * 2;

            MessageBox.Show("A área é: " + area + "m" + " e o dobro da área é: " + dobro.ToString() + "m");
        }
    }
}
