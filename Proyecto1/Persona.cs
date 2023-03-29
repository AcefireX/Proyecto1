using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Persona
    {
        internal string nombre { get; set; }
        internal string apellido { get; set; }
        internal int dni;
        internal string direccion;
        internal int edad;
        internal int telefono;
        internal double salario;
        internal int añosAntiguedad;

        public Persona(string nombre, string apellido, int dni, string direccion, int edad, int telefono, double salario, int añosAntiguedad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.edad = edad;
            this.telefono = telefono;
            this.salario = salario;
            this.añosAntiguedad = añosAntiguedad;
        }

        public virtual string Presentarse()
        {
            return "Hola soy " + this.nombre + " " + this.apellido + " tengo " + this.edad;
        }

        public virtual void aumentarSalario()
        {
           
        }
        
        public double mostrarSalario()
        {
            return this.salario;
        }

    }
}
