using Selecao.Classes;
using System;
using System.Windows.Forms;

namespace Selecao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncontrarEmpresa ee = new EncontrarEmpresa();
            dataGridView1.DataSource = ee.pesquisar(tbxCNPJ.Text).Item1;
            this.Width = 875;
            this.Height = 450;
        }
    }
}
