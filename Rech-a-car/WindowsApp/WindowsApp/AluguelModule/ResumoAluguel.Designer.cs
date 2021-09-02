
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new WindowsApp.Shared.PanelColorido();
            this.label12 = new System.Windows.Forms.Label();
            this.panelEsconderCliente = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.cb_motoristas = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbEndereço = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new WindowsApp.Shared.PanelColorido();
            this.label13 = new System.Windows.Forms.Label();
            this.panelEsconderVeiculo = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipoCnh = new System.Windows.Forms.ComboBox();
            this.panel3 = new WindowsApp.Shared.PanelColorido();
            this.cbPlano = new System.Windows.Forms.ComboBox();
            this.tbDt_Devolucao = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDt_Emprestimo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelColorido1 = new WindowsApp.Shared.PanelColorido();
            this.bt_alterna_listas = new System.Windows.Forms.Button();
            this.bt_RemoveServico = new System.Windows.Forms.Button();
            this.bt_AddServico = new System.Windows.Forms.Button();
            this.listServicos = new System.Windows.Forms.ListBox();
            this.lb_lista_opcionais = new System.Windows.Forms.Label();
            this.panelColorido2 = new WindowsApp.Shared.PanelColorido();
            this.tipAluguel = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btFecharAluguel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelEsconderCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEsconderVeiculo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelColorido1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumo do Aluguel";
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panelEsconderCliente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbDocumento);
            this.panel1.Controls.Add(this.cb_motoristas);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbTelefone);
            this.panel1.Controls.Add(this.tbEndereço);
            this.panel1.Controls.Add(this.tbCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(41, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 208);
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-7, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(267, 32);
            this.label12.TabIndex = 7;
            this.label12.Text = "Informações do Cliente";
            // 
            // panelEsconderCliente
            // 
            this.panelEsconderCliente.Controls.Add(this.label18);
            this.panelEsconderCliente.Location = new System.Drawing.Point(13, 11);
            this.panelEsconderCliente.Margin = new System.Windows.Forms.Padding(4);
            this.panelEsconderCliente.Name = "panelEsconderCliente";
            this.panelEsconderCliente.Size = new System.Drawing.Size(791, 192);
            this.panelEsconderCliente.TabIndex = 14;
            this.panelEsconderCliente.DoubleClick += new System.EventHandler(this.panelEsconderCliente_DoubleClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(148, 80);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(482, 32);
            this.label18.TabIndex = 15;
            this.label18.Text = "Clique duas vezes para selecionar um cliente.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(336, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Documento";
            // 
            // tbDocumento
            // 
            this.tbDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocumento.Location = new System.Drawing.Point(341, 79);
            this.tbDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.ReadOnly = true;
            this.tbDocumento.Size = new System.Drawing.Size(203, 34);
            this.tbDocumento.TabIndex = 3;
            // 
            // cb_motoristas
            // 
            this.cb_motoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_motoristas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_motoristas.FormattingEnabled = true;
            this.cb_motoristas.Location = new System.Drawing.Point(568, 79);
            this.cb_motoristas.Margin = new System.Windows.Forms.Padding(4);
            this.cb_motoristas.Name = "cb_motoristas";
            this.cb_motoristas.Size = new System.Drawing.Size(223, 36);
            this.cb_motoristas.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(563, 49);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 28);
            this.label17.TabIndex = 9;
            this.label17.Text = "Condutor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(563, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cliente";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefone.Location = new System.Drawing.Point(568, 155);
            this.tbTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.ReadOnly = true;
            this.tbTelefone.Size = new System.Drawing.Size(223, 34);
            this.tbTelefone.TabIndex = 5;
            // 
            // tbEndereço
            // 
            this.tbEndereço.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereço.Location = new System.Drawing.Point(19, 155);
            this.tbEndereço.Margin = new System.Windows.Forms.Padding(4);
            this.tbEndereço.Name = "tbEndereço";
            this.tbEndereço.ReadOnly = true;
            this.tbEndereço.Size = new System.Drawing.Size(525, 34);
            this.tbEndereço.TabIndex = 2;
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(19, 79);
            this.tbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(300, 34);
            this.tbCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(176, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panelEsconderVeiculo);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.tbPlaca);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbModelo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbMarca);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbTipoCnh);
            this.panel2.Location = new System.Drawing.Point(41, 298);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 126);
            this.panel2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(-7, -4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(268, 32);
            this.label13.TabIndex = 8;
            this.label13.Text = "Informações do Veículo";
            // 
            // panelEsconderVeiculo
            // 
            this.panelEsconderVeiculo.Controls.Add(this.label19);
            this.panelEsconderVeiculo.Location = new System.Drawing.Point(12, 10);
            this.panelEsconderVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.panelEsconderVeiculo.Name = "panelEsconderVeiculo";
            this.panelEsconderVeiculo.Size = new System.Drawing.Size(791, 108);
            this.panelEsconderVeiculo.TabIndex = 16;
            this.panelEsconderVeiculo.DoubleClick += new System.EventHandler(this.panelEsconderVeiculo_DoubleClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(148, 43);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(486, 32);
            this.label19.TabIndex = 15;
            this.label19.Text = "Clique duas vezes para selecionar um veículo.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(635, 41);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 28);
            this.label20.TabIndex = 7;
            this.label20.Text = "Carteira";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlaca.Location = new System.Drawing.Point(457, 70);
            this.tbPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.ReadOnly = true;
            this.tbPlaca.Size = new System.Drawing.Size(160, 34);
            this.tbPlaca.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(452, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 28);
            this.label11.TabIndex = 7;
            this.label11.Text = "Placa";
            // 
            // tbModelo
            // 
            this.tbModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModelo.Location = new System.Drawing.Point(245, 70);
            this.tbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.ReadOnly = true;
            this.tbModelo.Size = new System.Drawing.Size(191, 34);
            this.tbModelo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(240, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Modelo";
            // 
            // tbMarca
            // 
            this.tbMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarca.Location = new System.Drawing.Point(35, 70);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.ReadOnly = true;
            this.tbMarca.Size = new System.Drawing.Size(189, 34);
            this.tbMarca.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "Marca";
            // 
            // cbTipoCnh
            // 
            this.cbTipoCnh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCnh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCnh.FormattingEnabled = true;
            this.cbTipoCnh.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "C",
            "D",
            "E"});
            this.cbTipoCnh.Location = new System.Drawing.Point(640, 70);
            this.cbTipoCnh.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoCnh.Name = "cbTipoCnh";
            this.cbTipoCnh.Size = new System.Drawing.Size(141, 36);
            this.cbTipoCnh.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.cbPlano);
            this.panel3.Controls.Add(this.tbDt_Devolucao);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tbDt_Emprestimo);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(341, 432);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 197);
            this.panel3.TabIndex = 3;
            // 
            // cbPlano
            // 
            this.cbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlano.FormattingEnabled = true;
            this.cbPlano.Items.AddRange(new object[] {
            "Diário",
            "Controlado",
            "Livre"});
            this.cbPlano.Location = new System.Drawing.Point(21, 33);
            this.cbPlano.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlano.Name = "cbPlano";
            this.cbPlano.Size = new System.Drawing.Size(189, 29);
            this.cbPlano.TabIndex = 10;
            this.cbPlano.SelectedIndexChanged += new System.EventHandler(this.cbPlano_SelectedIndexChanged);
            // 
            // tbDt_Devolucao
            // 
            this.tbDt_Devolucao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDt_Devolucao.Location = new System.Drawing.Point(21, 151);
            this.tbDt_Devolucao.Margin = new System.Windows.Forms.Padding(4);
            this.tbDt_Devolucao.Mask = "00/00/0000";
            this.tbDt_Devolucao.Name = "tbDt_Devolucao";
            this.tbDt_Devolucao.Size = new System.Drawing.Size(189, 29);
            this.tbDt_Devolucao.TabIndex = 12;
            this.tbDt_Devolucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDt_Devolucao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.tbDt_Devolucao.ValidatingType = typeof(System.DateTime);
            this.tbDt_Devolucao.TextChanged += new System.EventHandler(this.tbDt_Devolucao_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(17, 127);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 23);
            this.label16.TabIndex = 7;
            this.label16.Text = "Data de Devolução";
            // 
            // tbDt_Emprestimo
            // 
            this.tbDt_Emprestimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDt_Emprestimo.Location = new System.Drawing.Point(21, 92);
            this.tbDt_Emprestimo.Margin = new System.Windows.Forms.Padding(4);
            this.tbDt_Emprestimo.Mask = "00/00/0000";
            this.tbDt_Emprestimo.Name = "tbDt_Emprestimo";
            this.tbDt_Emprestimo.Size = new System.Drawing.Size(189, 29);
            this.tbDt_Emprestimo.TabIndex = 11;
            this.tbDt_Emprestimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDt_Emprestimo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.tbDt_Emprestimo.ValidatingType = typeof(System.DateTime);
            this.tbDt_Emprestimo.TextChanged += new System.EventHandler(this.tbDt_Emprestimo_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(17, 68);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 23);
            this.label15.TabIndex = 7;
            this.label15.Text = "Data de Empréstimo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(17, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "Tipo do Aluguel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(597, 551);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total parcial:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.Color.White;
            this.lbValor.Location = new System.Drawing.Point(647, 591);
            this.lbValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(60, 32);
            this.lbValor.TabIndex = 5;
            this.lbValor.Text = "0.00";
            this.lbValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(597, 591);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "R$";
            // 
            // panelColorido1
            // 
            this.panelColorido1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panelColorido1.Controls.Add(this.bt_alterna_listas);
            this.panelColorido1.Controls.Add(this.bt_RemoveServico);
            this.panelColorido1.Controls.Add(this.bt_AddServico);
            this.panelColorido1.Controls.Add(this.listServicos);
            this.panelColorido1.Controls.Add(this.lb_lista_opcionais);
            this.panelColorido1.Location = new System.Drawing.Point(41, 432);
            this.panelColorido1.Margin = new System.Windows.Forms.Padding(4);
            this.panelColorido1.Name = "panelColorido1";
            this.panelColorido1.Size = new System.Drawing.Size(287, 197);
            this.panelColorido1.TabIndex = 8;
            // 
            // bt_alterna_listas
            // 
            this.bt_alterna_listas.FlatAppearance.BorderSize = 0;
            this.bt_alterna_listas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterna_listas.Image = global::WindowsApp.Properties.Resources.trocar;
            this.bt_alterna_listas.Location = new System.Drawing.Point(224, 9);
            this.bt_alterna_listas.Margin = new System.Windows.Forms.Padding(4);
            this.bt_alterna_listas.Name = "bt_alterna_listas";
            this.bt_alterna_listas.Size = new System.Drawing.Size(48, 41);
            this.bt_alterna_listas.TabIndex = 17;
            this.bt_alterna_listas.UseVisualStyleBackColor = true;
            this.bt_alterna_listas.Click += new System.EventHandler(this.bt_alterna_listas_Click);
            // 
            // bt_RemoveServico
            // 
            this.bt_RemoveServico.FlatAppearance.BorderSize = 0;
            this.bt_RemoveServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_RemoveServico.Image = global::WindowsApp.Properties.Resources.removemini;
            this.bt_RemoveServico.Location = new System.Drawing.Point(224, 119);
            this.bt_RemoveServico.Margin = new System.Windows.Forms.Padding(4);
            this.bt_RemoveServico.Name = "bt_RemoveServico";
            this.bt_RemoveServico.Size = new System.Drawing.Size(48, 43);
            this.bt_RemoveServico.TabIndex = 16;
            this.bt_RemoveServico.UseVisualStyleBackColor = true;
            this.bt_RemoveServico.Click += new System.EventHandler(this.bt_RemoveServico_Click);
            // 
            // bt_AddServico
            // 
            this.bt_AddServico.FlatAppearance.BorderSize = 0;
            this.bt_AddServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddServico.Image = global::WindowsApp.Properties.Resources.addmini;
            this.bt_AddServico.Location = new System.Drawing.Point(224, 68);
            this.bt_AddServico.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddServico.Name = "bt_AddServico";
            this.bt_AddServico.Size = new System.Drawing.Size(48, 44);
            this.bt_AddServico.TabIndex = 15;
            this.bt_AddServico.UseVisualStyleBackColor = true;
            this.bt_AddServico.Click += new System.EventHandler(this.bt_AddServico_Click);
            // 
            // listServicos
            // 
            this.listServicos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listServicos.FormattingEnabled = true;
            this.listServicos.ItemHeight = 21;
            this.listServicos.Location = new System.Drawing.Point(13, 52);
            this.listServicos.Margin = new System.Windows.Forms.Padding(4);
            this.listServicos.Name = "listServicos";
            this.listServicos.Size = new System.Drawing.Size(201, 130);
            this.listServicos.TabIndex = 11;
            this.listServicos.SelectedValueChanged += new System.EventHandler(this.listServicos_SelectedValueChanged);
            // 
            // lb_lista_opcionais
            // 
            this.lb_lista_opcionais.AutoSize = true;
            this.lb_lista_opcionais.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lista_opcionais.ForeColor = System.Drawing.Color.White;
            this.lb_lista_opcionais.Location = new System.Drawing.Point(-7, -4);
            this.lb_lista_opcionais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lista_opcionais.Name = "lb_lista_opcionais";
            this.lb_lista_opcionais.Size = new System.Drawing.Size(121, 32);
            this.lb_lista_opcionais.TabIndex = 9;
            this.lb_lista_opcionais.Text = "Opcionais";
            // 
            // panelColorido2
            // 
            this.panelColorido2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panelColorido2.Location = new System.Drawing.Point(765, 539);
            this.panelColorido2.Margin = new System.Windows.Forms.Padding(4);
            this.panelColorido2.Name = "panelColorido2";
            this.panelColorido2.Size = new System.Drawing.Size(1, 89);
            this.panelColorido2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsApp.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(831, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btFecharAluguel
            // 
            this.btFecharAluguel.FlatAppearance.BorderSize = 0;
            this.btFecharAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFecharAluguel.Image = global::WindowsApp.Properties.Resources.check;
            this.btFecharAluguel.Location = new System.Drawing.Point(775, 539);
            this.btFecharAluguel.Margin = new System.Windows.Forms.Padding(4);
            this.btFecharAluguel.Name = "btFecharAluguel";
            this.btFecharAluguel.Size = new System.Drawing.Size(100, 89);
            this.btFecharAluguel.TabIndex = 13;
            this.btFecharAluguel.UseVisualStyleBackColor = true;
            this.btFecharAluguel.Click += new System.EventHandler(this.btFecharAluguel_Click);
            // 
            // ResumoAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(891, 642);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResumoAluguel";
            this.Text = "CadastrarAluguel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEsconderCliente.ResumeLayout(false);
            this.panelEsconderCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEsconderVeiculo.ResumeLayout(false);
            this.panelEsconderVeiculo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelColorido1.ResumeLayout(false);
            this.panelColorido1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox tbDt_Emprestimo;
        private System.Windows.Forms.Label label15;
        private Shared.PanelColorido panelColorido1;
        private System.Windows.Forms.Label lb_lista_opcionais;
        private System.Windows.Forms.ListBox listServicos;
        private System.Windows.Forms.Label label17;
        private Shared.PanelColorido panelColorido2;
        private System.Windows.Forms.ComboBox cbPlano;
        private System.Windows.Forms.MaskedTextBox tbDt_Devolucao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_motoristas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tipAluguel;
        private System.Windows.Forms.Button bt_RemoveServico;
        private System.Windows.Forms.Button bt_AddServico;
        private System.Windows.Forms.Button bt_alterna_listas;
        private System.Windows.Forms.Panel panelEsconderCliente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelEsconderVeiculo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbTipoCnh;
    }
}