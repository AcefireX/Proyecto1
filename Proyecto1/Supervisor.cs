using System;


namespace Proyecto1
{
    public class Supervisor : Persona
    {
        private Secretario secretario;
        private Coche coche;
        /*creacion de lista vacia de tipo empleado*/
        List<Empleado> listaEmpleados = new List<Empleado>();

        public Supervisor(string nombre, string apellido, int dni, string direccion, int edad, int telefono, double salario, int añosAntiguedad, Coche coche, Secretario secretario, DateTime fNacimiento) : base(nombre, apellido, dni, direccion, edad, telefono, salario, añosAntiguedad, fNacimiento)
        {
            this.coche = coche;
            this.secretario = secretario;
        }

        public override void aumentarSalario()
        {
            double salarioNeto = this.salario;
            this.salario = this.salario + salario * 0.2;

            this.salario = this.salario + ((salarioNeto * 0.01) * this.añosAntiguedad);
            Console.WriteLine(listaEmpleados.Count);
            this.salario = this.salario + ( salarioNeto * (listaEmpleados.Count * 0.01));
        }

        public void cambiarCoche(Coche coche)
        {
            this.coche = coche;
        }



        public void cambiarSecretario(Secretario secretario)
        {
            this.secretario = secretario;
        }

        public double SumaSalarioEmpleados()
        {
            double totalSalario = 0;

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
               totalSalario = totalSalario + listaEmpleados[i].salario;
            }
            return totalSalario;
        }
        public void cargarEmpleadosLista(Empleado empleado)
        {
                listaEmpleados.Add(empleado);
        }




    }
}