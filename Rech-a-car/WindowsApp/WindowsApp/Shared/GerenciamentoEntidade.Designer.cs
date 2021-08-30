
namespace WindowsApp.Shared
{
    partial class GerenciamentoEntidade <T>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEntidade = new System.Windows.Forms.DataGridView();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelFormFilho = new System.Windows.Forms.Panel();
            this.bt_check = new System.Windows.Forms.Button();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.bt_remover = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.btFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidade)).BeginInit();
            this.panelFormFilho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntidade
            // 
            this.dgvEntidade.AllowUserToAddRows = false;
            this.dgvEntidade.AllowUserToDeleteRows = false;
            this.dgvEntidade.AllowUserToResizeColumns = false;
            this.dgvEntidade.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.dgvEntidade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEntidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEntidade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.dgvEntidade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntidade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEntidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidade.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntidade.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvEntidade.EnableHeadersVisualStyles = false;
            this.dgvEntidade.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.dgvEntidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvEntidade.Location = new System.Drawing.Point(26, 145);
            this.dgvEntidade.MultiSelect = false;
            this.dgvEntidade.Name = "dgvEntidade";
            this.dgvEntidade.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntidade.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvEntidade.RowHeadersVisible = false;
            this.dgvEntidade.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.dgvEntidade.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvEntidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntidade.Size = new System.Drawing.Size(616, 354);
            this.dgvEntidade.TabIndex = 9;
            this.dgvEntidade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntidade_CellClick);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(26, 87);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(285, 33);
            this.tbFiltro.TabIndex = 6;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(206, 7);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(249, 25);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Gerenciamento de Entidade";
            // 
            // panelFormFilho
            // 
            this.panelFormFilho.Controls.Add(this.bt_check);
            this.panelFormFilho.Controls.Add(this.picLupa);
            this.panelFormFilho.Controls.Add(this.bt_remover);
            this.panelFormFilho.Controls.Add(this.bt_editar);
            this.panelFormFilho.Controls.Add(this.bt_adicionar);
            this.panelFormFilho.Controls.Add(this.btFiltro);
            this.panelFormFilho.Controls.Add(this.lbTitulo);
            this.panelFormFilho.Controls.Add(this.dgvEntidade);
            this.panelFormFilho.Location = new System.Drawing.Point(0, 0);
            this.panelFormFilho.Name = "panelFormFilho";
            this.panelFormFilho.Size = new System.Drawing.Size(670, 521);
            this.panelFormFilho.TabIndex = 13;
            // 
            // bt_check
            // 
            this.bt_check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_check.FlatAppearance.BorderSize = 0;
            this.bt_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.bt_check.Image = global::WindowsApp.Properties.Resources.confirmar1;
            this.bt_check.Location = new System.Drawing.Point(588, 68);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(60, 60);
            this.bt_check.TabIndex = 15;
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // picLupa
            // 
            this.picLupa.Image = global::WindowsApp.Properties.Resources.pesquisa;
            this.picLupa.Location = new System.Drawing.Point(317, 87);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(33, 33);
            this.picLupa.TabIndex = 7;
            this.picLupa.TabStop = false;
            // 
            // bt_remover
            // 
            this.bt_remover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_remover.Enabled = false;
            this.bt_remover.FlatAppearance.BorderSize = 0;
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.bt_remover.Image = global::WindowsApp.Properties.Resources.remover;
            this.bt_remover.Location = new System.Drawing.Point(412, 68);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(60, 60);
            this.bt_remover.TabIndex = 8;
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_editar.Enabled = false;
            this.bt_editar.FlatAppearance.BorderSize = 0;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.bt_editar.Image = global::WindowsApp.Properties.Resources.editar1;
            this.bt_editar.Location = new System.Drawing.Point(475, 68);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(60, 60);
            this.bt_editar.TabIndex = 11;
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_adicionar.FlatAppearance.BorderSize = 0;
            this.bt_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.bt_adicionar.Image = global::WindowsApp.Properties.Resources.adicionar;
            this.bt_adicionar.Location = new System.Drawing.Point(538, 68);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(60, 60);
            this.bt_adicionar.TabIndex = 12;
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btFiltro
            // 
            this.btFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFiltro.FlatAppearance.BorderSize = 0;
            this.btFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btFiltro.Image = global::WindowsApp.Properties.Resources.filtro1;
            this.btFiltro.Location = new System.Drawing.Point(351, 72);
            this.btFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(66, 56);
            this.btFiltro.TabIndex = 11;
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // GerenciamentoEntidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.panelFormFilho);
            this.Name = "GerenciamentoEntidade";
            this.Text = "FormGerenciamento";
            this.Load += new System.EventHandler(this.GerenciamentoEntidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidade)).EndInit();
            this.panelFormFilho.ResumeLayout(false);
            this.panelFormFilho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgvEntidade;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Panel panelFormFilho;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Button bt_check;
    }
}