using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Materia
    {
        private string _nombre = "";
        private string _cuatrimestre="" ;
        private string _profesor = "";
        private List<Alumno> _materiaAlumnos = new List<Alumno>();
        private string _materiaCorrelativa = "";


       
        public Materia()
        {

        }
        public Materia(string nombre):this()
        {
            this.Nombre = nombre;
        }

        public Materia(string nombre, string cuatrimestre, string profesor,string correlativa):this(nombre)
        {
            _nombre = nombre;
            _cuatrimestre = cuatrimestre;
            _profesor = profesor;
            _materiaCorrelativa =correlativa;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }      
        public string Cuatrimestre { get => _cuatrimestre; set => _cuatrimestre = value; }
        public string Profesor { get => _profesor; set => _profesor = value; }
        public List<Alumno> MateriaAlumnos { get => _materiaAlumnos; set => _materiaAlumnos = value; }
        public string MateriaCorrelativa { get => _materiaCorrelativa; set => _materiaCorrelativa = value; }


        public void CargarMateria(string nombre, string cuatrimestre, string correlativa)
        {
            Datos.listaMaterias.Add(new Materia(Datos.HacerPrimerLetraMayus(nombre), Datos.HacerPrimerLetraMayus(cuatrimestre), "-", Datos.HacerPrimerLetraMayus(correlativa)));
        }

    }
}


