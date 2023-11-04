namespace TPI_PROGII_2023
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerarFactura formGenerarFactura = new FormGenerarFactura();
            formGenerarFactura.ShowDialog();
        }
    }
}