using System;

namespace Proyecto1
{
    public class Empleado : Persona

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
            double aumento = 1.10;
            aumento = aumento + this.añosAntiguedad * 0.01;
            if (this.edad >= 60) { aumento = aumento + 0.05; };
            this.salario = salario * aumento;
        }

        public void cambiarSupervisor(Supervisor supervisor)
        {
            this.supervisor = supervisor;
        }

    }
}