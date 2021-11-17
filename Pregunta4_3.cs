using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CL1
{
    class Pregunta4_3
    {
        static void Main()
        {
            string archivo = "D:\\cibertec\\cliente.txt";

            byte[] Cliente = File.ReadAllBytes(archivo);
            MemoryStream memoria = new MemoryStream(Cliente);

            int texto;

            while ((texto = memoria.ReadByte()) >= 0)
            {
                Console.Write(Convert.ToChar(texto));

            }

            Console.ReadLine();
        }
    }
}
