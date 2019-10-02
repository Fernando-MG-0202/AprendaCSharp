using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascorro_Garcia_Fernando_Enrique
{

    class Program
    {

        static public float numero1 = 24.5F;
        static void Main(string[] args)
        {

            for (int NumeroDeOpcion = 0; NumeroDeOpcion != 11;)
            {
                //Elimina todo el texto en la pantalla de ejecucion
                Console.Clear();
                Console.WriteLine("Que programa desea ejecutar?\n\n1. HolaMundo \n2. Conversiones \n3. Aleatorio \n4. Entrada \n5. Nombre \n6. Tabla \n7. Tablas \n8. Compara \n9. Acumulado \n10. Multiplo \n11. Salir de la ejecucion del Programa\n\n\n ");
                NumeroDeOpcion = int.Parse(Console.ReadLine());
                switch (NumeroDeOpcion)
                {
                    case 1:
                        //Programa 1
                        HolaMundo();
                        break;
                    case 2://Programa 2
                        Conversiones();
                        break;
                    case 3://Programa 3
                        Aleatorio();
                        break;
                    case 4://Programa 4
                        Entrada();
                        break;
                    case 5://Programa 5
                        Nombre();
                        break;
                    case 6://Programa 6
                        Tabla();
                        break;
                    case 7://Programa 7
                        Tablas();
                        break;
                    case 8://Programa 8
                        Compara();
                        break;
                    case 9://Programa 9
                        Acumulado();
                        break;
                    case 10://Programa 10
                        Multiplo();
                        break;
                    case 11:

                        break;
                    default: Console.WriteLine("Numero No Valido\nPresiona ENTER para continuar");
                        Console.ReadLine();
                        break;
                }
            }
        }
        static void HolaMundo()
        {//Mensaje que se desea mostrar
            Console.WriteLine("Hola Mundo");
            //Pausa que se reanuda con un ENTER
            Console.ReadLine();
        }
        static void Conversiones()
        {//Declaracion de una variable de tipo String
            String numero = "1234";
            //Sintaxis para obtener el tipo de dato de la variable numero
            Console.WriteLine(numero.GetType().ToString());
            //Se hace una conversion a int
            int intNumero = Convert.ToInt32(numero);
            //Sintaxis para el tipo de dato de la variable
            Console.WriteLine(intNumero.GetType().ToString());
            //Hace una macrosubstituciones
            Console.WriteLine(String.Format("El numero es {0}", intNumero));
            Console.ReadLine();
        }
        static void Aleatorio()
        {
            float numero2 = 0.02F;
            //Sintaxis para hacer num aleatorio
            Random numAleatorio = new Random();
            numero2 = (float)numAleatorio.Next(1, 11);
            Console.WriteLine(string.Format("La suma de {0} y {1} es {2}", numero1, numero2, numero1 + numero2));
            Console.ReadLine();
        }
        static void Entrada()
        {//Declaraciones
            String valor;
            int receptora = 0;
            Console.Write("Escribe algo: ");
            valor = Console.ReadLine();
            //uso de condicion
            if (int.TryParse(valor, out receptora))
            {
                Console.WriteLine(String.Format("Dato entero {0}. Muy bien", valor));
            }//entonces
            else
            {
                Console.WriteLine(String.Format("Dato no es entero. Intentar de nuevo", receptora));
            }

            Console.WriteLine("\nPresiona INTRO para Continuar");
            Console.ReadKey();
        }
        static void Nombre()
        {
            String nombre;
            String apellidos;
            Console.Write("Captura un nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Captura los apellidos: ");
            apellidos = Console.ReadLine();
            //Se convierten en mayusculas
            nombre = nombre.ToUpper();
            apellidos = apellidos.ToUpper();
            //Se crea como StringBuilder para usar menos espacio
            StringBuilder nombreCompleto = new StringBuilder(nombre);
            nombreCompleto.Append("");
            nombreCompleto.Append(apellidos);
            Console.WriteLine(nombreCompleto);
            //mensaje
            Console.WriteLine("");
            Console.WriteLine("Presiona INTRO para continuar");
            Console.ReadKey();
        }
    
        static void Tabla()
        { int numero;

            Console.WriteLine("Menciona un numero del 1 al 9");
            numero = int.Parse(Console.ReadLine());
            //uso de ciclo para cambiar el numero a multiplicar por el numero deseado
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n{0} X {1} = {2}", numero,i,numero*i);

            }
            Console.ReadLine();
        }
        static void Tablas()
        {//ciclo para cambiar el numero de la izquierda
            for(int i = 1; i <= 10; i++)
{
                Console.WriteLine("");
                Console.WriteLine(String.Format("Tabla del {0}: ", i));
                Console.WriteLine("");
                //uso de ciclo para cambiar el numero a multiplicar por el numero deseado
                for (int j = 1; j <= 10; j++)
{
                    Console.WriteLine(
                    String.Format("{0} x {1} = {2}",i,j,i* j));
                   
                }
            }
            Console.ReadLine();
        }
        static void Compara()
        {
            string _numero1, _numero2;
            int numero1, numero2;
            Console.Write("Numero 1: ");
            _numero1 = Console.ReadLine();
            Console.Write("Numero 2: ");
            _numero2 = Console.ReadLine();
            numero1 = Convert.ToInt32(_numero1);
            numero2 = Convert.ToInt32(_numero2);
            //condicion para saber si es igual
            if (numero1 == numero2)
            {
                Console.WriteLine(
                 String.Format(
                   "Números proporcionados {0} y {1}. {2}",
                 numero1, numero2, "Los numeros son iguales. "));
            }
            else
            {//condicion para comparar
                if (numero1 > numero2)
                {
                    Console.WriteLine(
                     String.Format(
                       "Numeros proporcionados {0} y {1}. {2}",
                   numero1, numero2, "El mayor es el primero. "));
                }//entonces
                else
                {
                    Console.WriteLine(
                     String.Format(
                      "Numeros proporcionados {0} y {1}. {2}",
                    numero1, numero2, "El mayor es el segundo. "));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Presiona INTRO para continuar");
            Console.ReadKey();
        }
    
        static void Acumulado()
        { string _numero;
            int numero;
            int acumulado = 0;

            Console.WriteLine("Capturar los numeros enteros a calcular\n\nDejar vacio y presionar ENTER para salir/n");
            while (true)
            {
                Console.WriteLine("Escribe un numero entero: ");
                _numero = Console.ReadLine();
                //condicion para acumular valores o no hacerlos
                if(_numero=="")
                {
                    break;
                }
                else
                {//Condicion
                    if (int.TryParse(_numero, out numero))
                    {
                        acumulado += numero;
                        Console.WriteLine(String.Format("Monto acumulado: {0}", acumulado));
                    }
                    else
                    {
                        Console.WriteLine("El dato proporcionado no es entero\nIntenta de nuevo");
                    }
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
            }
        }
        static void Multiplo()
        {
            String _numero;
            int numero;
            bool esMultiplo3, esMultiplo5, esMultiplo7;
            try
{
                Console.Write("Dame un numero entero: ");
                _numero = Console.ReadLine();
                numero = Convert.ToInt32(_numero);
                //Declaracion de como seran los multiplos
                esMultiplo3 = ((numero % 3) == 0);
                esMultiplo5 = ((numero % 5) == 0);
                esMultiplo7 = ((numero % 7) == 0);
                //condicion que determinara si es multiplo
                if((esMultiplo3 & esMultiplo5) | esMultiplo7)
                { 

                    Console.WriteLine("Correcto");
                }  //entonces negara que es multiplo
                else
{
                    Console.WriteLine("Incorrecto");
                }
            }
            catch(Exception e)
{
                Console.WriteLine("El dato proporcionado causa errores.");
                Console.WriteLine(e.Message);
            }
            finally
{
                Console.WriteLine("");
                Console.WriteLine("Presiona INTRO para continuar");
                Console.ReadKey();
            }
        }
    }
}
