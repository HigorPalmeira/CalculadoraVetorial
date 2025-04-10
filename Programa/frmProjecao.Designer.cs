namespace CalculadoraVetorial
{
    partial class frmProjecao
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
            label1 = new Label();
            btnRetorno = new Button();
            pnlResultado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlResultado
            // 
            pnlResultado.Controls.Add(txtResultado);
            pnlResultado.Controls.Add(label10);
            pnlResultado.Location = new Point(248, 99);
            pnlResultado.Name = "pnlResultado";
            pnlResultado.Size = new Size(269, 257);
            pnlResultado.TabIndex = 40;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(7, 42);
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
            label10.Size = new Size(157, 22);
            label10.TabIndex = 0;
            label10.Text = "Projeção de U em V:";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(206, 406);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 32);
            btnCalcular.TabIndex = 31;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtVz
            // 
            txtVz.Font = new Font("Trebuchet MS", 12F);
            txtVz.Location = new Point(87, 325);
            txtVz.Name = "txtVz";
            txtVz.Size = new Size(100, 26);
            txtVz.TabIndex = 30;
            // 
            // txtUz
            // 
            txtUz.Font = new Font("Trebuchet MS", 12F);
            txtUz.Location = new Point(87, 176);
            txtUz.Name = "txtUz";
            txtUz.Size = new Size(100, 26);
            txtUz.TabIndex = 27;
            // 
            // txtVy
            // 
            txtVy.Font = new Font("Trebuchet MS", 12F);
            txtVy.Location = new Point(87, 296);
            txtVy.Name = "txtVy";
            txtVy.Size = new Size(100, 26);
            txtVy.TabIndex = 29;
            // 
            // txtUy
            // 
            txtUy.Font = new Font("Trebuchet MS", 12F);
            txtUy.Location = new Point(87, 147);
            txtUy.Name = "txtUy";
            txtUy.Size = new Size(100, 26);
            txtUy.TabIndex = 26;
            // 
            // txtVx
            // 
            txtVx.Font = new Font("Trebuchet MS", 12F);
            txtVx.Location = new Point(87, 267);
            txtVx.Name = "txtVx";
            txtVx.Size = new Size(100, 26);
            txtVx.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 12F);
            label9.Location = new Point(57, 325);
            label9.Name = "label9";
            label9.Size = new Size(25, 22);
            label9.TabIndex = 34;
            label9.Text = "Z:";
            // 
            // txtUx
            // 
            txtUx.Font = new Font("Trebuchet MS", 12F);
            txtUx.Location = new Point(87, 118);
            txtUx.Name = "txtUx";
            txtUx.Size = new Size(100, 26);
            txtUx.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F);
            label8.Location = new Point(58, 296);
            label8.Name = "label8";
            label8.Size = new Size(24, 22);
            label8.TabIndex = 35;
            label8.Text = "Y:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F);
            label5.Location = new Point(57, 176);
            label5.Name = "label5";
            label5.Size = new Size(25, 22);
            label5.TabIndex = 36;
            label5.Text = "Z:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F);
            label7.Location = new Point(57, 267);
            label7.Name = "label7";
            label7.Size = new Size(25, 22);
            label7.TabIndex = 37;
            label7.Text = "X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F);
            label4.Location = new Point(57, 147);
            label4.Name = "label4";
            label4.Size = new Size(24, 22);
            label4.TabIndex = 38;
            label4.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F);
            label3.Location = new Point(57, 118);
            label3.Name = "label3";
            label3.Size = new Size(25, 22);
            label3.TabIndex = 39;
            label3.Text = "X:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F);
            label6.Location = new Point(14, 243);
            label6.Name = "label6";
            label6.Size = new Size(68, 22);
            label6.TabIndex = 32;
            label6.Text = "Vetor v:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.Location = new Point(15, 99);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 33;
            label2.Text = "Vetor u:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 22);
            label1.Name = "label1";
            label1.Size = new Size(402, 37);
            label1.TabIndex = 24;
            label1.Text = "Calculadora - Produto Escalar";
            // 
            // btnRetorno
            // 
            btnRetorno.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetorno.Location = new Point(15, 26);
            btnRetorno.Name = "btnRetorno";
            btnRetorno.Size = new Size(60, 33);
            btnRetorno.TabIndex = 23;
            btnRetorno.Text = "<";
            btnRetorno.UseVisualStyleBackColor = true;
            // 
            // frmProjecao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 450);
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
            Name = "frmProjecao";
            Text = "Calculadora Vetorial";
            pnlResultado.ResumeLayout(false);
            pnlResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlResultado;
        private TextBox txtResultado;
        private Label label10;
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
        private Label label1;
        private Button btnRetorno;
    }
}