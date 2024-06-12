namespace CaixaEletronico
{
    partial class frmDeposito
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
            label1 = new Label();
            Btn_enviar = new Button();
            nrm_depositar = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nrm_depositar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(315, 256);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 0;
            label1.Text = "Depositar:";
            // 
            // Btn_enviar
            // 
            Btn_enviar.Font = new Font("Segoe UI", 15F);
            Btn_enviar.Location = new Point(583, 331);
            Btn_enviar.Name = "Btn_enviar";
            Btn_enviar.Size = new Size(102, 41);
            Btn_enviar.TabIndex = 2;
            Btn_enviar.Text = "Enviar";
            Btn_enviar.UseVisualStyleBackColor = true;
            Btn_enviar.Click += Btn_enviar_Click;
            // 
            // nrm_depositar
            // 
            nrm_depositar.Font = new Font("Segoe UI", 20F);
            nrm_depositar.Location = new Point(459, 256);
            nrm_depositar.Name = "nrm_depositar";
            nrm_depositar.Size = new Size(390, 43);
            nrm_depositar.TabIndex = 3;
            nrm_depositar.ValueChanged += nrm_depositar_ValueChanged;
            // 
            // frmDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 640);
            Controls.Add(nrm_depositar);
            Controls.Add(Btn_enviar);
            Controls.Add(label1);
            Name = "frmDeposito";
            Text = "frmDeposito";
            ((System.ComponentModel.ISupportInitialize)nrm_depositar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Btn_enviar;
        private NumericUpDown nrm_depositar;
    }
}