namespace Selecao
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.tbxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarCNPJ = new System.Windows.Forms.Button();
            this.gvwDados = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblBDStatus = new System.Windows.Forms.Label();
            this.btnAtt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNovaPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(28, 33);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(148, 20);
            this.lblCNPJ.TabIndex = 0;
            this.lblCNPJ.Text = "Por favor insira o CNPJ";
            // 
            // tbxCNPJ
            // 
            this.tbxCNPJ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCNPJ.Location = new System.Drawing.Point(15, 56);
            this.tbxCNPJ.Mask = "00.000.000/0000-00";
            this.tbxCNPJ.Name = "tbxCNPJ";
            this.tbxCNPJ.Size = new System.Drawing.Size(180, 32);
            this.tbxCNPJ.TabIndex = 2;
            this.tbxCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnBuscarCNPJ
            // 
            this.btnBuscarCNPJ.Location = new System.Drawing.Point(15, 94);
            this.btnBuscarCNPJ.Name = "btnBuscarCNPJ";
            this.btnBuscarCNPJ.Size = new System.Drawing.Size(180, 52);
            this.btnBuscarCNPJ.TabIndex = 3;
            this.btnBuscarCNPJ.Text = "Buscar";
            this.btnBuscarCNPJ.UseVisualStyleBackColor = true;
            this.btnBuscarCNPJ.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvwDados
            // 
            this.gvwDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwDados.Location = new System.Drawing.Point(223, 15);
            this.gvwDados.Name = "gvwDados";
            this.gvwDados.Size = new System.Drawing.Size(625, 383);
            this.gvwDados.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(15, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 52);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(15, 343);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 52);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.Location = new System.Drawing.Point(45, 149);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(110, 20);
            this.lblBD.TabIndex = 7;
            this.lblBD.Text = "Banco de Dados";
            // 
            // lblBDStatus
            // 
            this.lblBDStatus.AutoSize = true;
            this.lblBDStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDStatus.Location = new System.Drawing.Point(11, 186);
            this.lblBDStatus.Name = "lblBDStatus";
            this.lblBDStatus.Size = new System.Drawing.Size(49, 20);
            this.lblBDStatus.TabIndex = 8;
            this.lblBDStatus.Text = "Status:";
            // 
            // btnAtt
            // 
            this.btnAtt.Enabled = false;
            this.btnAtt.Location = new System.Drawing.Point(15, 285);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(180, 52);
            this.btnAtt.TabIndex = 9;
            this.btnAtt.Text = "Atualizar";
            this.btnAtt.UseVisualStyleBackColor = true;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaPesquisa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(208, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNovaPesquisa
            // 
            this.menuNovaPesquisa.Name = "menuNovaPesquisa";
            this.menuNovaPesquisa.Size = new System.Drawing.Size(96, 20);
            this.menuNovaPesquisa.Text = "Nova Pesquisa";
            this.menuNovaPesquisa.Visible = false;
            this.menuNovaPesquisa.Click += new System.EventHandler(this.menuNovaPesquisa_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 149);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.lblBDStatus);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gvwDados);
            this.Controls.Add(this.btnBuscarCNPJ);
            this.Controls.Add(this.tbxCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.gvwDados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.MaskedTextBox tbxCNPJ;
        private System.Windows.Forms.Button btnBuscarCNPJ;
        private System.Windows.Forms.DataGridView gvwDados;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblBDStatus;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNovaPesquisa;
    }
}

