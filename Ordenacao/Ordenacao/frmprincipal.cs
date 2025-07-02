using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenacao
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int original1, original2, original3;

            int.TryParse(txtValor1.Text, out original1);
            int.TryParse(txtValor2.Text, out original2);
            int.TryParse(txtValor3.Text, out original3);
            int a = original1, b = original2, c = original3;
            int aux;
            
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c= aux;
            }
            // Exibe resultado Crescente
            lblCresc1.Text = a.ToString();
            lblCresc2.Text = b.ToString();
            lblCresc3.Text = c.ToString();

            a = original1;
            b = original2;
            c = original3;

            if (a < b)
            {
                aux = a;
                a = b; 
                b = aux;
            }
            if (a < c)
            {
                aux = a; 
                a = c; 
                c = aux;
            }
            if (b < c)
            {
                aux = b; 
                b = c; 
                c = aux;
            }
            lblDecresc1.Text = a.ToString();
            lblDecresc2.Text = b.ToString();
            lblDecresc3.Text = c.ToString();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCresc_Click(object sender, EventArgs e)
        {

        }

        private void txtValor3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}   
