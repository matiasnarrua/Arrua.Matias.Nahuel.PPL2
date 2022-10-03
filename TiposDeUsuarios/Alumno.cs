﻿using System;
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
        private string _examenNombre = " ";
        private int _examenNota;
        private string _estadoMateria = "";
        EstadoDelAlumno estadoDelAlumno = EstadoDelAlumno.SinEstado;



        public Alumno(string user, string pass) : base(user, pass)
        {

        }
        public Alumno(string user, string pass, string nombre) : base(user, pass)
        {
            this.Nombre = nombre;

        }
        public Alumno(string user, string pass, string nombre, string materiaCursada, string examenNombre, int examenNota, EstadoDelAlumno estado, string estadoMateria) : this(user, pass, nombre)
        {

            this.MateriaCursada = materiaCursada;
            this.ExamenNombre = examenNombre;
            this.ExamenNota = examenNota;
            this.EstadoDelAlumno = estado;
            this.EstadoMateria = estadoMateria; 
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string MateriaCursada { get => _materiaCursada; set => _materiaCursada = value; }

        public EstadoDelAlumno EstadoDelAlumno { get => estadoDelAlumno; set => estadoDelAlumno = value; }
        public string ExamenNombre { get => _examenNombre; set => _examenNombre = value; }
        public int ExamenNota { get => _examenNota; set => _examenNota = value; }
        public string EstadoMateria { get => _estadoMateria; set => _estadoMateria = value; }

        public override void AgregarUsuario(string user, string pass, string nombre)
        {
            Datos.listaAlumnos.Add(new Alumno(user.ToLower(), pass, Datos.HacerPrimerLetraMayus(nombre)));
        }


        public static bool operator ==(Alumno nota1,int nota)
        {
            if(nota1.ExamenNota>nota)
            {
                return true;
            }
         return false;
        }
        public static bool operator !=(Alumno nota1, int nota)
        {

            return !(nota1.ExamenNota == nota);
        }

    }
}
