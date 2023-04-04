using System;

namespace Proyecto1
{
    public class Empleado : Persona

    { 

        private Supervisor supervisor;

        public Empleado(string nombre, string apellido, int dni, string direccion, int edad, int telefono, double salario, int añosAntiguedad, DateTime fNacimiento,  Supervisor supervisor) : base(nombre, apellido, dni, direccion, edad, telefono, salario, añosAntiguedad, fNacimiento)
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

        public override void aumentarSalarioAntiguedad()
        {
           Double salarioNeto = this.salario;

            if (this.fNacimiento.Year < 1964)
            {
                this.salario = (salarioNeto * 0.05) + this.salario;
                Console.WriteLine("entro en el if");
            }

           this.salario = this.salario + ((salarioNeto * 0.01) * this.añosAntiguedad);

        }

        public void cambiarSupervisor(Supervisor supervisor)
        {
            this.supervisor = supervisor;
        }

    }
}