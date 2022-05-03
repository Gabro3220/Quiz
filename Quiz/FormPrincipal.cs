using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmPrincQuiz : Form
    {
        public FrmPrincQuiz()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para fechar o formulario
            this.Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para chamar os "quiz"
            FormP1 P1 = new FormP1();
            //P1.Show();
            P1.ShowDialog();
        }
    }
}
