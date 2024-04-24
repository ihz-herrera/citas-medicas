using BISoft.Consultorio.Presentacion.Entidades;
using BISoft.Consultorio.Presentacion.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BISoft.Consultorio.Presentacion
{
    public partial class Clientes : Form
    {


        private ClientesRepository _repo;

        public Clientes()
        {
            InitializeComponent();

            _repo = new ClientesRepository();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            var listaClientes = _repo.CargarClientes();

            dataGridView1.DataSource = listaClientes;
        }

      
        private void btnGuardar_Click(object sender, EventArgs e)
        {


            //Validar que los campos no esten vacios
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtEdad.Text))
            {
                MessageBox.Show("Todos los campos son requeridos");
                return;
            }

            //Validar que la edad sea un numero
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad debe ser un numero");
                return;
            }

            //Validar que el Id sea un numero
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("El Id debe ser un numero");
                return;
            }

            //Guardar datos en un archivo de texto
            var cliente = new Cliente
            {
                Id = id,
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Edad = edad
            };

            var datos = cliente.ToString();


            //Leer el archivo
            var listaClientes = _repo.CargarClientes();

            var existe = listaClientes
                .Any(x => x.Email == cliente.Email);
            if (existe)
            {
                MessageBox.Show("El email ya existe");
                return;
            }

            _repo.Guardar(cliente);

            LimpiarControles();

            MessageBox.Show("Datos guardados correctamente");


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
