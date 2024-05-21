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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCriarCarro = new Button();
            btnAcelerar = new Button();
            btnFreiar = new Button();
            lblVelocimetro = new Label();
            lblAviso = new Label();
            lblMarcha = new Label();
            btnSobeMarcha = new Button();
            btnDesceMarcha = new Button();
            btnVirarDireita = new Button();
            btnVirarEsquerda = new Button();
            btnCriarMoto = new Button();
            SuspendLayout();
            // 
            // btnCriarCarro
            // 
            btnCriarCarro.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnCriarCarro.Location = new Point(12, 41);
            btnCriarCarro.Name = "btnCriarCarro";
            btnCriarCarro.Size = new Size(116, 35);
            btnCriarCarro.TabIndex = 0;
            btnCriarCarro.Text = "Criar Carro";
            btnCriarCarro.UseVisualStyleBackColor = true;
            btnCriarCarro.Click += btnCriarCarro_Click;
            // 
            // btnAcelerar
            // 
            btnAcelerar.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnAcelerar.Location = new Point(186, 41);
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
            btnFreiar.Location = new Point(334, 41);
            btnFreiar.Name = "btnFreiar";
            btnFreiar.Size = new Size(98, 35);
            btnFreiar.TabIndex = 2;
            btnFreiar.Text = "Freiar";
            btnFreiar.UseVisualStyleBackColor = true;
            btnFreiar.Click += btnFreiar_Click;
            // 
            // lblVelocimetro
            // 
            lblVelocimetro.AutoSize = true;
            lblVelocimetro.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVelocimetro.Location = new Point(278, 146);
            lblVelocimetro.Name = "lblVelocimetro";
            lblVelocimetro.Size = new Size(92, 23);
            lblVelocimetro.TabIndex = 3;
            lblVelocimetro.Text = "Velocimetro";
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Font = new Font("Arial Narrow", 14.25F);
            lblAviso.Location = new Point(312, 211);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(47, 23);
            lblAviso.TabIndex = 4;
            lblAviso.Text = "Aviso";
            // 
            // lblMarcha
            // 
            lblMarcha.AutoSize = true;
            lblMarcha.Font = new Font("Arial Narrow", 14.25F);
            lblMarcha.Location = new Point(301, 178);
            lblMarcha.Name = "lblMarcha";
            lblMarcha.Size = new Size(63, 23);
            lblMarcha.TabIndex = 5;
            lblMarcha.Text = "Marcha";
            // 
            // btnSobeMarcha
            // 
            btnSobeMarcha.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnSobeMarcha.Location = new Point(500, 41);
            btnSobeMarcha.Name = "btnSobeMarcha";
            btnSobeMarcha.Size = new Size(98, 35);
            btnSobeMarcha.TabIndex = 6;
            btnSobeMarcha.Text = "Marcha +";
            btnSobeMarcha.UseVisualStyleBackColor = true;
            btnSobeMarcha.Click += btnSobeMarcha_Click;
            // 
            // btnDesceMarcha
            // 
            btnDesceMarcha.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnDesceMarcha.Location = new Point(500, 163);
            btnDesceMarcha.Name = "btnDesceMarcha";
            btnDesceMarcha.Size = new Size(98, 35);
            btnDesceMarcha.TabIndex = 7;
            btnDesceMarcha.Text = "Marcha -";
            btnDesceMarcha.UseVisualStyleBackColor = true;
            btnDesceMarcha.Click += btnDesceMarcha_Click;
            // 
            // btnVirarDireita
            // 
            btnVirarDireita.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnVirarDireita.Location = new Point(500, 317);
            btnVirarDireita.Name = "btnVirarDireita";
            btnVirarDireita.Size = new Size(98, 35);
            btnVirarDireita.TabIndex = 8;
            btnVirarDireita.Text = "Direita";
            btnVirarDireita.UseVisualStyleBackColor = true;
            btnVirarDireita.Click += btnVirarDireita_Click;
            // 
            // btnVirarEsquerda
            // 
            btnVirarEsquerda.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnVirarEsquerda.Location = new Point(12, 317);
            btnVirarEsquerda.Name = "btnVirarEsquerda";
            btnVirarEsquerda.Size = new Size(98, 35);
            btnVirarEsquerda.TabIndex = 9;
            btnVirarEsquerda.Text = "Esquerda";
            btnVirarEsquerda.UseVisualStyleBackColor = true;
            btnVirarEsquerda.Click += btnVirarEsquerda_Click;
            // 
            // btnCriarMoto
            // 
            btnCriarMoto.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnCriarMoto.Location = new Point(12, 124);
            btnCriarMoto.Name = "btnCriarMoto";
            btnCriarMoto.Size = new Size(116, 35);
            btnCriarMoto.TabIndex = 10;
            btnCriarMoto.Text = "Criar Moto";
            btnCriarMoto.UseVisualStyleBackColor = true;
            btnCriarMoto.Click += btnCriarMoto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCriarMoto);
            Controls.Add(btnVirarEsquerda);
            Controls.Add(btnVirarDireita);
            Controls.Add(btnDesceMarcha);
            Controls.Add(btnSobeMarcha);
            Controls.Add(lblMarcha);
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
        private Label lblMarcha;
        private Button btnSobeMarcha;
        private Button btnDesceMarcha;
        private Button btnVirarDireita;
        private Button btnVirarEsquerda;
        private Button btnCriarMoto;
    }
}
