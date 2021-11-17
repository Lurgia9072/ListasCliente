using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL1
{
    class Cliente
    {
        public string IdCliente { set; get; }
        public string Apellidos { set; get; }
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public int Edad { set; get; }
        public bool Sexo { set; get; }

        //Cosntructor vacio
        public Cliente()
        {

            this.IdCliente = "001";
            this.Apellidos = "Soto";
            this.Nombre = "Andreaa";
            this.Direccion = "Agustino";
            this.Edad = 20;
            this.Sexo = false;
        }
        //Constructor inicializado
        public Cliente(string idCliente, string apellidos, string nombre, string direccion, int edad, bool sexo)
        {
            this.IdCliente = idCliente;
            this.Apellidos = apellidos;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Sexo = sexo;
        }

        //Metodo 

        public string VerCliente()
        {
            return "ID cliente: " + this.IdCliente + "\nApellidos: "
                + this.Apellidos + "\nNombre: " + this.Nombre + "\nDireccion: " +
                this.Direccion + "\nEdad: " + this.Edad + "\nSexo: " + this.Sexo;
        }


    }
}
