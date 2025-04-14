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
    public partial class frmProdutoVetorial : Form
    {
        public frmProdutoVetorial()
        {
            InitializeComponent();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Vetor u = new(Convert.ToDouble(txtUx.Text), Convert.ToDouble(txtUy.Text), Convert.ToDouble(txtUz.Text));
                Vetor v = new(Convert.ToDouble(txtVx.Text), Convert.ToDouble(txtVy.Text), Convert.ToDouble(txtVz.Text));

                double wX = u.y * v.z - u.z * v.y;
                double wY = u.z * v.x - u.x * v.z;
                double wZ = u.x * v.y - u.y * v.x;

                txtResultado.Text = wX.ToString("F2").Replace(",", ".") + ", " + wY.ToString("F2").Replace(",", ".") + ", " + wZ.ToString("F2").Replace(",", ".");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
