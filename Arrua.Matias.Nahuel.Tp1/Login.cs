using System.Runtime.InteropServices;
using TiposDeUsuarios;

namespace Arrua.Matias.Nahuel.Tp1
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        #region Mover ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wrsg, int wparam, int lparam);


        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //TODO : 1 - Chequear contraseña

            if (true)
            {
                this.Hide();
            frm_Admin admin = new frm_Admin();
                admin.Show();
            }
            else
            {
                //TODO : 2 - agregar mensaje de error pass/user mal
            }

        }

        private void btn_PreAdmin_Click(object sender, EventArgs e)
        {
            //TODO : 3 precargar admin en los box
            this.Hide();
            frm_Admin admin = new frm_Admin();
            admin.Show();

        }

        private void btn_PreAlumno_Click(object sender, EventArgs e)
        {//TODO : 3 precargar Alumno en los box
            this.Hide();
           frm_Alumno alumno = new frm_Alumno();
            alumno.Show();
        }

        private void btn_PreProfesor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Profesor profesor = new frm_Profesor();
            profesor.Show();
        }
    }
}