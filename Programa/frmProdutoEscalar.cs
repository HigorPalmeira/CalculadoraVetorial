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
            try
            {
                Vetor u = new(Convert.ToDouble(txtUx.Text), Convert.ToDouble(txtUy.Text), Convert.ToDouble(txtUz.Text));
                Vetor v = new(Convert.ToDouble(txtVx.Text), Convert.ToDouble(txtVy.Text), Convert.ToDouble(txtVz.Text));

                double produtoEscalar = u.x * v.x + u.y * v.y + u.z * v.z;
                txtResultado.Text = produtoEscalar.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
