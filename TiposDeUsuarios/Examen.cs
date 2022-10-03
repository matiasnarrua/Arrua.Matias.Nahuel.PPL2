using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Examen
    {
        private string _nombre = "";
        private DateTime _fecha;
        private string _materia = "-";
        private int _nota;


        public Examen()
        {

        }
        public Examen(string nombre, DateTime fecha, string materia) : this()
        {
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Materia = materia;
        }
        public Examen(string nombre, DateTime fecha, string materia, int nota) : this(nombre, fecha, materia)
        {
            this.Nota = nota;

        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Materia { get => _materia; set => _materia = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Nota { get => _nota; set => _nota = value; }

    }
}


