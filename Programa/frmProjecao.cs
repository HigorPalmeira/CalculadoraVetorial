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
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Vetor u = new(Convert.ToInt32(txtUx.Text), Convert.ToInt32(txtUy.Text), Convert.ToInt32(txtUz.Text));
            Vetor v = new(Convert.ToInt32(txtVx.Text), Convert.ToInt32(txtVy.Text), Convert.ToInt32(txtVz.Text));
        }
    }
}
