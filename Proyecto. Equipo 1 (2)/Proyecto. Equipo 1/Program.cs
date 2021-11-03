/* 
 Integrantes:
             Corsiglia Gonzalo
	        

 */
 
using System;
using System.Collections;



namespace Proyecto
{
	class Program
	{
		public static void Main(string[] args) //Main
		{
			Estudio HelpYou = new Estudio("HelpYou");    //Creamos objeto Estudio
			
			Abogado gonza = new Abogado("Gonzalo","Corsiglia",44042480,"penal",2);
			HelpYou.agregarAbogado(gonza);                                               //Cargamos algunos abogados, como para que al entrar al programa ya se pueda comenzar a realizar operaciones
			Abogado lucas = new Abogado("Lucas","Tortolini",58387482,"civil",6);
			HelpYou.agregarAbogado(lucas);
			
			menup(HelpYou); //Inicializamos Menu principal del estudio
			
		}
		

		public static void menup(Estudio e)   //Menu principal
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("╔═════════════════════════════════════════════════════╗");
			Console.WriteLine("║                   MENU PRINCIPAL                    ║");
			Console.WriteLine("╚═════════════════════════════════════════════════════╝");
			Console.ForegroundColor =ConsoleColor.White;
			Console.WriteLine("\n1) Abogados\n2) Expedientes\n3) Salir");
			Console.Write("\nElija una opcion: ");
			try{
			int opcion = int.Parse(Console.ReadLine());   //Opciones
			
			switch (opcion)
			{
				case 1:        //Opcion 1: Inicializa menu de abogados.
					menuabo(e); 
					break;
					
				case 2:        //Opcion 2: Inicializa menu de expedientes.
					menuexp(e); 
					break;
				
				case 3:        //Opcion 3: Finaliza Programa.
					Console.Clear();
					Console.WriteLine("Gracias por utilizar el sistema, lo esteremos esperando nuevamente\n");
					Console.ForegroundColor=ConsoleColor.Green;
					Console.WriteLine("                    ¶¶¶¶¶¶¶¶¶¶");
					Console.WriteLine("                  ø¶¶´´´´´´´´¶¶¶");
					Console.WriteLine("      ø¶¶¶¶¶¶¶1´´´¶¶´´´´´´´´´´´´¶¶");
					Console.WriteLine("    ¶¶¶´´´´´´ø¶¶´´¶´´´´´´´´´´´´´´¶¶");
					Console.WriteLine("  ¶¶ø´´´´´´´´´´1¶¶¶´´´´´´´´´´´´´´´¶¶");
					Console.WriteLine(" ¶¶´´´´´´´´´´´´´´¶¶´´¶¶¶¶´´´´´´´´´¶¶");
					Console.WriteLine(" ¶¢´´´´´´´´´¶¶¶´´´¶´´¶¶¶¶´´´´´´´´´¶¶");
					Console.WriteLine(" ¶´´´´´´´´´¶¶¶¶¶´´¶¶´´¶¶´´´´´´´´´´¶¶");
					Console.WriteLine(" ¶´´´´´´´´´´¶¶¶´´´¶¶¶´´´´´´´´´´´´¶¶¶¶");
					Console.WriteLine(" ¶¶´´´´´´´´´´´´´´´¶´¶¶¶´´´´´´´´¶¶¶´´¶¶");
					Console.WriteLine("  ¶¶´´´´´´´´´´´´´¶´´´´¶¶¶¶¶¶¶¶¶´´´´´´¶");
					Console.WriteLine("   ¶¶´´´´´´´´´´¶¶´´´´´´´´´´´´´´´´´´´´¶¶"); //La cara del sapo pepe.
					Console.WriteLine("   ¶¶¶¶¶¶¶¶¶¶¶¶´´´´´´´´´´´´´´´´´´´´´´¶¶");
					Console.WriteLine("   ¶´´´´´´´´´´´´´´`´´´´´´´´´`´´´´´´´´¶¶");
					Console.WriteLine("  ¶¶´´´´´´´´´´´´´´´´´´´´´´´```´´´´´´´¶¶");
					Console.WriteLine("  ¶¶´´´´´´´´´´´´´´´´´´´´´´¶´´´´´´´´´¶¶");
					Console.WriteLine("   ¶¶´´´´´´´´´¶¶´´´´´´´´´¶¶´´´´´´´´¶¶");
					Console.WriteLine("    ¶ø´´´´´´´´´¶¶¶´´´´´´¶¶´´´´´´´´¶¶");
					Console.WriteLine("     ¶¶7´´´´´´´´´¶¶¶¶$¶¶´´´´´´´´´¶¶");
					Console.WriteLine("       ¶¶¶´´´´´´´´´´´´´´´´´´´´´´¶¶");
					Console.WriteLine("          ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶");
					Console.ReadKey(true);
					break;
				
				default:          //Si se ingresa una opcion invalida.
					Console.WriteLine();
					Console.ForegroundColor=ConsoleColor.Red;
					Console.WriteLine("(!)Por favor, vuelva a intentarlo con una opcion valida."); //mensaje 
					Console.ReadKey();
					Console.Clear();
					menup(e); //Vuelve a cargar menu principal
					break;
					
			    }
			}catch(System.FormatException) //Manejo de excepcion, por si se ingresa un formato distinto al pedido
			{
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("(!)Detectamos un formato erroneo, por favor ingrese una opcion valida. "); //mensaje
				Console.ReadKey();
				Console.Clear();
				menup(e); //Vuelve a cargar menu principal
				
			}catch(System.OverflowException) //Manejo de excepcion, si se ingresa un valor que supera el rango de su dominio generando un desborde.
			{
			    Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("(!)Detectamos un OverFlow, por favor vuelva a intentarlo en unos momentos. "); //mensaje
				Console.ReadKey();
				Console.Clear();
				menup(e); //Vuelve a cargar menu principal
			}
			
		    
		}
		
		//Abogados
		public static void menuabo(Estudio e)  //Menu de Abogados.
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("╔═════════════════════════════════════════════════════╗");
			Console.WriteLine("║                   MENU DE ABOGADOS                  ║");
			Console.WriteLine("╚═════════════════════════════════════════════════════╝");
			Console.ForegroundColor =ConsoleColor.White;
			Console.WriteLine("\n1) Agregar Abogado\n2) Eliminar Abogado\n3) Listado de abogados\n4) Volver al Menu principal");
			Console.Write("\nIngrese una opcion: ");
			try{
			int op = int.Parse(Console.ReadLine());        //Opciones
			switch (op)
			{
				case 1:             //Agregar Abogado
					Console.Clear();
					int cont_abo = 0;   //Contador de cupos para abogados
					for(int i = 0; i < e.lista_5AbogadosGet.Length; i++)   //Recorre lista de abogados.
					{
						if (e.lista_5AbogadosGet[i] == null){cont_abo++;} //Por cada cupo vacio, se suma 1 al contador de cupos
					}
					if (cont_abo == 0) //Si no hay cupos, imprime mensaje.
					{
						Console.ForegroundColor=ConsoleColor.Blue;
						Console.WriteLine("(!) El Plantel de Abogados esta lleno. Por favor elimine un abogado y vuelva a intentarlo.");
						Console.ReadKey();
						Console.Clear();
						menuabo(e);
					}
					else //Si hay almenos un cupo, pide datos de abogado.
					{
						Console.WriteLine("\t Ingrese los datos del abogado a agregar");
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write("\nNombre del Abogado: ");
						Console.ForegroundColor =ConsoleColor.White;
						string nombreabogado=Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write("\nApellido del Abogado: ");
						Console.ForegroundColor =ConsoleColor.White;
						string apellidoabogado=Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write("\nDni del abogado: ");
						Console.ForegroundColor =ConsoleColor.White;
						int dni=int.Parse(Console.ReadLine());
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write("\nEspecialidad: ");
						Console.ForegroundColor =ConsoleColor.White;
						string especialidad=Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write("\nCantidad de expedientes a cargo: ");
						Console.ForegroundColor =ConsoleColor.White;
						int cantidadexpedientes = int.Parse(Console.ReadLine());
						Abogado abo = new Abogado(nombreabogado,apellidoabogado,dni,especialidad,cantidadexpedientes); //Crea abogado
						e.agregarAbogado(abo); //Agrega al abogado.
						Console.ReadKey();
						menuabo(e); //Vuelve a cargar el menu de abogados.
					}
					break;
				
				case 2:              //Opcion 2: Eliminar abogado.
					Console.Clear();
					int cont_del = 0;  //Contador de cupos disponibles
					for(int i = 0; i < e.lista_5AbogadosGet.Length; i++) //Recorre lista de abogados.
					{
						if (e.lista_5AbogadosGet[i] == null){cont_del++;} //Por cada cupo vacio, se suma 1 al contador de cupos
					}
					if (cont_del < 5) // Si hay uno o mas abogados cargados.
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine("Abogados cargados en el sistema:");
						Console.WriteLine();
						e.MostrarAbogados(); //Metodo para ver abogados cargados.
						Console.WriteLine();
						Console.WriteLine();
						Console.Write("Numero del abogado a eliminar: ");
						Console.ForegroundColor =ConsoleColor.White;
						int n=int.Parse(Console.ReadLine());          //Preguntamos que abogado se desea eliminar
						if (n >= 0 && e.lista_5AbogadosGet[n-1] != null)
						{
							e.lista_5AbogadosGet[n-1] = null;       //Eliminamos abogado
							e.TeOrdenoAbogados(n);                  //Ordenamos la lista, para un mejor manejo del programa luego.
							Console.ForegroundColor=ConsoleColor.Blue;
							Console.WriteLine();
							Console.WriteLine("El abogado a sido eliminado con exito!");
							Console.ReadKey();
							Console.Clear();
							menuabo(e);               //Volvemos a cargar menu de abogados.
						}
						else // Si se ingresa un valor que no hace referencia a ningun abogado.
						{
							Console.ForegroundColor=ConsoleColor.Blue;
							Console.WriteLine("Ingreso un numero invalido. Por favor, corrobore el abogado a eliminar e intente mas tarde.");
							Console.ForegroundColor=ConsoleColor.White;
							Console.ReadKey();
							Console.Clear();
							menuabo(e); //Volvemos a cargar menu de abogados.
						}
					}
					if (cont_del == 5) //Si no hay abogados en el sistema, imprime mensaje.
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine("\n\tNO HAY ABOGADOS CARGADOS.");
						Console.ReadKey();
						Console.Clear();
						menuabo(e); //Volvemos a cargar menu de abogados.
					}
					break;
					
				case 3:         //Opcion 3: Lista de abogados.
					Console.Clear();
					int cont_list = 0; //Cupos disponibles
					Console.ForegroundColor=ConsoleColor.Blue;
					Console.WriteLine("╔═════════════════════════════════════════════════════╗");
					Console.WriteLine("║                  Lista de Abogados                  ║");
					Console.WriteLine("╚═════════════════════════════════════════════════════╝");
					Console.ForegroundColor=ConsoleColor.White;
					for(int i = 0; i < e.lista_5AbogadosGet.Length; i++) //Recorremos lista de abogados.
					{
						if (e.lista_5AbogadosGet[i] != null) //Si existe un abogado
						{
							Console.WriteLine(e.lista_5AbogadosGet[i].imprimirAbo(i + 1)); //Imprime datos de abogado
						}
						else{cont_list++;} //Si no existe, suma al contador de cupos
					}
					if (cont_list == 5) //Si el contador de cupos es 5, no hay abogados en el sistema.
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine("\n\tNO HAY ABOGADOS CARGADOS.");
					}
					Console.ReadKey();
					Console.Clear();
					menuabo(e); //Volvemos a cargar menu de abogados.
					break;
				
				case 4:     //Opcion 4: Volver al menu principal
					menup(e); // Cargamos menu principal.
					break;
				
				default:   //Si se ingresa un valor invalido, imprimimos mensaje.
					Console.WriteLine();
					Console.ForegroundColor=ConsoleColor.Blue;
					Console.WriteLine("Por favor, vuelva a intentarlo con una opcion valida.");
					Console.ReadKey();
					Console.Clear();
					menuabo(e);   //Volvemos a cargar menu de abogados.
					break;
			    }
		    }catch(System.FormatException) //Excepcion si se ingresa un formato incorrecto.
			{
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("(!)Detectamos un formato erroneo, por favor ingrese una opcion valida. ");
				Console.ReadKey();
				Console.Clear();
				menuabo(e); //Volvemos a cargar menu de abogados.
				
			}catch(AbogadoMaxExp) //Excepcion si se quiere agregar un abogado con mas de 6 expedientes.
			{
			Console.WriteLine();
				                                                                                                 Console.ForegroundColor=ConsoleColor.Blue;
			Console.WriteLine("Error: Un abogado puede estar a cargo de un maximo de 6 expedientes.");
					                                                                                                  Console.ForegroundColor=ConsoleColor.White;
			Console.WriteLine("Por favor vuelva a intentarlo luego...");
			Console.ReadKey();
			menuabo(e); //Volvemos a cargar menu de abogados.
			}
			catch(System.IndexOutOfRangeException) //Excepcion si se ingresa un valor fuera del rango de indice al querer eliminar un abogado.
			{
				Console.WriteLine();
				Console.ForegroundColor=ConsoleColor.Blue;
				Console.WriteLine("(!)Ingreso un numero invalido. Por favor, corrobore el abogado a eliminar e intente mas tarde.");
				Console.ForegroundColor=ConsoleColor.White;
				Console.ReadKey();
				menuabo(e); //Volvemos a cargar menu de abogados.
			}catch(System.OverflowException) //Manejo de excepcion, si se ingresa un valor que supera el rango de su dominio generando un desborde.
			{
			    Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("(!)Detectamos un OverFlow, por favor vuelva a intentarlo en unos momentos. ");
				Console.ReadKey();
				Console.Clear();
				menuabo(e); //Volvemos a cargar menu de abogados.
			}
		}
		
		//Expedientes
		public static void menuexp(Estudio e)  //Menu Expedientes
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("╔═════════════════════════════════════════════════════╗");
			Console.WriteLine("║                 MENU DE EXPEDIENTES                 ║");
			Console.WriteLine("╚═════════════════════════════════════════════════════╝");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\n1) Agregar expediente y asigarlo a un abogado \n2) Modificar estado de un expediente determinado \n3) Eliminar expediente por numero \n4) Listado de expedientes \n5) Volver al Menu Principal");
			Console.Write("\nIngrese una opcion: ");
			try{
			int op = int.Parse(Console.ReadLine());   //Opciones
			
			switch (op)
			{
				case 1:            //Opcion 1: Agregar expediente.
					Console.Clear();
			try{
				int cont_abo = 0;   //Contador de cupos para abogados
			     for(int i = 0; i < e.lista_5AbogadosGet.Length; i++)   //Recorre lista de abogados.
			       {
				     if (e.lista_5AbogadosGet[i] == null){cont_abo++;} //Por cada cupo vacio, se suma 1 al contador de cupos
			        }
			     if(cont_abo == 5)//Si no hay abogados imprime mensaje.
			          {
				        Console.ForegroundColor = ConsoleColor.Cyan;
				        Console.WriteLine("\n\tNO HAY ABOGADOS CARGADOS.");
			           }
			     else //Si hay abogados a los cuales asignarles expedientes, pide datos
			     { 
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write("\nNumero de expediente: ");
						Console.ForegroundColor =ConsoleColor.White;
						int nroexp=int.Parse(Console.ReadLine());
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write("\nNombre del Titular: ");
						Console.ForegroundColor =ConsoleColor.White;
						string nombretitular=Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write("\nTipo de expediente: ");
						Console.ForegroundColor =ConsoleColor.White;
						string tipoexp= Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write("\nEstado del expediente: ");
						Console.ForegroundColor =ConsoleColor.White;
						string estadoexp=Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write("\nNombre de abogado a cargo: ");
						Console.ForegroundColor =ConsoleColor.White;
						string nomabo=Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write("\nApellido de abogado a cargo: ");
						Console.ForegroundColor=ConsoleColor.White;
						string apeabo= Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write("\nFecha de presentacion: ");
						Console.ForegroundColor=ConsoleColor.White;
						DateTime date = DateTime.Parse(Console.ReadLine());
						Expediente exp= new Expediente(nroexp,nombretitular,tipoexp,estadoexp,nomabo,apeabo,date); //Crea Expediente
						e.agregarExpediente(exp);
							 
			     }
					}catch(NullReferenceException){}
					Console.ReadKey();
					Console.Clear();
					menuexp(e); //Volvemos a cargar menu de expedientes.
					break;
					
				case 2:              //Opcion 2: Modificar estado de un expediente
					Console.Clear();
					if(e.lista_exp().Count == 0) //Si no hay expedientes, imprimo mensaje
			        {
				        Console.ForegroundColor = ConsoleColor.Cyan;
				        Console.WriteLine();
				        Console.WriteLine("No hay expedientes en el sistema aun.");
				        Console.ReadKey();
			
					}
					else //Si hay expedientes
					{
					   Console.ForegroundColor=ConsoleColor.Cyan;
					   Console.WriteLine("╔═════════════════════════════════════════════════════╗");
					   Console.WriteLine("║              Estados de los Expedientes             ║");
					   Console.WriteLine("╚═════════════════════════════════════════════════════╝");
					   Console.ForegroundColor=ConsoleColor.White;
						
						foreach(Expediente exp in e.lista_exp()) //Recorro lista de expedientes
						{
							Console.WriteLine("Num: {0}    Estado: {1}",exp.numeroget,exp.estadoger); //Muestro por pantalla los expedientes, para que el usuario sepa que estado cambiara.
						}
						Console.WriteLine();
					    Console.ForegroundColor = ConsoleColor.Cyan;
					    Console.Write("Ingrese el numero del expediente al cual quiere modificar: "); 
					    Console.ForegroundColor = ConsoleColor.White;
					    int n = int.Parse(Console.ReadLine());             //Pedimos el numero de expediente al cual se le cambiara el estado.
					    Console.WriteLine();
					    Console.ForegroundColor = ConsoleColor.Cyan;
					    Console.Write("Ingrese el nuevo estado: ");        //Pedimos el nuevo estado.
					    Console.ForegroundColor = ConsoleColor.White;
					    string newestado = Console.ReadLine();
					    Console.WriteLine();
					    e.modificarEstado(n, newestado);                   //Cambiamos el estado.
					}
					
					Console.Clear();
					Console.Clear();
					menuexp(e); //Volvemos a cargar menu de expedientes.
					break;
				case 3: //Opcion 3: Eliminar un expediente.
					Console.Clear();
					Console.ForegroundColor=ConsoleColor.Cyan;
					Console.WriteLine("╔═════════════════════════════════════════════════════╗");
					Console.WriteLine("║                 Lista de Expedientes                ║");
					Console.WriteLine("╚═════════════════════════════════════════════════════╝");
					Console.ForegroundColor=ConsoleColor.White;
					e.muestroexpedientes(); //Mostramos por pantalla la lista de expedientes, para que el usuario sepa que eliminara.
					Console.WriteLine();
					if(e.lista_exp().Count != 0) //Si existe uno o mas expedientes
					{
					    Console.Write("Ingrese el numero del expediente que desea eliminar: ");
					    int numero = int.Parse(Console.ReadLine());  //Pedimos numero de expediente a eliminar
					    e.EliminarExpedientenum(numero); //Eliminamos expediente
					}
					Console.ReadKey();
					Console.Clear();
					menuexp(e); //Volvemos a cargar menu de expedientes.
					break;
				case 4:   //Opcion 4: Lista de expedientes, decidimos agregar la opcion de que tambien se pueda visualizar la lista completa, para dar un mejor toque al programa.
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("¿Que deseas visualizar?");
					Console.WriteLine();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("1) Lista de expedientes completa");
					Console.WriteLine("2) Lista de expedientes de tipo Audiencia comprendidos entre fechas");
					Console.WriteLine("3) Volver");
					int numerardo = 0;
					Console.WriteLine();
					Console.Write("Ingrese una opcion: ");
					numerardo = int.Parse(Console.ReadLine());
					Console.Clear();
					switch(numerardo)
					{

						case 1:   //Opcion 1: Lista de expedientes completa
							Console.Clear();
							Console.ForegroundColor=ConsoleColor.Cyan;
							Console.WriteLine("╔═════════════════════════════════════════════════════╗");
							Console.WriteLine("║                 Lista de Expedientes                ║");
							Console.WriteLine("╚═════════════════════════════════════════════════════╝");
							Console.ForegroundColor=ConsoleColor.White;
							e.muestroexpedientes(); //Imprimimos en pantalla lista de expedientes completa
							Console.ReadKey();
							break;
						case 2: //Opcion 2: Lista de expedientes tipo "Audiencia" entre 2 fechas.
							if(e.lista_exp().Count > 0) //Si hay uno o mas expedientes en la lista, pedimos datos
							{
							Console.ForegroundColor=ConsoleColor.Cyan;
							Console.WriteLine("╔═════════════════════════════════════════════════════╗");
							Console.WriteLine("║     Lista de Expedientes Audiencia entre fechas     ║");
							Console.WriteLine("╚═════════════════════════════════════════════════════╝");
							Console.ForegroundColor=ConsoleColor.White;
								Console.Clear();
								Console.ForegroundColor = ConsoleColor.Cyan;
								Console.Write("Ingrese la Fecha Inicial: ");
								Console.ForegroundColor = ConsoleColor.White;
								DateTime fecha1 = DateTime.Parse(Console.ReadLine());
								Console.WriteLine();
								Console.ForegroundColor = ConsoleColor.Cyan;
								Console.Write("Ingrese la Fecha Final: ");
								Console.ForegroundColor = ConsoleColor.White;
								DateTime fecha2 = DateTime.Parse(Console.ReadLine());
								Console.WriteLine();
								e.muestroexpedientesentrefechas(fecha1, fecha2); //Ejecuta metodo.
								Console.ReadKey();
							}else //Si no hay expedientes en el sistema, imprime mensaje.
							{
								Console.ForegroundColor = ConsoleColor.Cyan;
								Console.WriteLine();
								Console.WriteLine("No hay expedientes en el sistema aun.");
								Console.ReadKey();
				
							}
							break;
						case 3 : //Opcion 3: Volver al menu de expedientes, opcion por si el usuario se equivoca y sin querer entra a este submenu.
							break;
					}
					
					Console.Clear();
					Console.Clear();
					menuexp(e); //Volvemos a cargar menu de expedientes.
					break;
				case 5: //Opcion 3: Volver al menu principal
					Console.Clear();
					Console.Clear();
					menup(e); //Volvemos a cargar menu de principal.
					break;
				
				default: //Por si se ingresa una opcion invalida.
					Console.WriteLine();
					Console.ForegroundColor=ConsoleColor.Cyan;
					Console.WriteLine("Por favor, vuelva a intentarlo con una opcion valida.");
					Console.ReadKey();
					Console.Clear();
					menuexp(e); //Volvemos a cargar menu de expedientes.
					break;
			    }
		    }catch(System.FormatException) //Excepcion por si se ingresa un formato incorrecto.
			{
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("(!)Detectamos un formato erroneo, por favor ingrese una opcion valida. ");
				Console.ReadKey();
				Console.Clear();
				menuexp(e); //Volvemos a cargar menu de expedientes.
				
			}catch(System.OverflowException) //Manejo de excepcion, si se ingresa un valor que supera el rango de su dominio generando un desborde.
			{
			    Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("(!)Detectamos un OverFlow, por favor vuelva a intentarlo en unos momentos. ");
				Console.ReadKey();
				Console.Clear();
				menuexp(e); //Volvemos a cargar menu de expedientes.
			}
		}
		
	}
}
//a) Agregar abogado
//b) Eliminar abogado
//c) Listado de abogados
//d) Agregar un nuevo expediente al estudio y asignárselo a un abogado dado. Si ese abogado ya
//posee a su cargo 6 expedientes se debe levantar una excepción que indique que debe
//asignárselo otro abogado.
//e) Modificar el estado de un expediente determinado
//f) Eliminar expediente por numero (hay que buscar a su abogado y restarle un expediente a
//cargo también)
//g) Listado de expedientes de tipo ‘audiencia’ que se hayan presentado entre dos fechas dadas
//indicando quien es el abogado encargado del mismo.
