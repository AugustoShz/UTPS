using Selecao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selecao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Requests requests = new Requests();
            Empresa empresa = requests.Get("https://www.receitaws.com.br/v1/cnpj/"+maskedTextBox1.Text);
            MessageBox.Show(empresa.cep);
        }
    }
}
