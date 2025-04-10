namespace CalculadoraVetorial
{
    partial class frmPrincipal
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
            btnProdutoEscalar = new Button();
            btnProdutoVetorial = new Button();
            btnProdutoMisto = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnProdutoEscalar
            // 
            btnProdutoEscalar.Location = new Point(12, 100);
            btnProdutoEscalar.Name = "btnProdutoEscalar";
            btnProdutoEscalar.Size = new Size(113, 42);
            btnProdutoEscalar.TabIndex = 0;
            btnProdutoEscalar.Text = "Produto Escalar";
            btnProdutoEscalar.UseVisualStyleBackColor = true;
            btnProdutoEscalar.Click += btnProdutoEscalar_Click;
            // 
            // btnProdutoVetorial
            // 
            btnProdutoVetorial.Location = new Point(12, 148);
            btnProdutoVetorial.Name = "btnProdutoVetorial";
            btnProdutoVetorial.Size = new Size(113, 42);
            btnProdutoVetorial.TabIndex = 1;
            btnProdutoVetorial.Text = "Produto Vetorial";
            btnProdutoVetorial.UseVisualStyleBackColor = true;
            btnProdutoVetorial.Click += btnProdutoVetorial_Click;
            // 
            // btnProdutoMisto
            // 
            btnProdutoMisto.Location = new Point(223, 100);
            btnProdutoMisto.Name = "btnProdutoMisto";
            btnProdutoMisto.Size = new Size(113, 42);
            btnProdutoMisto.TabIndex = 2;
            btnProdutoMisto.Text = "Produto Misto";
            btnProdutoMisto.UseVisualStyleBackColor = true;
            btnProdutoMisto.Click += btnProdutoMisto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(338, 37);
            label1.TabIndex = 1;
            label1.Text = "CALCULADORA VETORIAL";
            // 
            // button1
            // 
            button1.Location = new Point(223, 148);
            button1.Name = "button1";
            button1.Size = new Size(113, 42);
            button1.TabIndex = 3;
            button1.Text = "Projeção";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnProdutoMisto);
            Controls.Add(btnProdutoVetorial);
            Controls.Add(btnProdutoEscalar);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Vetorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProdutoEscalar;
        private Button btnProdutoVetorial;
        private Button btnProdutoMisto;
        private Label label1;
        private Button button1;
    }
}
