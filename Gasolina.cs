using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tipo, Cantidad de Galones y Precio de Venta.
namespace JamilethCedeno_3A.clases
{
	class Gasolina
	{
		public static int iva = 12;
		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private int cant_galones;

		public int Cant_galones
		{
			get { return cant_galones; }
			set { cant_galones = value; }
		}

		private double precio;

		public  double Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		public Gasolina(string tipo, int cant_galones, double precio)
		{
			Tipo = tipo;
			Cant_galones = cant_galones;
			Precio = precio;
		}

		public void Cancelar()
		{
			double subtotal = Cant_galones * Precio;
			Console.WriteLine("  Subtotal:  " + subtotal);
			double tiva = (subtotal * iva)/100;
			Console.WriteLine("  IVA:  " + tiva);
			double total = subtotal + tiva;
			Console.WriteLine("  Total a Cancelar:  " + total);


		}


	}
}
