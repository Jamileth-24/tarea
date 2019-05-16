using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JamilethCedeno_3A.clases;

namespace JamilethCedeno_3A
{
	class Program
	{
		
		static void Main(string[] args)
		{
			Console.WriteLine("+++++++++++++++++++++++++++++++++++++  FACTURA  +++++++++++++++++++++++++++++++++++++");
			Console.WriteLine();
			Cliente cliente = new Cliente("Delgado","Maria", 1311468530, "Los Esteros");
			Console.WriteLine("  Cliente: {0} {1}      Identificación: {2}      Dirección: {3}",
				cliente.Nombre, cliente.Apellido, cliente.Identificacion, cliente.Direccion);

			Console.WriteLine();

			Gasolina gasolina = new Gasolina("Extra", 3, 1.50);
			Console.WriteLine("  Tipo de Gasolina:      Cantidad de Galones:      Precio: ");
			Console.WriteLine("     {0}                      {1}                  {2}",
				gasolina.Tipo, gasolina.Cant_galones, gasolina.Precio);

			Console.WriteLine();
			Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
			//metódo que muestra el calor a cancelar
			gasolina.Cancelar();

			Console.ReadKey();
		}
	}
}
