using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Persona
    {
        private string codigo;
        private string nombre;
        private string apellidos;
        private string genero;
        private int edad;

        protected Persona(string codigo, string nombre, string apellidos, string genero, int edad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.genero = genero;
            this.edad = edad;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
