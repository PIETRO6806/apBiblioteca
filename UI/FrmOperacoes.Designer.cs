﻿namespace apBiblioteca_22132_22148.UI
{
    partial class FrmOperacoes
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataDeDevolucaoPrevista = new System.Windows.Forms.TextBox();
            this.txtDataDeEmprestimo = new System.Windows.Forms.TextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtIdEmprestimo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDevolucoes = new System.Windows.Forms.DataGridView();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage3.Controls.Add(this.dgvEmprestimos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Empréstimos";
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Location = new System.Drawing.Point(6, 6);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.ReadOnly = true;
            this.dgvEmprestimos.Size = new System.Drawing.Size(756, 391);
            this.dgvEmprestimos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage1.Controls.Add(this.btnDevolver);
            this.tabPage1.Controls.Add(this.btnProcurar);
            this.tabPage1.Controls.Add(this.btnExibir);
            this.tabPage1.Controls.Add(this.btnRenovar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDataDeDevolucaoPrevista);
            this.tabPage1.Controls.Add(this.txtDataDeEmprestimo);
            this.tabPage1.Controls.Add(this.txtIdLeitor);
            this.tabPage1.Controls.Add(this.txtIdLivro);
            this.tabPage1.Controls.Add(this.txtIdEmprestimo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operações";
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(233, 266);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 16;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(318, 12);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 15;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(635, 266);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 14;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnRenovar
            // 
            this.btnRenovar.Location = new System.Drawing.Point(450, 266);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(75, 23);
            this.btnRenovar.TabIndex = 13;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(20, 266);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Devolução Prevista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data do Empréstimo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id do Leitor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id do Livro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identificação:";
            // 
            // txtDataDeDevolucaoPrevista
            // 
            this.txtDataDeDevolucaoPrevista.Location = new System.Drawing.Point(166, 145);
            this.txtDataDeDevolucaoPrevista.Name = "txtDataDeDevolucaoPrevista";
            this.txtDataDeDevolucaoPrevista.ReadOnly = true;
            this.txtDataDeDevolucaoPrevista.Size = new System.Drawing.Size(100, 20);
            this.txtDataDeDevolucaoPrevista.TabIndex = 4;
            // 
            // txtDataDeEmprestimo
            // 
            this.txtDataDeEmprestimo.Location = new System.Drawing.Point(166, 108);
            this.txtDataDeEmprestimo.Name = "txtDataDeEmprestimo";
            this.txtDataDeEmprestimo.ReadOnly = true;
            this.txtDataDeEmprestimo.Size = new System.Drawing.Size(100, 20);
            this.txtDataDeEmprestimo.TabIndex = 3;
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(166, 76);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(100, 20);
            this.txtIdLeitor.TabIndex = 2;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(166, 46);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(100, 20);
            this.txtIdLivro.TabIndex = 1;
            // 
            // txtIdEmprestimo
            // 
            this.txtIdEmprestimo.Location = new System.Drawing.Point(166, 14);
            this.txtIdEmprestimo.Name = "txtIdEmprestimo";
            this.txtIdEmprestimo.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmprestimo.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.Controls.Add(this.dgvDevolucoes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Devoluções";
            // 
            // dgvDevolucoes
            // 
            this.dgvDevolucoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucoes.Location = new System.Drawing.Point(6, 6);
            this.dgvDevolucoes.Name = "dgvDevolucoes";
            this.dgvDevolucoes.Size = new System.Drawing.Size(756, 388);
            this.dgvDevolucoes.TabIndex = 0;
            // 
            // FrmOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmOperacoes";
            this.Text = "Empréstimo e Devolução de Livros";
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataDeDevolucaoPrevista;
        private System.Windows.Forms.TextBox txtDataDeEmprestimo;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtIdEmprestimo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDevolucoes;
    }
}