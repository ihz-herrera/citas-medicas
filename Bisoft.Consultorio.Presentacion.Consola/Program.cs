// See https://aka.ms/new-console-template for more information


using BISoft.Consultorio.Presentacion.Entidades;

Console.WriteLine("Hello, World!");


try
{
	var cliente = new Cliente(2, "Ivan", "kj",25 );

  

    Console.WriteLine(cliente.Nombre);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}





