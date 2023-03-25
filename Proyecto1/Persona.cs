using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Persona
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
    internal class Empleado : Persona
    {
        private Supervisor supervisor;

        public Empleado(string nombre, string apellido, int dni, string direccion, int edad, int telefono, double salario, int añosAntiguedad, Supervisor supervisor) : base(nombre, apellido, dni, direccion, edad, telefono, salario, añosAntiguedad)
        {
            this.supervisor = supervisor;
        }

        public override string Presentarse()
        {
            string presentacion = "Hola soy " + this.nombre + " " + this.apellido + " tengo " + this.edad + " años y mi supervisor es " + this.supervisor.nombre + " " + this.supervisor.apellido;
            return presentacion;
        }

        public override void aumentarSalario()
        {
           this.salario = salario * 1.1;
        }

        public void cambiarSupervisor(Supervisor supervisor)
        {
            this.supervisor = supervisor;
        }

    }

    internal class Supervisor : Persona
    {
        private Secretario secretario;
        private Coche coche;

        public Supervisor(string nombre, string apellido, int dni, string direccion, int edad, int telefono, double salario, int añosAntiguedad, Coche coche, Secretario secretario) : base(nombre, apellido, dni, direccion, edad, telefono, salario, añosAntiguedad)
        {
            this.coche = coche;
            this.secretario = secretario;
        }

        public override void aumentarSalario()
        {
            this.salario = salario * 1.2;
        }

        public void cambiarCoche(Coche coche)
        {
            this.coche = coche;
        }

        public void cambiarSecretario(Secretario secretario)
        {
            this.secretario = secretario;
        }
    }

    internal class Secretario : Persona
    {



        public Secretario(string nombre, string apellido, int dni, string direccion, int edad, int telefono, double salario, int añosAntiguedad) : base(nombre, apellido, dni, direccion, edad, telefono, salario, añosAntiguedad)
        {
           
        }
        
    }
}
