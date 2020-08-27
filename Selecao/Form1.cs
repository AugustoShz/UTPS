using Selecao.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Selecao
{
    public partial class FormPrincipal : Form
    {
        string ApiURL = "https://www.receitaws.com.br/v1/cnpj/";
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncontrarEmpresa ee = new EncontrarEmpresa();
            this.Width = 875;
            this.Height = 450;
        }
    }
}
