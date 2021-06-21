using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Docente:Empleado
    {
        private string profesion;

        public Docente(int id, string codigo, string nombre, string apellidos, string genero, int edad, Usuario usuario, string profesion) : base(id, codigo, nombre, apellidos, genero, edad, usuario)
        {
            this.profesion = profesion;
        }

        public Docente(string codigo, string nombre, string apellidos, string genero, int edad, bool estado, Usuario usuario, string profesion) : base(codigo, nombre, apellidos, genero, edad, estado, usuario)
        {
            this.profesion = profesion;
        }

        public string Profesion { get => profesion; set => profesion = value; }
    }
}
