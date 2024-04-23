using BISoft.Consultorio.Presentacion.Entidades;
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
    public partial class Doctores : Form
    {
        public Doctores()
        {
            InitializeComponent();
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
                MessageBox.Show("El telefono debe ser un número");
                return;
            }



            //Guardar datos en un archivo de texto
            var doctor = new Doctor
            {
                Cedula = txtCedula.Text,
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Telefono = telefono.ToString()
            };

            var datos = doctor.ToString();


            //Leer el archivo
            var listaDoctores = CargarDoctores();

            var existe = listaDoctores
                .Any(x => x.Cedula == doctor.Cedula);
            if (existe)
            {
                MessageBox.Show("La Cedula ya existe");
                return;
            }

            GuardarDoctor(doctor);

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

        private static void GuardarDoctor(Doctor doctor)
        {
            using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter("C:\\BaseDatos\\doctores.txt", true))
            {
                file.WriteLine(doctor.ToString());
            }
        }

        private List<Doctor> CargarDoctores()
        {

            var clientes = new List<Doctor>();

            using (System.IO.StreamReader file =
                                           new System.IO.StreamReader("C:\\BaseDatos\\doctores.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var doctor = new Doctor();
                    var datos = line.Split(',');
                    doctor.Cedula = datos[0];
                    doctor.Nombre = datos[1];
                    doctor.Email = datos[2];
                    doctor.Telefono = datos[3];

                    clientes.Add(doctor);
                }
            }

            return clientes;
        }


    }
}
