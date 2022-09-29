using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiposDeUsuarios;

namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    public partial class frm_AltaAdmin : Form
    {
        public frm_AltaAdmin()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = Datos.listaAdmins;
            dgv_Usuarios.DataSource = bs;
        }

        private void btn_AceptarAltaAdmin_Click(object sender, EventArgs e)
        {
            Datos.listaAdmins.Add(new Admin(txt_UserAdminAlta.Text, txt_PassAdminAlta.Text.ToLower(), Datos.HacerPrimerLetraMayus(  txt_NombreAdminAlta.Text)   ));
            MessageBox.Show($"El usuario {Datos.HacerPrimerLetraMayus(txt_NombreAdminAlta.Text)} Fue dado de alta");
            
        }

        //TODO-- crear funcion para comprar si hay un mail existente y agregarla al sumar un admin


        
    }
}   
