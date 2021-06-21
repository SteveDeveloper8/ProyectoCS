using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Administrador : Empleado
    {
        public Administrador(int id, string codigo, string nombre, string apellidos, string genero, int edad, Usuario usuario) : base(id, codigo, nombre, apellidos, genero, edad, usuario)
        {
        }
    }
}
