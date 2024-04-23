namespace BISoft.Consultorio.Presentacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new Clientes();
            frmClientes.Show();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            var frmDoctores = new Doctores();
            frmDoctores.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            var frmCitas = new Citas();
            frmCitas.Show();
        }
    }
}
