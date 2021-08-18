﻿
namespace WindowsApp
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.PanelMenuLateral = new System.Windows.Forms.Panel();
            this.bt_servicos = new System.Windows.Forms.Button();
            this.bt_funcionarios = new System.Windows.Forms.Button();
            this.bt_veiculos = new System.Windows.Forms.Button();
            this.panelSubMenuClientes = new System.Windows.Forms.Panel();
            this.btPessoaJuridica = new System.Windows.Forms.Button();
            this.btPessoaFisica = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_clientes = new System.Windows.Forms.Button();
            this.panelSubMenuAluguel = new System.Windows.Forms.Panel();
            this.bt_gerenciarAlugueis = new System.Windows.Forms.Button();
            this.bt_realizarAluguel = new System.Windows.Forms.Button();
            this.bt_aluguel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormFilho = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenuLateral.SuspendLayout();
            this.panelSubMenuClientes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSubMenuAluguel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFormFilho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.PanelMenuLateral.Controls.Add(this.bt_servicos);
            this.PanelMenuLateral.Controls.Add(this.bt_funcionarios);
            this.PanelMenuLateral.Controls.Add(this.bt_veiculos);
            this.PanelMenuLateral.Controls.Add(this.panelSubMenuClientes);
            this.PanelMenuLateral.Controls.Add(this.panel3);
            this.PanelMenuLateral.Controls.Add(this.bt_clientes);
            this.PanelMenuLateral.Controls.Add(this.panelSubMenuAluguel);
            this.PanelMenuLateral.Controls.Add(this.bt_aluguel);
            this.PanelMenuLateral.Controls.Add(this.panel1);
            this.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(250, 561);
            this.PanelMenuLateral.TabIndex = 0;
            // 
            // bt_servicos
            // 
            this.bt_servicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_servicos.FlatAppearance.BorderSize = 0;
            this.bt_servicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_servicos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_servicos.ForeColor = System.Drawing.Color.White;
            this.bt_servicos.Image = global::WindowsApp.Properties.Resources.servicos;
            this.bt_servicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_servicos.Location = new System.Drawing.Point(0, 503);
            this.bt_servicos.Name = "bt_servicos";
            this.bt_servicos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_servicos.Size = new System.Drawing.Size(250, 50);
            this.bt_servicos.TabIndex = 11;
            this.bt_servicos.Text = " Serviços";
            this.bt_servicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_servicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_servicos.UseVisualStyleBackColor = true;
            this.bt_servicos.Click += new System.EventHandler(this.bt_Servicos_Click);
            // 
            // bt_funcionarios
            // 
            this.bt_funcionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_funcionarios.FlatAppearance.BorderSize = 0;
            this.bt_funcionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_funcionarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_funcionarios.ForeColor = System.Drawing.Color.White;
            this.bt_funcionarios.Image = global::WindowsApp.Properties.Resources.funcionarios;
            this.bt_funcionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_funcionarios.Location = new System.Drawing.Point(0, 453);
            this.bt_funcionarios.Name = "bt_funcionarios";
            this.bt_funcionarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_funcionarios.Size = new System.Drawing.Size(250, 50);
            this.bt_funcionarios.TabIndex = 10;
            this.bt_funcionarios.Text = " Funcionários";
            this.bt_funcionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_funcionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_funcionarios.UseVisualStyleBackColor = true;
            this.bt_funcionarios.Click += new System.EventHandler(this.bt_funcionarios_Click);
            // 
            // bt_veiculos
            // 
            this.bt_veiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_veiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_veiculos.FlatAppearance.BorderSize = 0;
            this.bt_veiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_veiculos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_veiculos.ForeColor = System.Drawing.Color.White;
            this.bt_veiculos.Image = global::WindowsApp.Properties.Resources.veiculos;
            this.bt_veiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_veiculos.Location = new System.Drawing.Point(0, 403);
            this.bt_veiculos.Name = "bt_veiculos";
            this.bt_veiculos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_veiculos.Size = new System.Drawing.Size(250, 50);
            this.bt_veiculos.TabIndex = 9;
            this.bt_veiculos.Text = " Veículos";
            this.bt_veiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_veiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_veiculos.UseVisualStyleBackColor = true;
            this.bt_veiculos.Click += new System.EventHandler(this.bt_Veiculos_Click);
            // 
            // panelSubMenuClientes
            // 
            this.panelSubMenuClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panelSubMenuClientes.Controls.Add(this.btPessoaJuridica);
            this.panelSubMenuClientes.Controls.Add(this.btPessoaFisica);
            this.panelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuClientes.Location = new System.Drawing.Point(0, 303);
            this.panelSubMenuClientes.Name = "panelSubMenuClientes";
            this.panelSubMenuClientes.Size = new System.Drawing.Size(250, 100);
            this.panelSubMenuClientes.TabIndex = 8;
            // 
            // btPessoaJuridica
            // 
            this.btPessoaJuridica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPessoaJuridica.FlatAppearance.BorderSize = 0;
            this.btPessoaJuridica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPessoaJuridica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPessoaJuridica.ForeColor = System.Drawing.Color.White;
            this.btPessoaJuridica.Location = new System.Drawing.Point(0, 50);
            this.btPessoaJuridica.Name = "btPessoaJuridica";
            this.btPessoaJuridica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btPessoaJuridica.Size = new System.Drawing.Size(250, 50);
            this.btPessoaJuridica.TabIndex = 3;
            this.btPessoaJuridica.Text = "Pessoa Jurídica";
            this.btPessoaJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPessoaJuridica.UseVisualStyleBackColor = true;
            this.btPessoaJuridica.Click += new System.EventHandler(this.btPessoaJuridica_Click);
            // 
            // btPessoaFisica
            // 
            this.btPessoaFisica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPessoaFisica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPessoaFisica.FlatAppearance.BorderSize = 0;
            this.btPessoaFisica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPessoaFisica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPessoaFisica.ForeColor = System.Drawing.Color.White;
            this.btPessoaFisica.Location = new System.Drawing.Point(0, 0);
            this.btPessoaFisica.Name = "btPessoaFisica";
            this.btPessoaFisica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btPessoaFisica.Size = new System.Drawing.Size(250, 50);
            this.btPessoaFisica.TabIndex = 2;
            this.btPessoaFisica.Text = "Pessoa Física";
            this.btPessoaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPessoaFisica.UseVisualStyleBackColor = true;
            this.btPessoaFisica.Click += new System.EventHandler(this.btPessoaFisica_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_sair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 54);
            this.panel3.TabIndex = 7;
            // 
            // bt_sair
            // 
            this.bt_sair.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_sair.FlatAppearance.BorderSize = 0;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.White;
            this.bt_sair.Image = global::WindowsApp.Properties.Resources.sair;
            this.bt_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sair.Location = new System.Drawing.Point(0, 0);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_sair.Size = new System.Drawing.Size(250, 51);
            this.bt_sair.TabIndex = 9;
            this.bt_sair.Text = " Sair";
            this.bt_sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_clientes
            // 
            this.bt_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_clientes.FlatAppearance.BorderSize = 0;
            this.bt_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clientes.ForeColor = System.Drawing.Color.White;
            this.bt_clientes.Image = global::WindowsApp.Properties.Resources.clientes;
            this.bt_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clientes.Location = new System.Drawing.Point(0, 253);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_clientes.Size = new System.Drawing.Size(250, 50);
            this.bt_clientes.TabIndex = 3;
            this.bt_clientes.Text = " Clientes";
            this.bt_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_clientes.UseVisualStyleBackColor = true;
            this.bt_clientes.Click += new System.EventHandler(this.bt_clientes_Click);
            // 
            // panelSubMenuAluguel
            // 
            this.panelSubMenuAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panelSubMenuAluguel.Controls.Add(this.bt_gerenciarAlugueis);
            this.panelSubMenuAluguel.Controls.Add(this.bt_realizarAluguel);
            this.panelSubMenuAluguel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAluguel.Location = new System.Drawing.Point(0, 150);
            this.panelSubMenuAluguel.Name = "panelSubMenuAluguel";
            this.panelSubMenuAluguel.Size = new System.Drawing.Size(250, 103);
            this.panelSubMenuAluguel.TabIndex = 2;
            // 
            // bt_gerenciarAlugueis
            // 
            this.bt_gerenciarAlugueis.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_gerenciarAlugueis.FlatAppearance.BorderSize = 0;
            this.bt_gerenciarAlugueis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gerenciarAlugueis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gerenciarAlugueis.ForeColor = System.Drawing.Color.White;
            this.bt_gerenciarAlugueis.Location = new System.Drawing.Point(0, 50);
            this.bt_gerenciarAlugueis.Name = "bt_gerenciarAlugueis";
            this.bt_gerenciarAlugueis.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_gerenciarAlugueis.Size = new System.Drawing.Size(250, 50);
            this.bt_gerenciarAlugueis.TabIndex = 1;
            this.bt_gerenciarAlugueis.Text = "Gerenciar Aluguéis";
            this.bt_gerenciarAlugueis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gerenciarAlugueis.UseVisualStyleBackColor = true;
            this.bt_gerenciarAlugueis.Click += new System.EventHandler(this.bt_GerenciarAlugueis_Click);
            // 
            // bt_realizarAluguel
            // 
            this.bt_realizarAluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_realizarAluguel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_realizarAluguel.FlatAppearance.BorderSize = 0;
            this.bt_realizarAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_realizarAluguel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_realizarAluguel.ForeColor = System.Drawing.Color.White;
            this.bt_realizarAluguel.Location = new System.Drawing.Point(0, 0);
            this.bt_realizarAluguel.Name = "bt_realizarAluguel";
            this.bt_realizarAluguel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_realizarAluguel.Size = new System.Drawing.Size(250, 50);
            this.bt_realizarAluguel.TabIndex = 0;
            this.bt_realizarAluguel.Text = "Realizar Aluguel";
            this.bt_realizarAluguel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_realizarAluguel.UseVisualStyleBackColor = true;
            this.bt_realizarAluguel.Click += new System.EventHandler(this.bt_RealizarAluguel_Click);
            // 
            // bt_aluguel
            // 
            this.bt_aluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_aluguel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_aluguel.FlatAppearance.BorderSize = 0;
            this.bt_aluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_aluguel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_aluguel.ForeColor = System.Drawing.Color.White;
            this.bt_aluguel.Image = global::WindowsApp.Properties.Resources.aluguel;
            this.bt_aluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_aluguel.Location = new System.Drawing.Point(0, 100);
            this.bt_aluguel.Name = "bt_aluguel";
            this.bt_aluguel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_aluguel.Size = new System.Drawing.Size(250, 50);
            this.bt_aluguel.TabIndex = 1;
            this.bt_aluguel.Text = " Aluguel de Veículos";
            this.bt_aluguel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_aluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_aluguel.UseVisualStyleBackColor = true;
            this.bt_aluguel.Click += new System.EventHandler(this.bt_Aluguel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alexandre Rech";
            // 
            // panelFormFilho
            // 
            this.panelFormFilho.Controls.Add(this.label3);
            this.panelFormFilho.Controls.Add(this.labelTitulo);
            this.panelFormFilho.Controls.Add(this.pictureBox1);
            this.panelFormFilho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormFilho.Location = new System.Drawing.Point(250, 0);
            this.panelFormFilho.Name = "panelFormFilho";
            this.panelFormFilho.Size = new System.Drawing.Size(684, 561);
            this.panelFormFilho.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(646, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "V1.0.0";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(100, 374);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(485, 91);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Rech-a-Car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 273);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelFormFilho);
            this.Controls.Add(this.PanelMenuLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 599);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rech-a-Car";
            this.PanelMenuLateral.ResumeLayout(false);
            this.panelSubMenuClientes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelSubMenuAluguel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFormFilho.ResumeLayout(false);
            this.panelFormFilho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuLateral;
        private System.Windows.Forms.Panel panelSubMenuAluguel;
        private System.Windows.Forms.Button bt_realizarAluguel;
        private System.Windows.Forms.Button bt_aluguel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_gerenciarAlugueis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFormFilho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_servicos;
        private System.Windows.Forms.Button bt_funcionarios;
        private System.Windows.Forms.Button bt_veiculos;
        private System.Windows.Forms.Panel panelSubMenuClientes;
        private System.Windows.Forms.Button bt_clientes;
        private System.Windows.Forms.Button btPessoaFisica;
        private System.Windows.Forms.Button btPessoaJuridica;
    }
}

