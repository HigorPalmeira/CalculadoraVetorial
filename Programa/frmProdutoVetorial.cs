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
            Vetor u = new(Convert.ToInt32(txtUx.Text), Convert.ToInt32(txtUy.Text), Convert.ToInt32(txtUz.Text));
            Vetor v = new(Convert.ToInt32(txtVx.Text), Convert.ToInt32(txtVy.Text), Convert.ToInt32(txtVz.Text));

            int wX = u.y * v.z - u.z * v.y;
            int wY = u.z * v.x - u.x * v.z;
            int wZ = u.x * v.y - u.y * v.x;

            txtResultado.Text = wX.ToString() +", " + wY.ToString() +", " + wZ.ToString();
        }
    }
}
