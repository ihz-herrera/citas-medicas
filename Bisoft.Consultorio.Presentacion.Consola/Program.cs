// See https://aka.ms/new-console-template for more information


using Bisoft.Consultorio.Aplicacion.Servicio;
using BISoft.Consultorio.Infraestructura.Entidades;

Console.WriteLine("Hello, World!");


try
{

    var servicio = new ClienteService("MSSQL");
	servicio.GuardarCliente( "Ivanhh", "kj@",25 );

  

    Console.WriteLine("El cliente se guardo satisfactoriamente");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}





