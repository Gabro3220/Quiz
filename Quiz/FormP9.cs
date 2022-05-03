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
    public partial class FormP9 : Form
    {
        public FormP9()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rdoCerta.Checked == true)
            {
                VariaveisGlobais.acertos+=5;
                //chamar o próximo
                FormP10 P10 = new FormP10();
                P10.ShowDialog();
                this.Close();
            }
            else if (rdoCerta.Checked == false && rdoPerg2.Checked == false && rdoPerg3.Checked == false && rdoPerg4.Checked == false)
            {
                MessageBox.Show("Escolha uma alternativa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VariaveisGlobais.erros++;
                //chamar o próximo
                FormP10 P10 = new FormP10();
                P10.ShowDialog();
                this.Close();
            }
        }
    }
}
