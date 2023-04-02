namespace Lista_de_Tarefas
{
    partial class Principal
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
            this.ListaLista = new System.Windows.Forms.CheckedListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNewlist = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLimSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaLista
            // 
            this.ListaLista.FormattingEnabled = true;
            this.ListaLista.Location = new System.Drawing.Point(80, 96);
            this.ListaLista.Name = "ListaLista";
            this.ListaLista.Size = new System.Drawing.Size(567, 244);
            this.ListaLista.TabIndex = 0;
            this.ListaLista.SelectedIndexChanged += new System.EventHandler(this.ListaLista_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(572, 59);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adcionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtNewlist
            // 
            this.txtNewlist.Location = new System.Drawing.Point(80, 59);
            this.txtNewlist.Name = "txtNewlist";
            this.txtNewlist.Size = new System.Drawing.Size(477, 20);
            this.txtNewlist.TabIndex = 3;
            this.txtNewlist.Text = "adcione uma lista";
            this.txtNewlist.TextChanged += new System.EventHandler(this.txtNewlist_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(556, 346);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 34);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLimSelect
            // 
            this.btnLimSelect.Location = new System.Drawing.Point(441, 346);
            this.btnLimSelect.Name = "btnLimSelect";
            this.btnLimSelect.Size = new System.Drawing.Size(91, 34);
            this.btnLimSelect.TabIndex = 5;
            this.btnLimSelect.Text = "Limpar itens selecionados";
            this.btnLimSelect.UseVisualStyleBackColor = true;
            this.btnLimSelect.Click += new System.EventHandler(this.btnLimSelect_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 452);
            this.Controls.Add(this.btnLimSelect);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNewlist);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.ListaLista);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ListaLista;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNewlist;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLimSelect;
    }
}

