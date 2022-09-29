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
        public  List<Materia> materiasCursadas =new List<Materia>();
        
       
        
        public Alumno(string user, string pass) : base(user, pass)
        {

        }
        public Alumno(string user, string pass, string nombre, List<Materia> materiasCursadas) : base(user, pass)
        {
            this.Nombre = nombre;
            this.materiasCursadas = materiasCursadas;   
            
        }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public override void PrecargarUsuarios(List<Type> lista)
        {

        }
    }
}
