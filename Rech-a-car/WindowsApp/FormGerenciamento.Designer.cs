
namespace WindowsApp
{
    partial class FormGerenciamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAluguel = new System.Windows.Forms.DataGridView();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btFiltro = new System.Windows.Forms.Button();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.panelFormFilho = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluguel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAluguel
            // 
            this.dgvAluguel.AllowUserToAddRows = false;
            this.dgvAluguel.AllowUserToDeleteRows = false;
            this.dgvAluguel.AllowUserToResizeColumns = false;
            this.dgvAluguel.AllowUserToResizeRows = false;
            this.dgvAluguel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAluguel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.dgvAluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluguel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.dgvAluguel.Location = new System.Drawing.Point(26, 153);
            this.dgvAluguel.Name = "dgvAluguel";
            this.dgvAluguel.Size = new System.Drawing.Size(616, 354);
            this.dgvAluguel.TabIndex = 9;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFiltro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(26, 87);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(364, 33);
            this.tbFiltro.TabIndex = 6;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(226, 9);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(152, 25);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Text placeholder";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btAdicionar.Image = global::telinhas.Properties.Resources.adicionar;
            this.btAdicionar.Location = new System.Drawing.Point(582, 71);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(60, 60);
            this.btAdicionar.TabIndex = 12;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.button1.Image = global::telinhas.Properties.Resources.editar1;
            this.button1.Location = new System.Drawing.Point(516, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btFiltro
            // 
            this.btFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFiltro.FlatAppearance.BorderSize = 0;
            this.btFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btFiltro.Image = global::telinhas.Properties.Resources.remover;
            this.btFiltro.Location = new System.Drawing.Point(450, 71);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(60, 60);
            this.btFiltro.TabIndex = 8;
            this.btFiltro.UseVisualStyleBackColor = true;
            // 
            // picLupa
            // 
            this.picLupa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLupa.Image = global::telinhas.Properties.Resources.pesquisa;
            this.picLupa.Location = new System.Drawing.Point(396, 87);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(33, 33);
            this.picLupa.TabIndex = 7;
            this.picLupa.TabStop = false;
            // 
            // panelFormFilho
            // 
            this.panelFormFilho.Location = new System.Drawing.Point(0, 0);
            this.panelFormFilho.Name = "panelFormFilho";
            this.panelFormFilho.Size = new System.Drawing.Size(684, 561);
            this.panelFormFilho.TabIndex = 13;
            // 
            // FormGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.dgvAluguel);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.picLupa);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.panelFormFilho);
            this.Name = "FormGerenciamento";
            this.Text = "FormGerenciamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluguel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluguel;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Panel panelFormFilho;
    }
}