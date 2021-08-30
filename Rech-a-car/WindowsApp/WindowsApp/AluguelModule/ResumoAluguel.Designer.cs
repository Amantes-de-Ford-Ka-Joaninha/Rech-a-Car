
using Controladores.Shared;
using Dominio.AluguelModule;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    partial class ResumoAluguel
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
            this.panel1 = new Shared.PanelColorido();
            this.tbCondutor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.tbEndereço = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new Shared.PanelColorido();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new Shared.PanelColorido();
            this.tbPlano = new System.Windows.Forms.ComboBox();
            this.tbDt_Devolucao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDt_Emprestimo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelColorido1 = new Shared.PanelColorido();
            this.listOpcionais = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btFecharAluguel = new System.Windows.Forms.Button();
            this.panelColorido2 = new Shared.PanelColorido();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelColorido1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumo do Aluguel";
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.tbCondutor);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbTelefone);
            this.panel1.Controls.Add(this.tbDocumento);
            this.panel1.Controls.Add(this.tbEndereço);
            this.panel1.Controls.Add(this.tbCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 169);
            this.panel1.TabIndex = 1;
            // 
            // tbCondutor
            // 
            this.tbCondutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCondutor.Location = new System.Drawing.Point(426, 64);
            this.tbCondutor.Name = "tbCondutor";
            this.tbCondutor.Size = new System.Drawing.Size(168, 29);
            this.tbCondutor.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(422, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 21);
            this.label17.TabIndex = 9;
            this.label17.Text = "Condutor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Informações do Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(422, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(276, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cliente";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefone.Location = new System.Drawing.Point(426, 126);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(168, 29);
            this.tbTelefone.TabIndex = 5;
            // 
            // tbDocumento
            // 
            this.tbDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocumento.Location = new System.Drawing.Point(280, 64);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(129, 29);
            this.tbDocumento.TabIndex = 3;
            // 
            // tbEndereço
            // 
            this.tbEndereço.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereço.Location = new System.Drawing.Point(14, 126);
            this.tbEndereço.Name = "tbEndereço";
            this.tbEndereço.Size = new System.Drawing.Size(395, 29);
            this.tbEndereço.TabIndex = 2;
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(14, 64);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(251, 29);
            this.tbCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(132, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tbPlaca);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbModelo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbMarca);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(31, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 102);
            this.panel2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(-5, -3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Informações do Veículo";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlaca.Location = new System.Drawing.Point(456, 57);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(121, 29);
            this.tbPlaca.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(452, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Placa";
            // 
            // tbModelo
            // 
            this.tbModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModelo.Location = new System.Drawing.Point(243, 57);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(144, 29);
            this.tbModelo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(239, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Modelo";
            // 
            // tbMarca
            // 
            this.tbMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarca.Location = new System.Drawing.Point(33, 57);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(143, 29);
            this.tbMarca.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Marca";
            // 
            // panel3
            // 
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.tbPlano);
            this.panel3.Controls.Add(this.tbDt_Devolucao);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tbDt_Emprestimo);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(245, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 160);
            this.panel3.TabIndex = 3;
            // 
            // tbPlano
            // 
            this.tbPlano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlano.FormattingEnabled = true;
            this.tbPlano.Items.AddRange(new object[] {
            "Diário",
            "Controlado",
            "Livre"});
            this.tbPlano.Location = new System.Drawing.Point(16, 27);
            this.tbPlano.Name = "tbPlano";
            this.tbPlano.Size = new System.Drawing.Size(143, 25);
            this.tbPlano.TabIndex = 10;
            // 
            // tbDt_Devolucao
            // 
            this.tbDt_Devolucao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDt_Devolucao.Location = new System.Drawing.Point(16, 123);
            this.tbDt_Devolucao.Name = "tbDt_Devolucao";
            this.tbDt_Devolucao.Size = new System.Drawing.Size(143, 25);
            this.tbDt_Devolucao.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(13, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Data de Devolução";
            // 
            // tbDt_Emprestimo
            // 
            this.tbDt_Emprestimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDt_Emprestimo.Location = new System.Drawing.Point(16, 75);
            this.tbDt_Emprestimo.Name = "tbDt_Emprestimo";
            this.tbDt_Emprestimo.Size = new System.Drawing.Size(143, 25);
            this.tbDt_Emprestimo.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(13, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Data de Empréstimo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(13, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Tipo do Aluguel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(448, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total parcial:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.Color.White;
            this.lbValor.Location = new System.Drawing.Point(485, 480);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(50, 25);
            this.lbValor.TabIndex = 5;
            this.lbValor.Text = "0.00";
            this.lbValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(448, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "R$";
            // 
            // panelColorido1
            // 
            this.panelColorido1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panelColorido1.Controls.Add(this.listOpcionais);
            this.panelColorido1.Controls.Add(this.label18);
            this.panelColorido1.Location = new System.Drawing.Point(31, 351);
            this.panelColorido1.Name = "panelColorido1";
            this.panelColorido1.Size = new System.Drawing.Size(208, 160);
            this.panelColorido1.TabIndex = 8;
            // 
            // listOpcionais
            // 
            this.listOpcionais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOpcionais.FormattingEnabled = true;
            this.listOpcionais.ItemHeight = 17;
            this.listOpcionais.Location = new System.Drawing.Point(14, 25);
            this.listOpcionais.Name = "listOpcionais";
            this.listOpcionais.Size = new System.Drawing.Size(181, 123);
            this.listOpcionais.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(-5, -3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 25);
            this.label18.TabIndex = 9;
            this.label18.Text = "Opcionais";
            // 
            // btFecharAluguel
            // 
            this.btFecharAluguel.FlatAppearance.BorderSize = 0;
            this.btFecharAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFecharAluguel.Image = global::WindowsApp.Properties.Resources.check;
            this.btFecharAluguel.Location = new System.Drawing.Point(581, 438);
            this.btFecharAluguel.Name = "btFecharAluguel";
            this.btFecharAluguel.Size = new System.Drawing.Size(75, 72);
            this.btFecharAluguel.TabIndex = 13;
            this.btFecharAluguel.UseVisualStyleBackColor = true;
            // 
            // panelColorido2
            // 
            this.panelColorido2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panelColorido2.Location = new System.Drawing.Point(574, 438);
            this.panelColorido2.Name = "panelColorido2";
            this.panelColorido2.Size = new System.Drawing.Size(1, 72);
            this.panelColorido2.TabIndex = 9;
            // 
            // ResumoAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.panelColorido2);
            this.Controls.Add(this.panelColorido1);
            this.Controls.Add(this.btFecharAluguel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ResumoAluguel";
            this.Text = "CadastrarAluguel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelColorido1.ResumeLayout(false);
            this.panelColorido1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private Shared.PanelColorido panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.TextBox tbEndereço;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label2;
        private Shared.PanelColorido panel2;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label9;
        private Shared.PanelColorido panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btFecharAluguel;
        private System.Windows.Forms.TextBox tbDt_Emprestimo;
        private System.Windows.Forms.Label label15;
        private Shared.PanelColorido panelColorido1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox listOpcionais;
        private System.Windows.Forms.Label label17;
        private Shared.PanelColorido panelColorido2;
        private System.Windows.Forms.TextBox tbCondutor;
        private System.Windows.Forms.ComboBox tbPlano;
        private System.Windows.Forms.TextBox tbDt_Devolucao;
        private System.Windows.Forms.Label label16;

    }
}