using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiposDeUsuarios;
using Arrua.Matias.Nahuel.Tp1;


namespace Arrua.Matias.Nahuel.Tp1.AlumnoPages
{
    public partial class frm_InscripcionMaterias : Form
    {
        Alumno alumno = new Alumno("", "");

        public frm_InscripcionMaterias()
        {
            InitializeComponent();
            
        }
        public frm_InscripcionMaterias(Alumno alumno1) : this()
        {
            this.alumno = alumno1;

            CargarCmbs(alumno);

        }


        private void frm_InscripcionMaterias_Load(object sender, EventArgs e)
        {

        }

        private void btn_Inscribirse_Click(object sender, EventArgs e)
        {
            
          
            if (MessageBox.Show($"Se va a inscribir en{cmb_Materias.Text}. Esta seguro?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                alumno.MateriaCursada = cmb_Materias.Text;
                alumno.Nota2 = 0;
                alumno.Nota1 = 0;
                alumno.EstadoDelAlumno = EstadoDelAlumno.SinEstado;
                Datos.listaAlumnos.Add(alumno);

            }
            
            
        }


        ///TODO - 8 Tiene que estar aprobada la materia para podes inscribirse, No tiene que ser regular
        ///mostrar todas las materias y en caso de querer anotarse en una, donde su correlativa esta desaprobada no dejar anotarse
        
        private void CargarCmbs(Alumno alumno)
        {
            List<Alumno> list = new List<Alumno>();
            list = Datos.DevolverMateriasCursadas(alumno);

            foreach (Alumno alum in list)
            {
                foreach (Materia materia in Datos.listaMaterias)
                {
                    if(materia.MateriaCorrelativa == "-")
                    {
                        if(materia.Nombre != alum.MateriaCursada)
                        {
                            cmb_Materias.Items.Add(materia.Nombre);
                        }
                    }
                    else if(materia.MateriaCorrelativa != "-" && EstadoDelAlumno.Regular == alum.EstadoDelAlumno )
                    {
                        if (materia.Nombre != alum.MateriaCursada)
                        {
                            cmb_Materias.Items.Add(materia.Nombre);
                        }
                    }
                    
                }
            }

        }

    }
}


