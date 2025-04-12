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
    public partial class frmProdutoMisto : Form
    {
        public frmProdutoMisto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Vetor u = new(Convert.ToDouble(txtUx.Text), Convert.ToDouble(txtUy.Text), Convert.ToDouble(txtUz.Text));
                Vetor v = new(Convert.ToDouble(txtVx.Text), Convert.ToDouble(txtVy.Text), Convert.ToDouble(txtVz.Text));
                Vetor w = new(Convert.ToDouble(txtWx.Text), Convert.ToDouble(txtWy.Text), Convert.ToDouble(txtWz.Text));

                double determinante = (u.x * v.y * w.z + u.y * v.z * w.x + u.z * v.x * w.y) - (u.y * v.x * w.z + u.x * v.z * w.y + u.z * v.y * w.x);

                txtResultado.Text = determinante.ToString("F2");
                if (determinante == 0) lblBase.Text = "Os vetores são coplanares!";
                else if (determinante < 0) lblBase.Text = "Base Negativa.";
                else lblBase.Text = "Base Positiva.";
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
