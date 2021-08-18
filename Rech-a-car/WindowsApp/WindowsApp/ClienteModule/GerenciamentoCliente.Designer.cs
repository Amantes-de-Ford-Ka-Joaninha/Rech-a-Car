namespace WindowsApp.ClienteModule
{
    partial class GerenciamentoCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.btClientePJ = new System.Windows.Forms.Button();
            this.btClientePF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // btClientePJ
            // 
            this.btClientePJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.btClientePJ.FlatAppearance.BorderSize = 0;
            this.btClientePJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientePJ.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientePJ.Location = new System.Drawing.Point(179, 276);
            this.btClientePJ.Name = "btClientePJ";
            this.btClientePJ.Size = new System.Drawing.Size(308, 97);
            this.btClientePJ.TabIndex = 4;
            this.btClientePJ.Text = "Pessoa Jurídica";
            this.btClientePJ.UseVisualStyleBackColor = false;
            // 
            // btClientePF
            // 
            this.btClientePF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.btClientePF.FlatAppearance.BorderSize = 0;
            this.btClientePF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientePF.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientePF.Location = new System.Drawing.Point(179, 173);
            this.btClientePF.Name = "btClientePF";
            this.btClientePF.Size = new System.Drawing.Size(308, 97);
            this.btClientePF.TabIndex = 3;
            this.btClientePF.Text = "Pessoa Física";
            this.btClientePF.UseVisualStyleBackColor = false;
            this.btClientePF.Click += new System.EventHandler(this.btClientePF_Click);
            // 
            // GerenciamentoClientescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClientePJ);
            this.Controls.Add(this.btClientePF);
            this.Name = "GerenciamentoClientescs";
            this.Text = "GerenciamentoClientescs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClientePJ;
        private System.Windows.Forms.Button btClientePF;
    }
}