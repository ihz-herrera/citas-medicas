using BISoft.Consultorio.Presentacion.Entidades;
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
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            var listaClientes = CargarClientes();

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
            var listaClientes = CargarClientes();

            var existe = listaClientes
                .Any(x => x.Email == cliente.Email);
            if (existe)
            {
                MessageBox.Show("El email ya existe");
                return;
            }

            GuardarCliente(cliente);

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

        private static void GuardarCliente(Cliente cliente)
        {
            using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter("C:\\BaseDatos\\clientes.txt", true))
            {
                file.WriteLine(cliente.ToString());
            }
        }

        private List<Cliente> CargarClientes()
        {

            var clientes = new List<Cliente>();

            using (System.IO.StreamReader file =
                                           new System.IO.StreamReader("C:\\BaseDatos\\clientes.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var cliente = new Cliente();
                    var datos = line.Split(',');
                    cliente.Id = int.Parse(datos[0]);
                    cliente.Nombre = datos[1];
                    cliente.Email = datos[2];
                    cliente.Edad = int.Parse(datos[3]);

                    clientes.Add(cliente);
                }
            }

            return clientes;
        }
    }
}
