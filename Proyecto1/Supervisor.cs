using System;

namespace Proyecto1
{
    public class Supervisor : Persona
    {
            private Secretario secretario;
            private Coche coche;

            public Supervisor(string nombre, string apellido, int dni, string direccion, int edad, int telefono, double salario, int añosAntiguedad, Coche coche, Secretario secretario, DateTime fNacimiento) : base(nombre, apellido, dni, direccion, edad, telefono, salario, añosAntiguedad, fNacimiento)
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

            public override void aumentarSalarioAntiguedad()
            {
               Double salarioNeto = this.salario;

               this.salario = this.salario + ((salarioNeto * 0.01) * this.añosAntiguedad);

            }

            public void cambiarSecretario(Secretario secretario)
            {
                this.secretario = secretario;
            }
        
    }
}