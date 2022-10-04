using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiposDeUsuarios;


namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{   
    public partial class frm_AsignarMateria : Form
    {        
        public frm_AsignarMateria()
        {
            InitializeComponent();
            CargarDgv();
            CargarCmb();
            
        }
        
        

        private void btn_AceptarAltaAlumno_Click(object sender, EventArgs e)
        {
            
            foreach (Alumno alumnoAux in Datos.listaAlumnos)
            {
                if (alumnoAux.User == txt_UserAlumno.Text) {

                    if (MessageBox.Show($"Va a inscribir en {cmb_Materias.Text} al usuario {txt_UserAlumno.Text} . Esta seguro?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Datos.CargarListaAlumnos(alumnoAux.User, alumnoAux.Pass, alumnoAux.Nombre, cmb_Materias.Text, " ", 0, TiposDeUsuarios.EstadoDelAlumno.SinEstado, " - ");

                        break;
                    }
                }
                
            }
            CargarDgv();


        }

        private void CargarCmb()
        {
            foreach (Materia materia in Datos.listaMaterias)
            {
                cmb_Materias.Items.Add(materia.Nombre);
            }
        }

        private void CargarDgv()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Datos.listaAlumnos;
            dgv_Usuarios.DataSource = bs;
        }
    }
}
