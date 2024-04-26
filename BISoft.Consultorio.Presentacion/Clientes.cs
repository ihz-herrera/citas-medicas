using Bisoft.Consultorio.Aplicacion.Servicio;

namespace BISoft.Consultorio.Presentacion
{
    public partial class Clientes : Form
    {


        private ClienteService _clienteService;

        public Clientes()
        {
            InitializeComponent();
            _clienteService = new ClienteService("Txt");
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

            try
            {
                var listaClientes = _clienteService.CargarClientes();
                dataGridView1.DataSource = listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error:{ex.Message}");
            }

        }
      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardar datos en un archivo de texto
                _clienteService.GuardarCliente(
                    txtNombre.Text,
                    txtEmail.Text,
                    Convert.ToInt32(txtEdad.Text)
                    );

                LimpiarControles();

                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error:{ex.Message}");
            }

        }

        private void LimpiarControles()
        {
            txtEdad.Text = "";
            txtEmail.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
        }

      
    }
}
