namespace CalculadoraVetorial
{ // erro de carregar o form visual no editor ??
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
            // c�digo no arquivo frmProdutoVetorial.cs
        }

        private void btnProdutoEscalar_Click(object sender, EventArgs e)
        {
            frmProdutoEscalar frmProdutoEscalar = new frmProdutoEscalar();
            frmProdutoEscalar.ShowDialog();
            // c�digo no arquivo frmProdutoEscalar.cs
        }

        private void btnProdutoMisto_Click(object sender, EventArgs e)
        {
            frmProdutoMisto frmProdutoMisto = new frmProdutoMisto();
            frmProdutoMisto.ShowDialog();
            // c�digo no arquivo frmProdutoMisto.cs
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProjecao frmProjecao = new frmProjecao();
            frmProjecao.ShowDialog();
            // c�digo no arquivo frmProjecao.cs
        }
    }
}
