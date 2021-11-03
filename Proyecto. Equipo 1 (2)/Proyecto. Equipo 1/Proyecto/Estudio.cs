/*
 * Created by SharpDevelop.
 * User: Peceta
 * Date: 4/6/2021
 * Time: 01:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;


namespace Proyecto
{
	/// <summary>
	/// Description of Estudio.
	/// </summary>
	public class Estudio
	{
		//Atributos
		private string nombre;
		private ArrayList lista_expedientes;
		private Abogado[] lista_5Abogados;
		
		//Constructor Estudio
		public Estudio(string nombre)
		{
			this.nombre = nombre;
			lista_expedientes = new ArrayList();
			lista_5Abogados = new Abogado[5];
		}
		
		//Propiedades
		public Abogado[] lista_5AbogadosGet
		{
			set { lista_5Abogados = value; }
			get { return lista_5Abogados; }
		}
		public string nombreget{set{nombre=value;}get{return nombre;}}
		
		
		
		//Metodos respectivos a los expedientes
		public void agregarExpediente(Expediente unExp) // Metodo que agrega expediente a la lista de expedientes.
		{
			foreach (Abogado abogados in lista_5Abogados) //Recorre array de abogados
			{
				if((unExp.nomabocargoget == abogados.nombreget)&&(unExp.apeabocargoget == abogados.apellidoget)) //Si expediente pasado por parametro coincide con nombre y apellido de abogado
				{

					if(abogados.cantidadExpedientesAsignadosget<6) // Si el abogado tiene menos de 6 expedientes
					{
						Console.WriteLine();
						Console.ForegroundColor=ConsoleColor.Cyan;
					    Console.WriteLine("(!) El expediente nro." + unExp.numeroget + " que tiene a " + unExp.nomabocargoget + " " + unExp.apeabocargoget + " como abogado/a a cargo, ha sido agregado a la lista de expedientes");
					    Console.ForegroundColor=ConsoleColor.White;
					    lista_expedientes.Add(unExp);                        //Agrega expediente
					    abogados.cantidadExpedientesAsignadosget += 1;       //Suma 1 expediente al abogado
					    
					   
					}
					else if(abogados.cantidadExpedientesAsignadosget>=6)     //Si el abogado tiene 6 expedientes, no agrega.
					{
						Console.WriteLine();
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("El abogado/a {0} {1} ya tiene el limite de expedientes el cual es de 6", abogados.nombreget,abogados.apellidoget);                                                                                                                                           Console.ForegroundColor=ConsoleColor.White;
						Console.WriteLine("Por favor Asignele el expediente a otro abogado");
						
					}
			    }
			
		      }
		}
		
		public void modificarEstado(int numero_expediente, string nuevoestado) //Metodo que modifica estado de un expediente.
		{
			bool encuentra = false; //Check 
			if(lista_expedientes.Count > 0){  //Si la lista de expedientes contiene elementos
				foreach(Expediente expedientes in lista_expedientes) //Recorre lista de expedientes
				{
					if(numero_expediente == expedientes.numeroget) //Si el numero de expediente pasado por parametro coincide con algun numero de la lista
					{
						expedientes.estadoger = nuevoestado; // Cambia el estado por uno nuevo
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("(!) El estado del expediente numero {0} a sido modificado de forma satisfactoria.", numero_expediente);
						encuentra = true; // Encuentra una coincidencia
						Console.ReadKey();
					}
				}
				if(encuentra == false) //No encuentra coincidencia
				{
					Console.WriteLine("El expediente numero {0} no ha sido encontrado en el sistema.", numero_expediente);
					Console.ReadKey();
				}
			}
		}
		
		
		public void muestroexpedientes() //Metodo que muestra por pantalla la lista de expedientes.
		{
			
			if(lista_expedientes.Count > 0){ //Si la lista de expedientes contiene elementos
				foreach(Expediente expedientes in lista_expedientes) //Recorre la lista e imprime por pantalla los datos
				{
					Console.WriteLine("Num: {0}   Titular: {1}   Tipo: {2}   Estado: {3}   Abogado a cargo: {4} {5}   Fecha: {6} ",expedientes.numeroget,expedientes.nombreTitularget,expedientes.tipoExpedienteger,expedientes.estadoger,expedientes.nomabocargoget,expedientes.apeabocargoget,expedientes.fechaPresentacionget);
				}
			}else if (lista_expedientes.Count == 0) //Si no hay expedientes en la lista, imprime mensaje.
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine();
				Console.WriteLine("No hay expedientes en el sistema aun.");
			}
		}
		
		
		public void muestroexpedientesentrefechas(DateTime a , DateTime b)// Metodo que muestra por pantalla los expedientes tipo "Audiencia" entre dos fechas
			{ 
			bool encuentra = false; //check
				if(lista_expedientes.Count > 0){ //Si la lista de expedientes contiene elementos
					foreach(Expediente expedientes in lista_expedientes)//Recorre Lista
					{
						if((expedientes.tipoExpedienteger == "Audiencia")&&(expedientes.fechaPresentacionget > a)&&(expedientes.fechaPresentacionget < b))// Si el tipo de expediente es Audiencia y se encuentra entre las dos fechas pasadas por parametro impre por pantalla el expediente.
						{
							Console.WriteLine("Num: {0}   Titular: {1}   Tipo: {2}   Estado: {3}   Abogado a cargo: {4} {5}   Fecha: {6} ",expedientes.numeroget,expedientes.nombreTitularget,expedientes.tipoExpedienteger,expedientes.estadoger,expedientes.nomabocargoget,expedientes.apeabocargoget, expedientes.fechaPresentacionget);
							encuentra = true; //Encontro coincidencia
						}
						
					}
			}if(encuentra == false) // Si no encontro coincidencia, imprime mensaje
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("No se ha encontrado ningun expediente con los terminos especificados.");
			}
		}
		
		public ArrayList lista_exp (){return lista_expedientes;} //Retorna lista de expedientes.
		
		
		
         public void EliminarExpedientenum(int num) //Metodo para eliminar expediente a traves de su numero pasado por parametro
        {
         	try{
         	    foreach(Expediente exp in lista_expedientes)//Recorre lista de expedientes
         	    {
         		    if(exp.numeroget == num) //Si el numero del expediente coincide con el numero pasado por parametro
         		    {
         		      lista_expedientes.Remove(exp); //Elimina el expediente de la lista.
         		      Console.ForegroundColor=ConsoleColor.Cyan;
         		      Console.WriteLine("(!)Expediente numero {0} eliminado satisfactoriamente.", num);
         		      for(int i = 0; i < lista_5AbogadosGet.Length; i++) //Recorremos Array de abogados
				        {
         		      	//Si el nombre y apellido de algun abogado coincide con el del expediente eliminado, le resta 1 expediente al abogado
         			       if ((lista_5AbogadosGet[i].nombreget == exp.nomabocargoget)&&(lista_5AbogadosGet[i].apellidoget == exp.apeabocargoget)) 
         			        {
         				    lista_5AbogadosGet[i].cantidadExpedientesAsignadosget = lista_5AbogadosGet[i].cantidadExpedientesAsignadosget - 1;
         			        }
         		        }
         	        }
                 }
              }catch(NullReferenceException){}//Manejo de excepcion, ya que al recorrer cada abogado del Array, puede que se haga referencia a elementos null.
        }

		
		public void eliminarExpediente(Expediente unExp){lista_expedientes.Remove(unExp);}
		public int cantidadExp(ArrayList expedientes){return expedientes.Count;}                //Algunos metodos no utilizados en el proyecto.
		public bool existeExp(Expediente unExp){return lista_expedientes.Contains(unExp);}
		public Expediente verExpediente(int i){return (Expediente)lista_expedientes[i];}
		
		//Metodos respectivos a los abogados
		
		public void MostrarAbogados() //Metodo que imprime por pantalla la lista de abogados.
		{
			try{
				int x = 1; //Cosmetico para asignarle un numero a cada abogado a la hora de imprimirlos por pantalla, y que el programa sea mas interactivo y claro.
				foreach(Abogado abogados in lista_5Abogados) // Recorre lista de abogados.
				{
					Console.ForegroundColor=ConsoleColor.White;
					Console.WriteLine(x + ") {0} {1}" ,abogados.nombreget ,abogados.apellidoget); // Imprime los datos de los abogados.
					x+=1; 
				}
			}
			catch(System.NullReferenceException){}//Manejo de excepcion, ya que al recorrer cada abogado del Array, puede que se haga referencia a elementos null.
		}
		
		public void TeOrdenoAbogados(int pos) //Metodo que vuelve a organizar la lista de abogados cuando se elimina uno.
		{
			try{
			for(int i = pos - 1; i<5;i++) //Recorre desde el elemento pasado por parametro la lista de abogados.
			{
				lista_5Abogados[i] = lista_5Abogados[i+1]; //El elemento eliminado se convierte en el elemento siguiente.
				lista_5Abogados[i+1] = null; // y el elemento siguiente es eliminado.
				//De esta forma nunca nos quedara un elemento null entre abogados, lo cual permite evitar errores.
			}
			}catch(IndexOutOfRangeException){}//Manejo de excepcion, ya que al llegar al ultimo elemento del Array,el indice supera el rango permitido.
		}
		
		public void agregarAbogado(Abogado unAbog) //Metodo que agrega un abogado pasado por parametro
		{
			bool check = false; //check
			
			if(unAbog.cantidadExpedientesAsignadosget <= 6) //Si el abogado no supera los 6 expedientes
			{
				for (int i = 0; i < lista_5Abogados.Length; i++) //Recorre lista de abogados
				{
					if ((lista_5Abogados[i] == null) && (check == false)) //Si en la lista de abogados hay un espacio vacio
					{
						Console.ForegroundColor=ConsoleColor.Blue;
						Console.WriteLine();
						Console.WriteLine("(!) " + unAbog.nombreget + " " + unAbog.apellidoget + " ha sido agregado a la lista de abogados.");
						lista_5Abogados[i] = unAbog; //Agrega abogado
						check = true; //Activa el check
					}
				}
				//Si el check no es activado, consideramos que la lista de abogados ya esta completa. Imprimimos mensaje.
				if (check == false){Console.ForegroundColor=ConsoleColor.Blue;Console.WriteLine("(!) El Plantel de Abogados esta lleno. Por favor elimine un abogado y vuelva a intentarlo.");Console.ForegroundColor=ConsoleColor.White;}
			}
			else //Si el abogado supera los 6 expedientes, lanzamos una excepcion. Y se pide que se vuelvan a ingresar nuevamente los datos.
			{
				throw new AbogadoMaxExp();
			}
			
		}
		
			
		}
		
	}
	
	public class AbogadoMaxExp: Exception{} //Excepcion que se lanza cuando un abogado que quiere ingresar al plantel de abogados supera el maximo de expedientes que es 6.

