using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Alumno : Usuario
    {
        private string _nombre = " ";
        private string _materiaCursada = " ";
        private int _nota1;
        private int _nota2;
        EstadoDelAlumno estadoDelAlumno = EstadoDelAlumno.SinEstado;
        
       
        
        public Alumno(string user, string pass) : base(user, pass)
        {

        }
        public Alumno(string user, string pass, string nombre) : base(user, pass)
        {
            this.Nombre = nombre;            

        }
        public Alumno(string user, string pass, string nombre, string materiaCursada,int nota1, int nota2,EstadoDelAlumno estado) : this(user, pass,nombre)
        {
            
            this.MateriaCursada = materiaCursada;   
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.EstadoDelAlumno = estado;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string MateriaCursada { get => _materiaCursada; set => _materiaCursada = value; }
        public int Nota1 { get => _nota1; set => _nota1 = value; }
        public int Nota2 { get => _nota2; set => _nota2 = value; }
        public EstadoDelAlumno EstadoDelAlumno { get => estadoDelAlumno; set => estadoDelAlumno = value; }

        public override void AgregarUsuario(string user, string pass, string nombre)
        {
            Datos.listaAlumnos.Add(new Alumno(user.ToLower(), pass, Datos.HacerPrimerLetraMayus(nombre)));
        }
    }
}
