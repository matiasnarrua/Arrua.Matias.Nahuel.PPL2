using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Profesor : Usuario
    {
        private string _nombre= " ";       
       private string _materiaAsignada = "";
        
        public Profesor(string user, string pass) : base(user, pass)
        {

        }
        public Profesor(string user, string pass, string nombre) : base(user, pass)
        {
            this.Nombre = nombre;
          
        }
        public Profesor(string user, string pass,  string nombre, string materiaAsignada) : this(user, pass,nombre)
        {
           
            this.MateriaAsignada = materiaAsignada;
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string MateriaAsignada { get => _materiaAsignada; set => _materiaAsignada = value; }

        public override void AgregarUsuario(string user, string pass, string nombre)
        {
            Datos.listaProfesores.Add(new Profesor(user.ToLower(), pass, Datos.HacerPrimerLetraMayus(nombre)));
        }
    }
}
