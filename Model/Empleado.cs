using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Empleado:Persona
    {
        private bool estado;
        private Usuario usuario;

        protected Empleado(int id, string codigo, string nombre, string apellidos, string genero, int edad, Usuario usuario) : base(id, codigo, nombre, apellidos, genero, edad)
        {
        }

        protected Empleado(string codigo, string nombre, string apellidos, string genero, int edad,bool estado, Usuario usuario) : base(codigo, nombre, apellidos, genero, edad)
        {
            this.estado = estado;
            this.usuario = usuario;
        }


    }
}
