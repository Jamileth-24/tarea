using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Apellidos, Nombres, Número de Cédula de identidad y Dirección.
namespace JamilethCedeno_3A.clases
{
	public class Cliente
	{

		private string apellido;

		public  string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}


		private string nombre ;

		public string Nombre		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int identificacion;

		public int Identificacion
		{
			get { return identificacion; }
			set { identificacion = value; }
		}

		private string direccion;

		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		public Cliente(string apellido, string nombre, int identificacion, string direccion)
		{
			Apellido = apellido;
			Nombre = nombre;
			Identificacion = identificacion;
			Direccion = direccion;
		}
	}
}
