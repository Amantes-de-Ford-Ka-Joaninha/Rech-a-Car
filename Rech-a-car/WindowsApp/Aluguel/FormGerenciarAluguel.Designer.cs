
namespace WindowsApp
{
    partial class FormGerenciarAluguel
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.dgvAluguel = new System.Windows.Forms.DataGridView();
            this.btFiltro = new System.Windows.Forms.Button();
            this.picLupa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluguel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(192, 9);
            this.lbTitulo.Location = new System.Drawing.Point(204, 9);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(287, 25);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "NADA ABSOLUTAMENTE NADA";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFiltro.Location = new System.Drawing.Point(25, 80);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(464, 33);
            this.tbFiltro.TabIndex = 1;
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
            this.dgvAluguel.Location = new System.Drawing.Point(25, 146);
            this.dgvAluguel.Name = "dgvAluguel";
            this.dgvAluguel.Size = new System.Drawing.Size(616, 354);
            this.dgvAluguel.TabIndex = 4;
            // 
            // btFiltro
            // 
            this.btFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFiltro.FlatAppearance.BorderSize = 0;
            this.btFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btFiltro.Image = global::telinhas.Properties.Resources.filtro1;
            this.btFiltro.Location = new System.Drawing.Point(565, 61);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(69, 69);
            this.btFiltro.TabIndex = 3;
            this.btFiltro.UseVisualStyleBackColor = true;
            // 
            // picLupa
            // 
            this.picLupa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLupa.Image = global::telinhas.Properties.Resources.pesquisa;
            this.picLupa.Location = new System.Drawing.Point(495, 80);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(33, 33);
            this.picLupa.TabIndex = 2;
            this.picLupa.TabStop = false;
            // 
            // FormGerenciarAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.dgvAluguel);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.picLupa);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.lbTitulo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormGerenciarAluguel";
            this.Text = "FormGerenciarAlugueis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluguel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.DataGridView dgvAluguel;
    }
}