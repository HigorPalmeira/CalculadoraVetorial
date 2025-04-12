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
    public partial class frmProjecao : Form
    {
        public frmProjecao()
        {
            InitializeComponent();
            label1.Text = "Calculadora - Projeção";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Vetor u = new(Convert.ToDouble(txtUx.Text), Convert.ToDouble(txtUy.Text), Convert.ToDouble(txtUz.Text));
                Vetor v = new(Convert.ToDouble(txtVx.Text), Convert.ToDouble(txtVy.Text), Convert.ToDouble(txtVz.Text));
                Vetor versorV = v.Versor();

                double produtoEscalar = u.x * v.x + u.y * v.y + u.z * v.z;

                double wX = produtoEscalar * versorV.x;
                double wY = produtoEscalar * versorV.y;
                double wZ = produtoEscalar * versorV.z;

                txtResultado.Text = wX.ToString("F2") + ", " + wY.ToString("F2") + ", " + wZ.ToString("F2");
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
