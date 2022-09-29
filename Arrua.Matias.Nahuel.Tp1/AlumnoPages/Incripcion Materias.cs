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
    public partial class frm_IncripcionMaterias : Form
    {
        

        public frm_IncripcionMaterias()
        {
            InitializeComponent();
            
        }
        

        private void frm_IncripcionMaterias_Load(object sender, EventArgs e)
        {
           // List<Materia> materiaList = new List<Materia>();
            
          //  materiaList = Datos.LlamarListaMaterias();

           BindingSource bs = new BindingSource();                                         
           // bs.DataSource = materiaList;
            bs.DataSource = Datos.LlamarListaMaterias().ToString(); 
            dgv_Materias.DataSource = bs;


            /*List<string> list = new List<string>();
            list.Add("Pepe");
            list.Add("carlo");
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            dgv_Materias.DataSource = bs;*/

            
        }


        
    }
}


