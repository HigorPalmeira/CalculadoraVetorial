namespace CalculadoraVetorial
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProdutoVetorial_Click(object sender, EventArgs e)
        {
            frmProdutoVetorial frmProdutoVetorial = new frmProdutoVetorial();
            frmProdutoVetorial.ShowDialog();
        }

        private void btnProdutoEscalar_Click(object sender, EventArgs e)
        {
            frmProdutoEscalar frmProdutoEscalar = new frmProdutoEscalar();
            frmProdutoEscalar.ShowDialog();
        }

        private void btnProdutoMisto_Click(object sender, EventArgs e)
        {
            frmProdutoMisto frmProdutoMisto = new frmProdutoMisto();
            frmProdutoMisto.ShowDialog();
        }
    }
}
