using BISoft.Consultorio.Presentacion.Entidades;
using BISoft.Consultorio.Presentacion.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BISoft.Consultorio.Presentacion
{
    public partial class Citas : Form
    {

        private ClientesTxtRepository _clienteRepo;
        private DoctoresTxtRepository _doctorRepo;

        public Citas()
        {
            InitializeComponent();

            _clienteRepo = new ClientesTxtRepository();
            _doctorRepo = new DoctoresTxtRepository();
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            cmbClientes.DataSource = _clienteRepo.CargarClientes();
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "Id";

            cmbDoctores.DataSource = _doctorRepo.CargarDoctores();
            cmbDoctores.DisplayMember = "Nombre";
            cmbDoctores.ValueMember = "Cedula";
        }


    }
}
