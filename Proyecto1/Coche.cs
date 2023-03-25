using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Coche
    {
        private string matricula;
        private string marca;
        private string modelo;

        public  Coche(string matricula, string marca, string modelo)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }
    }
}
