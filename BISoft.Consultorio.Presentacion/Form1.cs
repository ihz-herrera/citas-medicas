namespace BISoft.Consultorio.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new Clientes();
            frmClientes.Show();
        }
    }
}
