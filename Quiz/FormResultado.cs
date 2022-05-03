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
    public partial class FormResultado : Form
    {
        public FormResultado()
        {
            InitializeComponent();
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            lblResulAcer.Text += VariaveisGlobais.acertos + " pontos";

            if(VariaveisGlobais.acertos <= 45 )
            {
                lblMsgacerto.Text += "Você é muito fraco de memória :(((";                
            }            
            else if (VariaveisGlobais.acertos == 50 && VariaveisGlobais.acertos >= 65)
            {
                lblMsgErro.Text += "Até que você tem boa memória!!!";                
            }
            else
            {
                lblMsgErro.Text += "Você pesquisou bem :p";
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.Close();
            VariaveisGlobais.acertos = 0;
            VariaveisGlobais.erros = 0;
        }
    }
}
