namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    partial class frm_AltaProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_AceptarAltaProfesor = new System.Windows.Forms.Button();
            this.txt_UserProfesorAlta = new System.Windows.Forms.TextBox();
            this.txt_PassProfesorAlta = new System.Windows.Forms.TextBox();
            this.txt_NombreProfesorAlta = new System.Windows.Forms.TextBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Titulo.Location = new System.Drawing.Point(172, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(198, 37);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Alta Profesor";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_user.Location = new System.Drawing.Point(375, 200);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(63, 19);
            this.lbl_user.TabIndex = 23;
            this.lbl_user.Text = "Usuario";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Pass.Location = new System.Drawing.Point(375, 141);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(88, 19);
            this.lbl_Pass.TabIndex = 22;
            this.lbl_Pass.Text = "Contraseña";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Nombre.Location = new System.Drawing.Point(375, 78);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 19);
            this.lbl_Nombre.TabIndex = 21;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // btn_AceptarAltaProfesor
            // 
            this.btn_AceptarAltaProfesor.Location = new System.Drawing.Point(400, 266);
            this.btn_AceptarAltaProfesor.Name = "btn_AceptarAltaProfesor";
            this.btn_AceptarAltaProfesor.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarAltaProfesor.TabIndex = 20;
            this.btn_AceptarAltaProfesor.Text = "Agregar";
            this.btn_AceptarAltaProfesor.UseVisualStyleBackColor = true;
            this.btn_AceptarAltaProfesor.Click += new System.EventHandler(this.btn_AceptarAltaProfesor_Click);
            // 
            // txt_UserProfesorAlta
            // 
            this.txt_UserProfesorAlta.Location = new System.Drawing.Point(375, 222);
            this.txt_UserProfesorAlta.Name = "txt_UserProfesorAlta";
            this.txt_UserProfesorAlta.Size = new System.Drawing.Size(124, 23);
            this.txt_UserProfesorAlta.TabIndex = 19;
            // 
            // txt_PassProfesorAlta
            // 
            this.txt_PassProfesorAlta.Location = new System.Drawing.Point(375, 163);
            this.txt_PassProfesorAlta.Name = "txt_PassProfesorAlta";
            this.txt_PassProfesorAlta.Size = new System.Drawing.Size(124, 23);
            this.txt_PassProfesorAlta.TabIndex = 18;
            // 
            // txt_NombreProfesorAlta
            // 
            this.txt_NombreProfesorAlta.Location = new System.Drawing.Point(375, 100);
            this.txt_NombreProfesorAlta.Name = "txt_NombreProfesorAlta";
            this.txt_NombreProfesorAlta.Size = new System.Drawing.Size(124, 23);
            this.txt_NombreProfesorAlta.TabIndex = 17;
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(12, 69);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.RowTemplate.Height = 25;
            this.dgv_Usuarios.Size = new System.Drawing.Size(334, 300);
            this.dgv_Usuarios.TabIndex = 16;
            // 
            // frm_AltaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_AceptarAltaProfesor);
            this.Controls.Add(this.txt_UserProfesorAlta);
            this.Controls.Add(this.txt_PassProfesorAlta);
            this.Controls.Add(this.txt_NombreProfesorAlta);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AltaProfesor";
            this.Text = "AltaProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Titulo;
        private Label lbl_user;
        private Label lbl_Pass;
        private Label lbl_Nombre;
        private Button btn_AceptarAltaProfesor;
        private TextBox txt_UserProfesorAlta;
        private TextBox txt_PassProfesorAlta;
        private TextBox txt_NombreProfesorAlta;
        private DataGridView dgv_Usuarios;
    }
}