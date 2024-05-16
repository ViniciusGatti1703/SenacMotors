namespace SenacMotors
{
    partial class Form1
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
            btnCriarCarro = new Button();
            btnAcelerar = new Button();
            btnFreiar = new Button();
            lblVelocimetro = new Label();
            lblAviso = new Label();
            SuspendLayout();
            // 
            // btnCriarCarro
            // 
            btnCriarCarro.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnCriarCarro.Location = new Point(126, 51);
            btnCriarCarro.Name = "btnCriarCarro";
            btnCriarCarro.Size = new Size(98, 35);
            btnCriarCarro.TabIndex = 0;
            btnCriarCarro.Text = "Criar Carro";
            btnCriarCarro.UseVisualStyleBackColor = true;
            btnCriarCarro.Click += btnCriarCarro_Click;
            // 
            // btnAcelerar
            // 
            btnAcelerar.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnAcelerar.Location = new Point(270, 51);
            btnAcelerar.Name = "btnAcelerar";
            btnAcelerar.Size = new Size(98, 35);
            btnAcelerar.TabIndex = 1;
            btnAcelerar.Text = "Acelerar";
            btnAcelerar.UseVisualStyleBackColor = true;
            btnAcelerar.Click += btnAcelerar_Click;
            // 
            // btnFreiar
            // 
            btnFreiar.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnFreiar.Location = new Point(431, 52);
            btnFreiar.Name = "btnFreiar";
            btnFreiar.Size = new Size(98, 35);
            btnFreiar.TabIndex = 2;
            btnFreiar.Text = "Freiar";
            btnFreiar.UseVisualStyleBackColor = true;
            // 
            // lblVelocimetro
            // 
            lblVelocimetro.AutoSize = true;
            lblVelocimetro.Location = new Point(126, 118);
            lblVelocimetro.Name = "lblVelocimetro";
            lblVelocimetro.Size = new Size(38, 15);
            lblVelocimetro.TabIndex = 3;
            lblVelocimetro.Text = "label1";
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Location = new Point(126, 171);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(38, 15);
            lblAviso.TabIndex = 4;
            lblAviso.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAviso);
            Controls.Add(lblVelocimetro);
            Controls.Add(btnFreiar);
            Controls.Add(btnAcelerar);
            Controls.Add(btnCriarCarro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCriarCarro;
        private Button btnAcelerar;
        private Button btnFreiar;
        private Label lblVelocimetro;
        private Label lblAviso;
    }
}
