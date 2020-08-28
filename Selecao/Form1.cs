using Selecao.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Selecao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        Empresa e = null;
        EncontrarEmpresa ee = new EncontrarEmpresa();
        private void button1_Click(object sender, EventArgs e)
        {
            tbxCNPJ.Enabled = false;
            btnBuscarCNPJ.Enabled = false;
            menuNovaPesquisa.Visible = true;
            if (tbxCNPJ.Text.Length == 14)
            {
                Tuple<Empresa, int> result = this.ee.pesquisar(tbxCNPJ.Text);
                gvwDados.DataSource = result.Item1.toDataTable();
                this.e = result.Item1;

                switch (result.Item2)
                {
                    case 0:
                        btnAdd.Enabled = false;
                        btnRemove.Enabled = true;
                        btnAtt.Enabled = true;
                        lblBDStatus.Text = "Status: Encontrado";
                        break;
                    case 1:
                        btnAdd.Enabled = true;
                        btnRemove.Enabled = false;
                        btnAtt.Enabled = false;
                        lblBDStatus.Text = "Status: Sem Registro";
                        break;
                    case 2:
                        btnAdd.Enabled = false;
                        btnRemove.Enabled = false;
                        btnAtt.Enabled = false;
                        lblBDStatus.Text = "Status: Erro";
                        break;
                    default:
                        btnAdd.Enabled = false;
                        btnRemove.Enabled = false;
                        btnAtt.Enabled = false;
                        lblBDStatus.Text = "Status: Erro";
                        break;
                }
                this.Width = 875;
                this.Height = 450;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                btnAdd.Enabled = false;
                btnRemove.Enabled = true;
                ConexaoBanco cb = new ConexaoBanco();
                cb.inserir(this.e, tbxCNPJ.Text);
                MessageBox.Show("Adicionado ao banco com sucesso");
            }catch(Exception x)
            {
                MessageBox.Show("Ocorreu falha ao adicionar ao banco de dados");
            }
        }

        private void menuNovaPesquisa_Click(object sender, EventArgs e)
        {
            tbxCNPJ.Text = string.Empty;
            tbxCNPJ.Enabled = true;
            btnBuscarCNPJ.Enabled = true;
            btnAdd.Enabled = false;
            btnAtt.Enabled = false;
            btnRemove.Enabled = false;
            this.Width = 224;
            this.Height = 222;
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            try
            {
                btnRemove.Enabled = false;
                btnAtt.Enabled = false;
                ConexaoBanco cb = new ConexaoBanco();
                cb.remover(tbxCNPJ.Text);
                Empresa result = this.ee.pesquisarAPI(tbxCNPJ.Text);
                this.e = result;
                cb.inserir(this.e, tbxCNPJ.Text);
                MessageBox.Show("Atualizado no banco com sucesso");
            }
            catch (Exception x)
            {
                MessageBox.Show("Ocorreu falha ao Atualizar o banco de dados");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                btnRemove.Enabled = false;
                btnAtt.Enabled = false;
                ConexaoBanco cb = new ConexaoBanco();
                cb.remover(tbxCNPJ.Text);
                MessageBox.Show("Removido do banco com sucesso");
            }
            catch(Exception x)
            {
                MessageBox.Show("Ocorreu falha ao remover do banco de dados");
            }
        }
    }
}
