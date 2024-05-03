using Bisoft.Consultorio.Presentacion.Servicios;
using System;
using System.Windows.Forms;

namespace Bisoft.Consultorio.Presentacion.NetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var servicio = new ClientesService();

            var clietes = servicio.ConsultarClientes();



            servicio.GuardarCliente("Juan", "r", 25);
        }
    }
}
