/*
 * Created by SharpDevelop.
 * User: Peceta
 * Date: 4/6/2021
 * Time: 02:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto
{
	/// <summary>
	/// Description of Abogado.
	/// </summary>
	/// /*
	public class Abogado
	{
		
		//Atributos
		private string nombre;
		private string apellido;
		private int dni;
		private string especialidad;
		private int cantidadExpedientesAsignados;
		
		//CONSTRUCTOR
		public Abogado(string nombre, string apellido, int dni, string especialidad, int cantidadExpedientesAsignados = 0)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.especialidad = especialidad;
			this.cantidadExpedientesAsignados = cantidadExpedientesAsignados;
		}
		
		//set y get
		public string nombreget{set{nombre = value;}get{return nombre;}}
		public string apellidoget{set{apellido = value;}get{return apellido;}}
		public int dniget{set{dni = value;}get{return dni;}}
		public string especialidadget{set{especialidad = value;}get{return especialidad;}}
		public int cantidadExpedientesAsignadosget{set{cantidadExpedientesAsignados = value;}get{return cantidadExpedientesAsignados;}}
		
		public String imprimirAbo(int i) //Metodo que imprime en pantalla datos de abogado.
		{
			return i + ")" + " Abogado/a: " + nombre + " " + apellido + "         DNI: " + dni + "        Especialidad: "  + especialidad + "         Cantidad de expedientes: " + cantidadExpedientesAsignados;
		}
		
	}
}
