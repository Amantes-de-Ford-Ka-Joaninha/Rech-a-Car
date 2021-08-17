using System;
using System.Windows.Forms;
using Dominio.PessoaModule.ClienteModule;

namespace WindowsApp.ClienteModule
{
    public class GerenciamentoCliente : Form
    {
        public GerenciamentoCliente() 
        {
            InitializeComponent();
        }

<<<<<<< HEAD:Rech-a-car/WindowsApp/WindowsApp/ClienteModule/GerenciamentoCliente.cs
        public object[] ObterLinha(Cliente item)
=======
        private Button btClientePF;
        private Label label1;
        private Button btClientePJ;

        private void InitializeComponent()
        {
            this.btClientePF = new System.Windows.Forms.Button();
            this.btClientePJ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btClientePF
            // 
            this.btClientePF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.btClientePF.FlatAppearance.BorderSize = 0;
            this.btClientePF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientePF.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientePF.Location = new System.Drawing.Point(179, 167);
            this.btClientePF.Name = "btClientePF";
            this.btClientePF.Size = new System.Drawing.Size(308, 97);
            this.btClientePF.TabIndex = 0;
            this.btClientePF.Text = "Pessoa Física";
            this.btClientePF.UseVisualStyleBackColor = false;
            this.btClientePF.Click += new System.EventHandler(this.btClientePF_Click);
            // 
            // btClientePJ
            // 
            this.btClientePJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.btClientePJ.FlatAppearance.BorderSize = 0;
            this.btClientePJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientePJ.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientePJ.Location = new System.Drawing.Point(179, 270);
            this.btClientePJ.Name = "btClientePJ";
            this.btClientePJ.Size = new System.Drawing.Size(308, 97);
            this.btClientePJ.TabIndex = 1;
            this.btClientePJ.Text = "Pessoa Jurídica";
            this.btClientePJ.UseVisualStyleBackColor = false;
            this.btClientePJ.Click += new System.EventHandler(this.btClientePJ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // GerenciamentoCliente
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClientePJ);
            this.Controls.Add(this.btClientePF);
            this.Name = "GerenciamentoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btClientePF_Click(object sender, EventArgs e)
        {
            CadastrarClientePF cadastroClientePF = new CadastrarClientePF();
            TelaPrincipal.Instancia.FormAtivo = cadastroClientePF;
        }

        private void btClientePJ_Click(object sender, EventArgs e)
>>>>>>> origin/feature/TelaClientes:Rech-a-car/WindowsApp/ClienteModule/GerenciamentoCliente.cs
        {
            CadastrarClientePJ cadastroClientePJ = new CadastrarClientePJ();
            TelaPrincipal.Instancia.FormAtivo = cadastroClientePJ;
        }
    }
}
