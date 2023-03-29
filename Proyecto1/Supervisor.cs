using System;

namespace Proyecto1
{
    public class Supervisor : Persona
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
}