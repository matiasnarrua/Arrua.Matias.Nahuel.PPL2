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
            BindingSource bs = new BindingSource();
            bs.DataSource = Datos.listaMaterias;
            dgv_Materias.DataSource = bs;
        }


        private void frm_IncripcionMaterias_Load(object sender, EventArgs e)
        {

        }



    }
}


