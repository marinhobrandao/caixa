namespace CaixaEletronico
{
    partial class frmPrincipal
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
            Btn_voltar = new Button();
            Btn_depositar = new Button();
            Btn_sacar = new Button();
            Btn_transferir = new Button();
            Btn_extrato = new Button();
            saldoAtual = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)saldoAtual).BeginInit();
            SuspendLayout();
            // 
            // Btn_voltar
            // 
            Btn_voltar.Font = new Font("Tw Cen MT", 20F);
            Btn_voltar.Location = new Point(28, 21);
            Btn_voltar.Name = "Btn_voltar";
            Btn_voltar.Size = new Size(174, 43);
            Btn_voltar.TabIndex = 2;
            Btn_voltar.Text = "Voltar";
            Btn_voltar.UseVisualStyleBackColor = true;
            Btn_voltar.Click += Btn_voltar_Click;
            // 
            // Btn_depositar
            // 
            Btn_depositar.Font = new Font("Tw Cen MT", 20F);
            Btn_depositar.Location = new Point(382, 283);
            Btn_depositar.Name = "Btn_depositar";
            Btn_depositar.Size = new Size(552, 43);
            Btn_depositar.TabIndex = 3;
            Btn_depositar.Text = "Depositar";
            Btn_depositar.UseVisualStyleBackColor = true;
            Btn_depositar.Click += Btn_depositar_Click;
            // 
            // Btn_sacar
            // 
            Btn_sacar.Font = new Font("Tw Cen MT", 20F);
            Btn_sacar.Location = new Point(382, 353);
            Btn_sacar.Name = "Btn_sacar";
            Btn_sacar.Size = new Size(547, 43);
            Btn_sacar.TabIndex = 4;
            Btn_sacar.Text = "Sacar";
            Btn_sacar.UseVisualStyleBackColor = true;
            Btn_sacar.Click += Btn_sacar_Click;
            // 
            // Btn_transferir
            // 
            Btn_transferir.Font = new Font("Tw Cen MT", 20F);
            Btn_transferir.Location = new Point(382, 428);
            Btn_transferir.Name = "Btn_transferir";
            Btn_transferir.Size = new Size(547, 43);
            Btn_transferir.TabIndex = 5;
            Btn_transferir.Text = "Transferir";
            Btn_transferir.UseVisualStyleBackColor = true;
            Btn_transferir.Click += Btn_transferir_Click;
            // 
            // Btn_extrato
            // 
            Btn_extrato.Font = new Font("Tw Cen MT", 20F);
            Btn_extrato.Location = new Point(382, 509);
            Btn_extrato.Name = "Btn_extrato";
            Btn_extrato.Size = new Size(547, 43);
            Btn_extrato.TabIndex = 6;
            Btn_extrato.Text = "Ver Extrato";
            Btn_extrato.UseVisualStyleBackColor = true;
            Btn_extrato.Click += Btn_extrato_Click;
            // 
            // saldoAtual
            // 
            saldoAtual.Font = new Font("Tw Cen MT", 15F);
            saldoAtual.Location = new Point(1018, 36);
            saldoAtual.Name = "saldoAtual";
            saldoAtual.Size = new Size(120, 29);
            saldoAtual.TabIndex = 7;
            saldoAtual.ValueChanged += saldoAtual_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 20F);
            label1.Location = new Point(927, 36);
            label1.Name = "label1";
            label1.Size = new Size(84, 31);
            label1.TabIndex = 8;
            label1.Text = "Saldo:";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(label1);
            Controls.Add(saldoAtual);
            Controls.Add(Btn_extrato);
            Controls.Add(Btn_transferir);
            Controls.Add(Btn_sacar);
            Controls.Add(Btn_depositar);
            Controls.Add(Btn_voltar);
            Font = new Font("Tw Cen MT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início - Caixa Eletrônico";
            ((System.ComponentModel.ISupportInitialize)saldoAtual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_voltar;
        private Button Btn_depositar;
        private Button Btn_sacar;
        private Button Btn_transferir;
        private Button Btn_extrato;
        private NumericUpDown saldoAtual;
        private Label label1;
    }
}