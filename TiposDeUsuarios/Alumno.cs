using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public class Alumno : Usuario
    {
        private int id;
        public Alumno(string user, string pass) : base(user, pass)
        {

        }
        public Alumno(string user, string pass, int id) : base(user, pass)
        {
            this.id = id;
        }

    }
}
