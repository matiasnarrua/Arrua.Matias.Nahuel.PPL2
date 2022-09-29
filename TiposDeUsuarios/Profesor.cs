using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Profesor : Usuario
    {
        public string nombre= " ";
        public Materia materiaAsignada = new Materia();

        
        public Profesor(string user, string pass) : base(user, pass)
        {

        }

        public Profesor(string user, string pass,  string nombre, Materia materiaAsignada) : base(user, pass)
        {
            this.nombre = nombre;
            this.materiaAsignada = materiaAsignada;
        }

        public override void PrecargarUsuarios(List<Type> lista)
        {
            
        }
    }
}
