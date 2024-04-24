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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            //List<Cliente> clientes = CargarClientes();

            //List<Doctor> doctores = CargarDoctores();

            //List<Cita> Citas = CargarCitas();
        }

        //private List<Cita> CargarCitas()
        //{
        //    throw new NotImplementedException();
        //}

        //private List<Doctor> CargarDoctores()
        //{
        //    //cargar doctores de archivo de texto
        //    List<Doctor> doctores = new List<Doctor>();
        //    using (var reader = new StreamReader("doctores.txt"))
        //    {
        //        while (!reader.EndOfStream)
        //        {
        //            var line = reader.ReadLine();
        //            var values = line.Split(',');
        //            doctores.Add(new Doctor { Id = int.Parse(values[0]), Nombre = values[1], Especialidad = values[2] });
        //        }
        //    }

        //    return doctores;
        //}

        //private List<Cliente> CargarClientes()
        //{
        //    List<Cliente> clientes = new List<Cliente>();

        //    clientes.Add(new Cliente { Id = 1, Nombre = "Juan Perez", Email = ""})
        //}
    }
}
