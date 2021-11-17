using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente obj = new Cliente();
            Console.WriteLine(obj.VerCliente());



            Cliente obj2 = new Cliente("123","Soto","nombre","Santa Clara", 15, true);
            Console.WriteLine(obj2.VerCliente());


            Console.ReadLine();


        }
    }
}
