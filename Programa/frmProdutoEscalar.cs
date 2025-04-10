using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraVetorial
{
    public partial class frmProdutoEscalar : Form
    {
        public frmProdutoEscalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vetor u = new(Convert.ToInt32(txtUx.Text), Convert.ToInt32(txtUy.Text), Convert.ToInt32(txtUz.Text));
            Vetor v = new(Convert.ToInt32(txtVx.Text), Convert.ToInt32(txtVy.Text), Convert.ToInt32(txtVz.Text));

            double produtoEscalar = u.x * v.x + u.y * v.y + u.z * v.z;
            txtResultado.Text = produtoEscalar.ToString();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
