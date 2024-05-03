
using Bisoft.Consultorio.Presentacion.Servicios;

namespace BISoft.Consultorio.Infraestructura
{
    public partial class Clientes : Form
    {


        private ClientesService _clienteService;

        public Clientes()
        {
            InitializeComponent();
            _clienteService = new ClientesService();
        }

        private async void Clientes_Load(object sender, EventArgs e)
        {

            try
            {
                //var listaClientes = _clienteService.CargarClientes();
                dataGridView1.DataSource = await _clienteService.ConsultarClientes();
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
