using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arrua.Matias.Nahuel.Tp1.AdminPages;

namespace Arrua.Matias.Nahuel.Tp1
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        #region Mover ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wrsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void AbrirFormHijo(Form formHijo)
        {
          if (this.pnl_Contenedor.Controls.Count > 0) {           
                this.pnl_Contenedor.Controls.RemoveAt(0);
            }
            Form fh =  formHijo; 
                fh.TopLevel = false;
                fh.Dock =DockStyle.Fill;
                this.pnl_Contenedor.Controls.Add(fh);
                this.pnl_Contenedor.Tag = fh;
                fh.Show();
            
           
        }

        private void btn_AddAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frm_AltaAdmin());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frm_AltaAlumno());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frm_AltaProfesor());
        }
    }
}
