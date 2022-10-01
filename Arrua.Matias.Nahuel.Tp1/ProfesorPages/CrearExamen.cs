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

namespace Arrua.Matias.Nahuel.Tp1.ProfesorPages
{
    public partial class frm_CrearExamen : Form
    {
        public Profesor profesor1 = new Profesor("", "");
        public frm_CrearExamen()
        {
            InitializeComponent();
        }
        public frm_CrearExamen(Profesor profesor) : this()
        {
            this.profesor1 = profesor;
            
            BindingSource bs = new BindingSource();
            
            bs.DataSource = TraerExamenDeSuMateria(profesor1);
            dgv_Examenes.DataSource = bs;
        }


        public List<Examen> TraerExamenDeSuMateria(Profesor profesor)
        {
            List<Examen> listaExamenes = new List<Examen>();

            foreach (Examen examen in Datos.listaExamenes)
            {
                if(examen.Materia == profesor1.MateriaAsignada)
                {
                    
                    listaExamenes.Add(examen);
                }
            }
            return listaExamenes;
        }

        ///TODO -- fehca en int dia mes y anio y fecha completa, todo eso
        ///TODO
        
    }




}
