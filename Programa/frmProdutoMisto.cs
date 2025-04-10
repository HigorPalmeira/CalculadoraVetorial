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
            Vetor u = new(Convert.ToInt32(txtUx.Text), Convert.ToInt32(txtUy.Text), Convert.ToInt32(txtUz.Text));
            Vetor v = new(Convert.ToInt32(txtVx.Text), Convert.ToInt32(txtVy.Text), Convert.ToInt32(txtVz.Text));
            Vetor w = new(Convert.ToInt32(txtWx.Text), Convert.ToInt32(txtWy.Text), Convert.ToInt32(txtWz.Text));

            int determinante = (u.x * v.y * w.z + u.y * v.z * w.x + u.z * v.x * w.y) - (u.y * v.x * w.z + u.x * v.z * w.y + u.z * v.y * w.x);

            txtResultado.Text = determinante.ToString();
            if (determinante == 0) lblBase.Text = "Os vetores são coplanares!";
            else if (determinante < 0) lblBase.Text = "Base Negativa.";
            else lblBase.Text = "Base Positiva.";

        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
