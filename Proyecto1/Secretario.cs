using System;

namespace Proyecto1
{
	public class Secretario : Persona
	{
		public Secretario(string nombre, string apellido, int dni, string direccion, int edad, int telefono, double salario, int añosAntiguedad) : base(nombre, apellido, dni, direccion, edad, telefono, salario, añosAntiguedad)
        {

        }

        public override void aumentarSalario()
        {
            double aumento = 1.10;
            aumento = aumento + this.añosAntiguedad * 0.01;
            if (this.edad >= 59) { aumento = aumento + 0.05; };
            this.salario = salario * aumento;
        }

    }
}