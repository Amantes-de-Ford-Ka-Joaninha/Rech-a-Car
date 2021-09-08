﻿
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    partial class FechamentoAluguel
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
            this.btFecharAluguel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelColorido3 = new WindowsApp.Shared.PanelColorido();
            this.panelColorido2 = new WindowsApp.Shared.PanelColorido();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_KmFinal = new System.Windows.Forms.TextBox();
            this.panelColorido1 = new WindowsApp.Shared.PanelColorido();
            this.mtb_PrecoDespesa = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NomeDespesa = new System.Windows.Forms.TextBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.listDespesas = new System.Windows.Forms.ListBox();
            this.bt_RemoveDespesa = new System.Windows.Forms.Button();
            this.bt_AddDespesa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelColorido2.SuspendLayout();
            this.panelColorido1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fechamento do Aluguel";
            // 
            // btFecharAluguel
            // 
            this.btFecharAluguel.FlatAppearance.BorderSize = 0;
            this.btFecharAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFecharAluguel.Image = global::WindowsApp.Properties.Resources.check;
            this.btFecharAluguel.Location = new System.Drawing.Point(775, 539);
            this.btFecharAluguel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFecharAluguel.Name = "btFecharAluguel";
            this.btFecharAluguel.Size = new System.Drawing.Size(100, 89);
            this.btFecharAluguel.TabIndex = 4;
            this.btFecharAluguel.UseVisualStyleBackColor = true;
            this.btFecharAluguel.Click += new System.EventHandler(this.btFecharAluguel_Click);
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
            this.label4.TabIndex = 16;
            this.label4.Text = "R$";
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
            this.lbValor.TabIndex = 15;
            this.lbValor.Text = "0.00";
            this.lbValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(599, 553);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Valor Final:";
            // 
            // panelColorido3
            // 
            this.panelColorido3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panelColorido3.Location = new System.Drawing.Point(765, 539);
            this.panelColorido3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelColorido3.Name = "panelColorido3";
            this.panelColorido3.Size = new System.Drawing.Size(1, 89);
            this.panelColorido3.TabIndex = 17;
            // 
            // panelColorido2
            // 
            this.panelColorido2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panelColorido2.Controls.Add(this.label8);
            this.panelColorido2.Controls.Add(this.label9);
            this.panelColorido2.Controls.Add(this.tb_KmFinal);
            this.panelColorido2.Location = new System.Drawing.Point(60, 74);
            this.panelColorido2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelColorido2.Name = "panelColorido2";
            this.panelColorido2.Size = new System.Drawing.Size(768, 150);
            this.panelColorido2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-7, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Configurações";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(287, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Odômetro";
            // 
            // tb_KmFinal
            // 
            this.tb_KmFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KmFinal.Location = new System.Drawing.Point(292, 80);
            this.tb_KmFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_KmFinal.Name = "tb_KmFinal";
            this.tb_KmFinal.Size = new System.Drawing.Size(189, 34);
            this.tb_KmFinal.TabIndex = 2;
            this.tb_KmFinal.TextChanged += new System.EventHandler(this.tb_KmFinal_TextChanged);
            // 
            // panelColorido1
            // 
            this.panelColorido1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panelColorido1.Controls.Add(this.mtb_PrecoDespesa);
            this.panelColorido1.Controls.Add(this.label2);
            this.panelColorido1.Controls.Add(this.tb_NomeDespesa);
            this.panelColorido1.Controls.Add(this.lb_Titulo);
            this.panelColorido1.Controls.Add(this.listDespesas);
            this.panelColorido1.Controls.Add(this.bt_RemoveDespesa);
            this.panelColorido1.Controls.Add(this.bt_AddDespesa);
            this.panelColorido1.Controls.Add(this.label7);
            this.panelColorido1.Location = new System.Drawing.Point(60, 242);
            this.panelColorido1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelColorido1.Name = "panelColorido1";
            this.panelColorido1.Size = new System.Drawing.Size(768, 212);
            this.panelColorido1.TabIndex = 6;
            // 
            // mtb_PrecoDespesa
            // 
            this.mtb_PrecoDespesa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtb_PrecoDespesa.Location = new System.Drawing.Point(64, 153);
            this.mtb_PrecoDespesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtb_PrecoDespesa.Name = "mtb_PrecoDespesa";
            this.mtb_PrecoDespesa.Size = new System.Drawing.Size(132, 34);
            this.mtb_PrecoDespesa.TabIndex = 24;
            this.mtb_PrecoDespesa.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Preço (R$)";
            // 
            // tb_NomeDespesa
            // 
            this.tb_NomeDespesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NomeDespesa.Location = new System.Drawing.Point(64, 75);
            this.tb_NomeDespesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_NomeDespesa.Name = "tb_NomeDespesa";
            this.tb_NomeDespesa.Size = new System.Drawing.Size(208, 34);
            this.tb_NomeDespesa.TabIndex = 22;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.ForeColor = System.Drawing.Color.White;
            this.lb_Titulo.Location = new System.Drawing.Point(59, 46);
            this.lb_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(88, 28);
            this.lb_Titulo.TabIndex = 21;
            this.lb_Titulo.Text = "Despesa";
            // 
            // listDespesas
            // 
            this.listDespesas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDespesas.FormattingEnabled = true;
            this.listDespesas.ItemHeight = 25;
            this.listDespesas.Location = new System.Drawing.Point(320, 36);
            this.listDespesas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listDespesas.Name = "listDespesas";
            this.listDespesas.Size = new System.Drawing.Size(329, 129);
            this.listDespesas.TabIndex = 18;
            // 
            // bt_RemoveDespesa
            // 
            this.bt_RemoveDespesa.FlatAppearance.BorderSize = 0;
            this.bt_RemoveDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_RemoveDespesa.Image = global::WindowsApp.Properties.Resources.removemini;
            this.bt_RemoveDespesa.Location = new System.Drawing.Point(659, 86);
            this.bt_RemoveDespesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_RemoveDespesa.Name = "bt_RemoveDespesa";
            this.bt_RemoveDespesa.Size = new System.Drawing.Size(48, 43);
            this.bt_RemoveDespesa.TabIndex = 19;
            this.bt_RemoveDespesa.UseVisualStyleBackColor = true;
            this.bt_RemoveDespesa.Click += new System.EventHandler(this.bt_RemoveDespesa_Click);
            // 
            // bt_AddDespesa
            // 
            this.bt_AddDespesa.FlatAppearance.BorderSize = 0;
            this.bt_AddDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddDespesa.Image = global::WindowsApp.Properties.Resources.addmini;
            this.bt_AddDespesa.Location = new System.Drawing.Point(225, 149);
            this.bt_AddDespesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_AddDespesa.Name = "bt_AddDespesa";
            this.bt_AddDespesa.Size = new System.Drawing.Size(48, 44);
            this.bt_AddDespesa.TabIndex = 18;
            this.bt_AddDespesa.UseVisualStyleBackColor = true;
            this.bt_AddDespesa.Click += new System.EventHandler(this.bt_AddDespesa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-7, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Checklist";
            // 
            // FechamentoAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(891, 642);
            this.Controls.Add(this.panelColorido3);
            this.Controls.Add(this.btFecharAluguel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelColorido2);
            this.Controls.Add(this.panelColorido1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FechamentoAluguel";
            this.Text = "FechamentoAluguel";
            this.panelColorido2.ResumeLayout(false);
            this.panelColorido2.PerformLayout();
            this.panelColorido1.ResumeLayout(false);
            this.panelColorido1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelColorido panelColorido2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_KmFinal;
        private PanelColorido panelColorido1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private PanelColorido panelColorido3;
        private System.Windows.Forms.Button btFecharAluguel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_RemoveDespesa;
        private System.Windows.Forms.Button bt_AddDespesa;
        private System.Windows.Forms.ListBox listDespesas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NomeDespesa;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.MaskedTextBox mtb_PrecoDespesa;
    }
}