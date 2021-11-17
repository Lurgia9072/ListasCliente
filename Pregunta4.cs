using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CL1
{
    class Pregunta4
    {
        static  void Main()
        {

            string archivo = "D:\\cibertec\\cliente.txt";
            StreamWriter escritor = null;

            try
            {
                escritor = File.CreateText(archivo);
                do
                {

                    Cliente obj = new Cliente();
                    Console.WriteLine("REGISTRO DE LOS CLIENTE ");
                    Console.Write("ID cliente: "); obj.IdCliente = Console.ReadLine();
                    Console.Write("Apellidos: "); obj.Apellidos = Console.ReadLine();
                    Console.Write("Nombre:  "); obj.Nombre = Console.ReadLine();
                    Console.Write("Direccion:  "); obj.Direccion = Console.ReadLine();
                    Console.Write("Edad: "); obj.Edad = Int32.Parse(Console.ReadLine());
                    Console.Write("Sexo: "); obj.Sexo =Boolean.Parse(Console.ReadLine());

                    escritor.WriteLine(obj.IdCliente + " " + obj.Apellidos + " " + obj.Nombre +
                        " " + obj.Direccion + " " + obj.Edad + " " + obj.Sexo );

                    Console.Write("DESEA CONTINUAR S/N: ");


                } while (Console.ReadLine()=="S");


                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
