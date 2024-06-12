namespace CaixaEletronico
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBemVindo = new Label();
            lblSenha = new Label();
            Bnt_acessar = new Button();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Tw Cen MT", 30F);
            lblBemVindo.Location = new Point(487, 53);
            lblBemVindo.Margin = new Padding(2, 0, 2, 0);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(324, 47);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Seja bem-vindo(a)!";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Tw Cen MT", 24F);
            lblSenha.Location = new Point(317, 277);
            lblSenha.Margin = new Padding(2, 0, 2, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 37);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Conta:";
            // 
            // Bnt_acessar
            // 
            Bnt_acessar.BackColor = SystemColors.ActiveBorder;
            Bnt_acessar.FlatStyle = FlatStyle.Flat;
            Bnt_acessar.Font = new Font("Tw Cen MT", 20F);
            Bnt_acessar.Location = new Point(582, 352);
            Bnt_acessar.Margin = new Padding(2, 3, 2, 3);
            Bnt_acessar.Name = "Bnt_acessar";
            Bnt_acessar.Size = new Size(169, 62);
            Bnt_acessar.TabIndex = 6;
            Bnt_acessar.Text = "Acessar";
            Bnt_acessar.UseVisualStyleBackColor = false;
            Bnt_acessar.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Tw Cen MT", 20F);
            maskedTextBox1.Location = new Point(487, 279);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(375, 37);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(maskedTextBox1);
            Controls.Add(Bnt_acessar);
            Controls.Add(lblSenha);
            Controls.Add(lblBemVindo);
            Font = new Font("Tw Cen MT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 3, 2, 3);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Caixa Eletrônico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBemVindo;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txtLogin;
        private Button Bnt_acessar;
        private Button btnLogar;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
    }
}
