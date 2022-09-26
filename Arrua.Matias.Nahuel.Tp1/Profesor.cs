using Arrua.Matias.Nahuel.Tp1.AlumnoPages;
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
using Arrua.Matias.Nahuel.Tp1.ProfesorPages;

namespace Arrua.Matias.Nahuel.Tp1
{
    public partial class frm_Profesor : Form
    {
        public frm_Profesor()
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

        private void AbrirFormHijo(Form formHijo)
        {
            if (this.pnl_Contenedor.Controls.Count > 0)
            {
                this.pnl_Contenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_Contenedor.Controls.Add(fh);
            this.pnl_Contenedor.Tag = fh;
            fh.Show();

        }
        private void btn_MinimizeProfesor_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_CloseProfesor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CrearExamen_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frm_CrearExamen());           
        }

        private void btn_CargarNota_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frm_CargarNota());
        }
    }
}
