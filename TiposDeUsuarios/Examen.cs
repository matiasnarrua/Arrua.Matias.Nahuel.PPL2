using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Examen
    {
        private string _nombre ="";
        private DateOnly _fecha;
        private string _materia="";

        public Examen(string nombre, DateOnly fecha,string materia)
        {
           this.Nombre = nombre;
            this.Fecha = fecha;
            this.Materia = materia;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }        
        public string Materia { get => _materia; set => _materia = value; }
        public DateOnly Fecha { get => _fecha; set => _fecha = value; }
    }
}


