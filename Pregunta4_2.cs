using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CL1
{
    class Pregunta4_2
    {

        static void Main()
        {

            string archivo = "D:\\cibertec\\cliente.txt";
            StreamReader Lector;
            string cliente;

            try
            {
                Lector = new StreamReader(archivo);
                while ( (cliente = Lector.ReadLine()) != null)
                {
                    Console.WriteLine(cliente);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }

            Console.ReadLine();

        }

    }
}
