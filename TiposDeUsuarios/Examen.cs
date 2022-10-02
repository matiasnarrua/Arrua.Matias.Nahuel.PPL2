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
        private DateTime _fecha;
        private string _materia="";
        private int _nota1;
        private int _nota2;

        public Examen()
        {

        }
        public Examen(string nombre, DateTime fecha, string materia) : this()
        {
           this.Nombre = nombre;
            this.Fecha = fecha;
            this.Materia = materia;
        }
        public Examen(string nombre, DateTime fecha, string materia, int nota1,int nota2) : this(nombre,fecha, materia)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }        
        public string Materia { get => _materia; set => _materia = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Nota1 { get => _nota1; set => _nota1 = value; }
        public int Nota2 { get => _nota2; set => _nota2 = value; }
    }
}


