
namespace WindowsApp.FuncionarioModule
{
    partial class CadastroFuncionario
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
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionários";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(27, 215);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 21);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(86, 212);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(234, 29);
            this.tbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(329, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Endereço";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(409, 212);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(234, 29);
            this.tbEndereco.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(366, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "CPF";
            // 
            // btAdicionar
            // 
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Image = global::WindowsApp.Properties.Resources.adicionar;
            this.btAdicionar.Location = new System.Drawing.Point(581, 439);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 71);
            this.btAdicionar.TabIndex = 5;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefone.Location = new System.Drawing.Point(86, 247);
            this.tbTelefone.Mask = "(99) 00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(234, 29);
            this.tbTelefone.TabIndex = 2;
            this.tbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbCPF
            // 
            this.tbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPF.Location = new System.Drawing.Point(409, 247);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(234, 29);
            this.tbCPF.TabIndex = 4;
            this.tbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.MaskedTextBox tbCPF;
    }
}