namespace CalculadoraVetorial
{
    partial class frmProdutoEscalar
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
            btnRetorno = new Button();
            label1 = new Label();
            pnlResultado = new Panel();
            txtResultado = new TextBox();
            label10 = new Label();
            btnCalcular = new Button();
            txtVz = new TextBox();
            txtUz = new TextBox();
            txtVy = new TextBox();
            txtUy = new TextBox();
            txtVx = new TextBox();
            label9 = new Label();
            txtUx = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            pnlResultado.SuspendLayout();
            SuspendLayout();
            // 
            // btnRetorno
            // 
            btnRetorno.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetorno.Location = new Point(12, 12);
            btnRetorno.Name = "btnRetorno";
            btnRetorno.Size = new Size(60, 33);
            btnRetorno.TabIndex = 0;
            btnRetorno.Text = "<";
            btnRetorno.UseVisualStyleBackColor = true;
            btnRetorno.Click += btnRetorno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 8);
            label1.Name = "label1";
            label1.Size = new Size(402, 37);
            label1.TabIndex = 1;
            label1.Text = "Calculadora - Produto Escalar";
            // 
            // pnlResultado
            // 
            pnlResultado.Controls.Add(txtResultado);
            pnlResultado.Controls.Add(label10);
            pnlResultado.Location = new Point(245, 85);
            pnlResultado.Name = "pnlResultado";
            pnlResultado.Size = new Size(269, 257);
            pnlResultado.TabIndex = 22;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(56, 21);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 26);
            txtResultado.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(7, 17);
            label10.Name = "label10";
            label10.Size = new Size(43, 22);
            label10.TabIndex = 0;
            label10.Text = "u * v";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(203, 392);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 32);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // txtVz
            // 
            txtVz.Font = new Font("Trebuchet MS", 12F);
            txtVz.Location = new Point(84, 311);
            txtVz.Name = "txtVz";
            txtVz.Size = new Size(100, 26);
            txtVz.TabIndex = 6;
            // 
            // txtUz
            // 
            txtUz.Font = new Font("Trebuchet MS", 12F);
            txtUz.Location = new Point(84, 162);
            txtUz.Name = "txtUz";
            txtUz.Size = new Size(100, 26);
            txtUz.TabIndex = 3;
            // 
            // txtVy
            // 
            txtVy.Font = new Font("Trebuchet MS", 12F);
            txtVy.Location = new Point(84, 282);
            txtVy.Name = "txtVy";
            txtVy.Size = new Size(100, 26);
            txtVy.TabIndex = 5;
            // 
            // txtUy
            // 
            txtUy.Font = new Font("Trebuchet MS", 12F);
            txtUy.Location = new Point(84, 133);
            txtUy.Name = "txtUy";
            txtUy.Size = new Size(100, 26);
            txtUy.TabIndex = 2;
            // 
            // txtVx
            // 
            txtVx.Font = new Font("Trebuchet MS", 12F);
            txtVx.Location = new Point(84, 253);
            txtVx.Name = "txtVx";
            txtVx.Size = new Size(100, 26);
            txtVx.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 12F);
            label9.Location = new Point(54, 311);
            label9.Name = "label9";
            label9.Size = new Size(25, 22);
            label9.TabIndex = 9;
            label9.Text = "Z:";
            // 
            // txtUx
            // 
            txtUx.Font = new Font("Trebuchet MS", 12F);
            txtUx.Location = new Point(84, 104);
            txtUx.Name = "txtUx";
            txtUx.Size = new Size(100, 26);
            txtUx.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F);
            label8.Location = new Point(55, 282);
            label8.Name = "label8";
            label8.Size = new Size(24, 22);
            label8.TabIndex = 10;
            label8.Text = "Y:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F);
            label5.Location = new Point(54, 162);
            label5.Name = "label5";
            label5.Size = new Size(25, 22);
            label5.TabIndex = 11;
            label5.Text = "Z:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F);
            label7.Location = new Point(54, 253);
            label7.Name = "label7";
            label7.Size = new Size(25, 22);
            label7.TabIndex = 12;
            label7.Text = "X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F);
            label4.Location = new Point(54, 133);
            label4.Name = "label4";
            label4.Size = new Size(24, 22);
            label4.TabIndex = 13;
            label4.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F);
            label3.Location = new Point(54, 104);
            label3.Name = "label3";
            label3.Size = new Size(25, 22);
            label3.TabIndex = 14;
            label3.Text = "X:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F);
            label6.Location = new Point(11, 229);
            label6.Name = "label6";
            label6.Size = new Size(68, 22);
            label6.TabIndex = 7;
            label6.Text = "Vetor v:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 8;
            label2.Text = "Vetor u:";
            // 
            // frmProdutoEscalar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(pnlResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtVz);
            Controls.Add(txtUz);
            Controls.Add(txtVy);
            Controls.Add(txtUy);
            Controls.Add(txtVx);
            Controls.Add(label9);
            Controls.Add(txtUx);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRetorno);
            Name = "frmProdutoEscalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Vetorial";
            pnlResultado.ResumeLayout(false);
            pnlResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetorno;
        private Label label1;
        private Panel pnlResultado;
        private Button btnCalcular;
        private TextBox txtVz;
        private TextBox txtUz;
        private TextBox txtVy;
        private TextBox txtUy;
        private TextBox txtVx;
        private Label label9;
        private TextBox txtUx;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label2;
        private TextBox txtResultado;
        private Label label10;
    }
}