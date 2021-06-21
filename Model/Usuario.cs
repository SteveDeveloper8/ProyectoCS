using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        private int id;
        private string username;
        private string contrasena;
        private string rol;


        public Usuario(int id, string username, string contrasena, string rol)
        {
            this.id = id;
            this.username = username;
            this.contrasena = contrasena;
            this.rol = rol;
        }



        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Rol { get => rol; set => rol = value; }
    }

}
