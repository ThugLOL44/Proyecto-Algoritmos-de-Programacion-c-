/*
 * Created by SharpDevelop.
 * User: Peceta
 * Date: 4/6/2021
 * Time: 02:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto
{
	/// <summary>
	/// Description of Expediente.
	/// </summary>
	public class Expediente
	{
		//Atributos
		private int numero;
		private string nombreTitular;
		private string tipoExpediente;
		private string estado;
		private string NomAboCargo;
		private string ApeAboCargo;
		private DateTime fechaPresentacion;
		
		//CONSTRUCTOR
		public Expediente(int numero, string nombreTitular, string tipoExpediente, string estado, string NomAboCargo, string ApeAboCargo,DateTime fechaPresentacion){
			this.numero = numero;
			this.nombreTitular = nombreTitular;
			this.tipoExpediente = tipoExpediente;
			this.estado = estado;
			this.NomAboCargo=NomAboCargo;
			this.ApeAboCargo=ApeAboCargo;
			this.fechaPresentacion = fechaPresentacion;
		}
		
		//set y get
		public int numeroget{set{numero = value;}get{return numero;}}
		public string nombreTitularget{set{nombreTitular = value;}get{return nombreTitular;}}
		public string tipoExpedienteger{set{tipoExpediente = value;}get{return tipoExpediente;}}
		public string estadoger{set{estado = value;}get{return estado;}}
		public string nomabocargoget{set{NomAboCargo = value;}get{return NomAboCargo;}}
		public string apeabocargoget{set{ApeAboCargo = value;}get{return ApeAboCargo;}}
		public DateTime fechaPresentacionget{set{fechaPresentacion = value;}get{return fechaPresentacion;}}
	}
	
}

