using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Materia
    {
        public string nombre;

        public List<Materia> listaMaterias = new List<Materia>();

        public Materia()
        {

        }

        public Materia(string nombre):this()
        {
            this.nombre = nombre;
        }             

        

        

        
    }
}


