using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuarios
{
    public static class Datos
    {
        public static List<Materia> listaMaterias = new List<Materia>();
        public static List<Alumno> listaAlumnos = new List<Alumno>();
        public static List<Admin> listaAdmins = new List<Admin>();
        public static List<Profesor> listaProfesores = new List<Profesor>();

        #region Materias
        public static void CargarListaMaterias(string nombre)
        {
            listaMaterias.Add(new Materia(nombre));
        }
        public static void HardcodearListaMaterias()
        {

            CargarListaMaterias( "Matematica I");
            CargarListaMaterias( "Laboratorio I");
            CargarListaMaterias( "Programacion I");
            CargarListaMaterias( "Ingles I");
        }
               
        public static List<Materia> LlamarListaMaterias()
        {
            return listaMaterias ;
        }
        #endregion


        #region Alumnos
       
         public static void CargarListaAlumnos(string user, string pass, string nombre, List<Materia> materiasCursadas)
        {
            listaAlumnos.Add(new Alumno(user, pass, nombre, materiasCursadas));
        }

        public static void HardcodearListaAlumnos()
        {
            List<Materia> materiasCursadas = new List<Materia>();  
            Materia materia = new Materia("Matematica I");            
            materiasCursadas.Add(materia);
            materia.nombre = "Programacion I";
            materiasCursadas.Add(materia);
            CargarListaAlumnos("alumno1@utn.com", "alumno1", "Pedro",materiasCursadas );            
            CargarListaAlumnos("alumno2@utn.com", "alumno2", "Carlos", materiasCursadas);
            CargarListaAlumnos("alumno3@utn.com", "alumno3", "Camila", materiasCursadas);         

        }
        public static List<Alumno> LlamarListaAlumnos()
        {
            return listaAlumnos;
        }


        #endregion

        #region Admins
        public static void CargarListaAdmin(string user, string pass, string nombre)
        {
            listaAdmins.Add(new Admin(user, pass, nombre));
        }

        public static void HardcodearListaAdmins()
        {
            CargarListaAdmin("admin@utn.com", "admin", "Julian");
            CargarListaAdmin("admin2@utn.com", "admin2", "Belen");
           
        }
        public static List<Admin> LlamarListaAdmins()
        {
            return listaAdmins;
        }


        #endregion


        #region Profesor
        public static void CargarListaProfesor(string user, string pass, string nombre,Materia materia)
        {
            listaProfesores.Add(new Profesor(user, pass, nombre, materia));
        }

        public static void HardcodearListaProfesores()
        {   
            Materia materia = new Materia();
            materia.nombre = "Programacion I";
            CargarListaProfesor("profesor@utn.com", "profesor", "Mario",materia);
            materia.nombre = " ";
            CargarListaProfesor("profesor2@utn.com", "profesor2", "Felipe",materia);

        }
        public static List<Profesor> LlamarListaProfesores()
        {
            return listaProfesores;
        }



        #endregion




        public static void HardcodearListas()
        {
            HardcodearListaMaterias();
            HardcodearListaAlumnos();
            HardcodearListaAdmins();
            HardcodearListaProfesores();

        }

        public static string HacerPrimerLetraMayus(this string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }
    }
}
