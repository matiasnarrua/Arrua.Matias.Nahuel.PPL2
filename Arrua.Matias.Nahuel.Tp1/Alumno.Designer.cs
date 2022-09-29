namespace Arrua.Matias.Nahuel.Tp1
{
    partial class frm_Alumno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CerrarUserAlumno = new System.Windows.Forms.Button();
            this.btn_MinimizeAlumno = new System.Windows.Forms.PictureBox();
            this.btn_CloseAlumno = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_DarPresente = new System.Windows.Forms.Button();
            this.btn_Inscripcion = new System.Windows.Forms.Button();
            this.lbl_IdAlumno = new System.Windows.Forms.Label();
            this.lbl_ApellidoAlumno = new System.Windows.Forms.Label();
            this.lbl_NombreAlumno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btn_CerrarUserAlumno);
            this.panel1.Controls.Add(this.btn_MinimizeAlumno);
            this.panel1.Controls.Add(this.btn_CloseAlumno);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_CerrarUserAlumno
            // 
            this.btn_CerrarUserAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_CerrarUserAlumno.FlatAppearance.BorderSize = 0;
            this.btn_CerrarUserAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarUserAlumno.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CerrarUserAlumno.Location = new System.Drawing.Point(8, 5);
            this.btn_CerrarUserAlumno.Name = "btn_CerrarUserAlumno";
            this.btn_CerrarUserAlumno.Size = new System.Drawing.Size(142, 23);
            this.btn_CerrarUserAlumno.TabIndex = 8;
            this.btn_CerrarUserAlumno.Text = "Cerrar Sesion";
            this.btn_CerrarUserAlumno.UseVisualStyleBackColor = true;
            this.btn_CerrarUserAlumno.Click += new System.EventHandler(this.btn_CerrarUserAlumno_Click);
            // 
            // btn_MinimizeAlumno
            // 
            this.btn_MinimizeAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinimizeAlumno.Image = global::Arrua.Matias.Nahuel.Tp1.Properties.Resources.Minimize_Icon;
            this.btn_MinimizeAlumno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_MinimizeAlumno.Location = new System.Drawing.Point(648, 12);
            this.btn_MinimizeAlumno.Name = "btn_MinimizeAlumno";
            this.btn_MinimizeAlumno.Size = new System.Drawing.Size(16, 16);
            this.btn_MinimizeAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_MinimizeAlumno.TabIndex = 7;
            this.btn_MinimizeAlumno.TabStop = false;
            this.btn_MinimizeAlumno.Click += new System.EventHandler(this.btn_MinimizeAlumno_Click);
            // 
            // btn_CloseAlumno
            // 
            this.btn_CloseAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseAlumno.Image = global::Arrua.Matias.Nahuel.Tp1.Properties.Resources.Close_Icon;
            this.btn_CloseAlumno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CloseAlumno.Location = new System.Drawing.Point(682, 12);
            this.btn_CloseAlumno.Name = "btn_CloseAlumno";
            this.btn_CloseAlumno.Size = new System.Drawing.Size(16, 16);
            this.btn_CloseAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_CloseAlumno.TabIndex = 6;
            this.btn_CloseAlumno.TabStop = false;
            this.btn_CloseAlumno.Click += new System.EventHandler(this.btn_CloseAlumno_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Image = global::Arrua.Matias.Nahuel.Tp1.Properties.Resources.Minimize_Icon;
            this.btn_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimize.Location = new System.Drawing.Point(1158, 12);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Minimize.TabIndex = 5;
            this.btn_Minimize.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Image = global::Arrua.Matias.Nahuel.Tp1.Properties.Resources.Close_Icon;
            this.btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Close.Location = new System.Drawing.Point(1192, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Contenedor.Location = new System.Drawing.Point(178, 40);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(532, 412);
            this.pnl_Contenedor.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.btn_DarPresente);
            this.panel3.Controls.Add(this.btn_Inscripcion);
            this.panel3.Controls.Add(this.lbl_IdAlumno);
            this.panel3.Controls.Add(this.lbl_ApellidoAlumno);
            this.panel3.Controls.Add(this.lbl_NombreAlumno);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 412);
            this.panel3.TabIndex = 3;
            // 
            // btn_DarPresente
            // 
            this.btn_DarPresente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_DarPresente.FlatAppearance.BorderSize = 0;
            this.btn_DarPresente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_DarPresente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarPresente.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DarPresente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DarPresente.Location = new System.Drawing.Point(8, 209);
            this.btn_DarPresente.Name = "btn_DarPresente";
            this.btn_DarPresente.Size = new System.Drawing.Size(163, 28);
            this.btn_DarPresente.TabIndex = 17;
            this.btn_DarPresente.Text = "Dar Presente";
            this.btn_DarPresente.UseVisualStyleBackColor = false;
            this.btn_DarPresente.Click += new System.EventHandler(this.btn_DarPresente_Click);
            // 
            // btn_Inscripcion
            // 
            this.btn_Inscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_Inscripcion.FlatAppearance.BorderSize = 0;
            this.btn_Inscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_Inscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inscripcion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Inscripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Inscripcion.Location = new System.Drawing.Point(8, 148);
            this.btn_Inscripcion.Name = "btn_Inscripcion";
            this.btn_Inscripcion.Size = new System.Drawing.Size(163, 30);
            this.btn_Inscripcion.TabIndex = 16;
            this.btn_Inscripcion.Text = "Inscribirse materia/s";
            this.btn_Inscripcion.UseVisualStyleBackColor = false;
            this.btn_Inscripcion.Click += new System.EventHandler(this.btn_Inscripcion_Click);
            // 
            // lbl_IdAlumno
            // 
            this.lbl_IdAlumno.AutoSize = true;
            this.lbl_IdAlumno.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_IdAlumno.Location = new System.Drawing.Point(28, 68);
            this.lbl_IdAlumno.Name = "lbl_IdAlumno";
            this.lbl_IdAlumno.Size = new System.Drawing.Size(21, 17);
            this.lbl_IdAlumno.TabIndex = 15;
            this.lbl_IdAlumno.Text = "Id";
            // 
            // lbl_ApellidoAlumno
            // 
            this.lbl_ApellidoAlumno.AutoSize = true;
            this.lbl_ApellidoAlumno.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ApellidoAlumno.Location = new System.Drawing.Point(28, 51);
            this.lbl_ApellidoAlumno.Name = "lbl_ApellidoAlumno";
            this.lbl_ApellidoAlumno.Size = new System.Drawing.Size(60, 17);
            this.lbl_ApellidoAlumno.TabIndex = 14;
            this.lbl_ApellidoAlumno.Text = "Apellido";
            // 
            // lbl_NombreAlumno
            // 
            this.lbl_NombreAlumno.AutoSize = true;
            this.lbl_NombreAlumno.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreAlumno.Location = new System.Drawing.Point(28, 34);
            this.lbl_NombreAlumno.Name = "lbl_NombreAlumno";
            this.lbl_NombreAlumno.Size = new System.Drawing.Size(59, 17);
            this.lbl_NombreAlumno.TabIndex = 13;
            this.lbl_NombreAlumno.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Alumno";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 2);
            this.panel5.TabIndex = 11;
            // 
            // frm_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(710, 452);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox btn_Minimize;
        private PictureBox btn_Close;
        private PictureBox btn_MinimizeAlumno;
        private PictureBox btn_CloseAlumno;
        private Panel pnl_Contenedor;
        private Panel panel3;
        private Panel panel5;
        private Label lbl_IdAlumno;
        private Label lbl_ApellidoAlumno;
        private Label lbl_NombreAlumno;
        private Label label1;
        private Button btn_DarPresente;
        private Button btn_Inscripcion;
        private Button btn_CerrarUserAlumno;
    }
}