using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorcentagemCondicao
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double percrepC, percaprovD, perctotalreprov;
                int reprovC, reprovD, totalreprov, totalalunos;

                percrepC = Convert.ToDouble(txtValor1.Text);
                percaprovD = Convert.ToDouble(txtValor2.Text);
                totalalunos = 80;

                reprovC = (int)Math.Round((percrepC / 100) * 60, 1);
                reprovD = (int)Math.Round(((100 - percaprovD) / 100) * 20, 1);
                totalreprov = reprovC + reprovD;
                perctotalreprov = (totalreprov / (double)totalalunos) * 100;

                MessageBox.Show("a) Alunos reprovados na turma C: " + reprovC.ToString() + "\nb) Alunos reprovados na turma D: " + reprovD.ToString() + "\nc) Percentual total de reprovados: " + perctotalreprov.ToString() + "%");
            }
        }

    }
}

