namespace BuscaCEPWP
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
            txtEstado = new TextBox();
            txtCidade = new TextBox();
            txtLogradouro = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            maskCEP = new MaskedTextBox();
            txtComplemento2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(130, 222);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(258, 23);
            txtEstado.TabIndex = 1;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(130, 288);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(258, 23);
            txtCidade.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(130, 408);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(258, 23);
            txtLogradouro.TabIndex = 4;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(130, 350);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(258, 23);
            txtBairro.TabIndex = 3;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(130, 543);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(258, 23);
            txtComplemento.TabIndex = 6;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(130, 474);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(258, 23);
            txtNumero.TabIndex = 5;
            // 
            // maskCEP
            // 
            maskCEP.Location = new Point(130, 175);
            maskCEP.Mask = "00000-000";
            maskCEP.Name = "maskCEP";
            maskCEP.Size = new Size(258, 23);
            maskCEP.TabIndex = 0;
            maskCEP.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskCEP.Leave += maskCep_Leave;
            // 
            // txtComplemento2
            // 
            txtComplemento2.Location = new Point(130, 602);
            txtComplemento2.Name = "txtComplemento2";
            txtComplemento2.Size = new Size(258, 23);
            txtComplemento2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 175);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 8;
            label1.Text = "CEP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 222);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 9;
            label2.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 288);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 10;
            label3.Text = "Cidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(57, 350);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 11;
            label4.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 408);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 12;
            label5.Text = "Logradouro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(46, 474);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 13;
            label6.Text = "Número";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 543);
            label7.Name = "label7";
            label7.Size = new Size(101, 19);
            label7.TabIndex = 14;
            label7.Text = "Complemento";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 602);
            label8.Name = "label8";
            label8.Size = new Size(109, 19);
            label8.TabIndex = 15;
            label8.Text = "Complemento2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 96);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(57, 112);
            label9.Name = "label9";
            label9.Size = new Size(436, 31);
            label9.TabIndex = 17;
            label9.Text = "BUSCACEP - EVOLUTION SENAI";
            // 
            // button1
            // 
            button1.Location = new Point(451, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.KeyPress += button1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 238, 242);
            ClientSize = new Size(538, 660);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtComplemento2);
            Controls.Add(maskCEP);
            Controls.Add(txtNumero);
            Controls.Add(txtComplemento);
            Controls.Add(txtBairro);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCidade);
            Controls.Add(txtEstado);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtEstado;
        private TextBox txtCidade;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private MaskedTextBox maskCEP;
        private TextBox txtComplemento2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Button button1;
    }
}