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
        public static List<Examen> listaExamenes = new List<Examen>();
        public static List<string> listaPresentes = new List<string>();
        public static bool flag = true;

        #region Materias
        public static void CargarListaMaterias(string nombre,string cuatri,string profesor,string correlativa)
        {
            listaMaterias.Add(new Materia(nombre,cuatri,profesor,correlativa));
        }
        public static void HardcodearListaMaterias()
        {

            CargarListaMaterias( "Matematica I", "Primero", "-","-");
            CargarListaMaterias("Laboratorio I","Primero","Felipe","-");
            CargarListaMaterias("Programacion I", "Primero", "Mario", "-");
            CargarListaMaterias("Ingles I","Primero","-", "-");
            CargarListaMaterias("Ingles II", "Segundo", "-","Ingles I");
            CargarListaMaterias("Programacion II", "Segundo", "-", "Programacion I");
        }
              
       
        #endregion

        #region Alumnos
       
         public static void CargarListaAlumnos(string user, string pass, string nombre, string materiaCursada,int nota1,int nota2,EstadoDelAlumno estado)
        {
            listaAlumnos.Add(new Alumno(user, pass, nombre, materiaCursada,nota1,nota2,estado));
        }

        public static void HardcodearListaAlumnos()
        {
                       
            CargarListaAlumnos("alumno1@utn.com", "alumno1", "Pedro", "Programacion I",7 ,8, EstadoDelAlumno.Regular );
            CargarListaAlumnos("alumno1@utn.com", "alumno1", "Pedro", "Laboratorio I", 4, 5,EstadoDelAlumno.Libre);
            CargarListaAlumnos("alumno1@utn.com", "alumno1", "Pedro", "Matematica I",0,0,EstadoDelAlumno.SinEstado);
            CargarListaAlumnos("alumno2@utn.com", "alumno2", "Carlos", "Matematica I",0,0, EstadoDelAlumno.SinEstado);
            CargarListaAlumnos("alumno3@utn.com", "alumno3", "Camila", "-",0,0, EstadoDelAlumno.SinEstado);         

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
       


        #endregion

        #region Profesor
        public static void CargarListaProfesor(string user, string pass, string nombre, string materia)
        {
            listaProfesores.Add(new Profesor(user, pass, nombre, materia));
        }

        public static void HardcodearListaProfesores()
        {   
            Materia materia = new Materia(" ");
            materia.Nombre = "Programacion I";
            CargarListaProfesor("profesor@utn.com", "profesor", "Mario", "Programacion I");
            materia.Nombre = "-";
            CargarListaProfesor("profesor2@utn.com", "profesor2", "Felipe", "Laboratorio I");
            materia.Nombre = "-";
            CargarListaProfesor("profesor3@utn.com", "profesor3", "Daniel", "-");
            materia.Nombre = "-";
            CargarListaProfesor("profesor4@utn.com", "profesor4", "Nuria", "-");

        }




        #endregion

        #region Examenes

        public static void CargarListaExamenes(string nombre, DateTime fecha,string materia)
        {
            listaExamenes.Add(new Examen(nombre, fecha, materia));
        }
        public static void HardcodearListaExamenes()
        {
            DateTime fecha = new DateTime(2022, 04, 05);
            DateTime fecha2 = new DateTime(2022, 04, 25);
            CargarListaExamenes("Primer Parcial", fecha, "Programacion I");
            CargarListaExamenes("Primer Parcial", fecha2, " ");
            
        }

       
        #endregion



        public static void HardcodearListas()
        {
            HardcodearListaMaterias();
            HardcodearListaAlumnos();
            HardcodearListaAdmins();
            HardcodearListaProfesores();
            HardcodearListaExamenes();

        }

        public static string HacerPrimerLetraMayus(this string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        public static bool BuscarMismoUser(string user, List<Admin> lista)
        {

            foreach (Admin admin in lista)
            {
                if (admin.User == user)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool BuscarMismoUser(string user, List<Alumno> lista)
        {

            foreach (Alumno alumno in lista)
            {
                if (alumno.User == user)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool BuscarMismoUser(string user, List<Profesor> lista)
        {

            foreach (Profesor profesor in lista)
            {
                if (profesor.User == user)
                {
                    return true;
                }
            }
            return false;
        }

        public static Profesor DevolverProfesor(string user, List<Profesor> lista)
        {
            Profesor pf =new Profesor("","");
            foreach (Profesor profesor in lista)
            {
                if (profesor.User == user)
                {
                    return profesor;
                }
            }
            return pf ;
        }
        public static Alumno DevolverAlumno(string user, List<Alumno> lista)
        {
            Alumno alum = new Alumno("", "");
            foreach (Alumno alumno in lista)
            {
                if (alumno.User == user)
                {
                    return alumno;
                }
            }
            return alum;
        }
        public static bool VerificarCantidadMaterias(List<Alumno> list  )
        {
            int count = 0;  
            foreach (Alumno item in list)
            {
                count++;    
            }
            if(count >= 2)
            {
                return false;
            }
            return true;
        }
        public static List<Alumno> DevolverMateriasCursadas(Alumno alumno)
        {
            List<Alumno> listAux = new List<Alumno>();
            Alumno alumnoAux = new Alumno("", "");

            foreach (Alumno alumno1 in Datos.listaAlumnos)
            {
                if (alumno.User == alumno1.User)
                {
                    listAux.Add(alumno1);
                }

            }
            return listAux;
        }
    }
}
