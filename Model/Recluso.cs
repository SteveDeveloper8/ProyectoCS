using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Recluso : Persona
    {
        private Expediente expediente;

        public Recluso(string codigo, string nombre, string apellidos, string genero, int edad, Expediente expediente) : base(codigo, nombre, apellidos, genero, edad)
        {
            this.expediente = expediente;
        }

        public Recluso(int id, string codigo, string nombre, string apellidos, string genero, int edad, Expediente expediente) : base(id, codigo, nombre, apellidos, genero, edad)
        {
            this.expediente = expediente;
        }

        internal Expediente Expediente { get => expediente; set => expediente = value; }
    }
}
