using BISoft.Consultorio.Infraestructura.Entidades;
using BISoft.Consultorio.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BISoft.Consultorio.Infraestructura
{
    public partial class Doctores : Form
    {
        private DoctoresTxtRepository _repo;

        public Doctores()
        {
            InitializeComponent();

            _repo = new DoctoresTxtRepository();
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {


            //Validar que los campos no esten vacios
            if (string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son requeridos");
                return;
            }

            //Validar que la edad sea un numero
            if (!Int64.TryParse(txtTelefono.Text, out Int64 telefono))
            {
                MessageBox.Show("El teléfono debe ser un número");
                return;
            }



            //Guardar datos en un archivo de texto
            var doctor = new Doctor
            (
                cedula : txtCedula.Text,
                nombre : txtNombre.Text,
                email : txtEmail.Text,
                telefono : telefono.ToString()
            );

            var datos = doctor.ToString();


            //Leer el archivo
            var listaDoctores = _repo.CargarDoctores();

            var existe = listaDoctores
                .Any(x => x.Cedula == doctor.Cedula);
            if (existe)
            {
                MessageBox.Show("La Cedula ya existe");
                return;
            }

            _repo.Guardar(doctor);

            LimpiarControles();

            MessageBox.Show("Datos guardados correctamente");


        }

        private void LimpiarControles()
        {
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
        }

        private void Doctores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.CargarDoctores();
        }
    }
}
