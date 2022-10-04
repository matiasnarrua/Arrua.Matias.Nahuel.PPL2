namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    partial class frm_AsignarMateria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_TituloAsignarMateria = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_AceptarAltaAlumno = new System.Windows.Forms.Button();
            this.txt_UserAlumno = new System.Windows.Forms.TextBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaCursadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenNotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDelAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Materias = new System.Windows.Forms.ComboBox();
            this.lbl_Materias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TituloAsignarMateria
            // 
            this.lbl_TituloAsignarMateria.AutoSize = true;
            this.lbl_TituloAsignarMateria.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloAsignarMateria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TituloAsignarMateria.Location = new System.Drawing.Point(138, 9);
            this.lbl_TituloAsignarMateria.Name = "lbl_TituloAsignarMateria";
            this.lbl_TituloAsignarMateria.Size = new System.Drawing.Size(237, 37);
            this.lbl_TituloAsignarMateria.TabIndex = 1;
            this.lbl_TituloAsignarMateria.Text = "Asignar Materia";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_user.Location = new System.Drawing.Point(385, 65);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(63, 19);
            this.lbl_user.TabIndex = 19;
            this.lbl_user.Text = "Usuario";
            // 
            // btn_AceptarAltaAlumno
            // 
            this.btn_AceptarAltaAlumno.ForeColor = System.Drawing.Color.Black;
            this.btn_AceptarAltaAlumno.Location = new System.Drawing.Point(407, 197);
            this.btn_AceptarAltaAlumno.Name = "btn_AceptarAltaAlumno";
            this.btn_AceptarAltaAlumno.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarAltaAlumno.TabIndex = 18;
            this.btn_AceptarAltaAlumno.Text = "Asignar";
            this.btn_AceptarAltaAlumno.UseVisualStyleBackColor = true;
            this.btn_AceptarAltaAlumno.Click += new System.EventHandler(this.btn_AceptarAltaAlumno_Click);
            // 
            // txt_UserAlumno
            // 
            this.txt_UserAlumno.Location = new System.Drawing.Point(385, 87);
            this.txt_UserAlumno.Name = "txt_UserAlumno";
            this.txt_UserAlumno.Size = new System.Drawing.Size(124, 23);
            this.txt_UserAlumno.TabIndex = 17;
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AllowUserToDeleteRows = false;
            this.dgv_Usuarios.AutoGenerateColumns = false;
            this.dgv_Usuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userDataGridViewTextBoxColumn,
            this.materiaCursadaDataGridViewTextBoxColumn,
            this.examenNombreDataGridViewTextBoxColumn,
            this.examenNotaDataGridViewTextBoxColumn,
            this.estadoMateriaDataGridViewTextBoxColumn,
            this.EstadoDelAlumno});
            this.dgv_Usuarios.DataSource = this.alumnoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Usuarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Usuarios.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Usuarios.Location = new System.Drawing.Point(23, 56);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.dgv_Usuarios.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Usuarios.RowTemplate.Height = 25;
            this.dgv_Usuarios.Size = new System.Drawing.Size(334, 300);
            this.dgv_Usuarios.TabIndex = 16;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(TiposDeUsuarios.Alumno);
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaCursadaDataGridViewTextBoxColumn
            // 
            this.materiaCursadaDataGridViewTextBoxColumn.DataPropertyName = "MateriaCursada";
            this.materiaCursadaDataGridViewTextBoxColumn.HeaderText = "Materia Cursada";
            this.materiaCursadaDataGridViewTextBoxColumn.Name = "materiaCursadaDataGridViewTextBoxColumn";
            this.materiaCursadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examenNombreDataGridViewTextBoxColumn
            // 
            this.examenNombreDataGridViewTextBoxColumn.DataPropertyName = "ExamenNombre";
            this.examenNombreDataGridViewTextBoxColumn.HeaderText = "Examen";
            this.examenNombreDataGridViewTextBoxColumn.Name = "examenNombreDataGridViewTextBoxColumn";
            this.examenNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examenNotaDataGridViewTextBoxColumn
            // 
            this.examenNotaDataGridViewTextBoxColumn.DataPropertyName = "ExamenNota";
            this.examenNotaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.examenNotaDataGridViewTextBoxColumn.Name = "examenNotaDataGridViewTextBoxColumn";
            this.examenNotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoMateriaDataGridViewTextBoxColumn
            // 
            this.estadoMateriaDataGridViewTextBoxColumn.DataPropertyName = "EstadoMateria";
            this.estadoMateriaDataGridViewTextBoxColumn.HeaderText = "Estado de la Materia";
            this.estadoMateriaDataGridViewTextBoxColumn.Name = "estadoMateriaDataGridViewTextBoxColumn";
            this.estadoMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EstadoDelAlumno
            // 
            this.EstadoDelAlumno.DataPropertyName = "EstadoDelAlumno";
            this.EstadoDelAlumno.HeaderText = "Estado Del Alumno";
            this.EstadoDelAlumno.Name = "EstadoDelAlumno";
            this.EstadoDelAlumno.ReadOnly = true;
            // 
            // cmb_Materias
            // 
            this.cmb_Materias.FormattingEnabled = true;
            this.cmb_Materias.Location = new System.Drawing.Point(385, 151);
            this.cmb_Materias.Name = "cmb_Materias";
            this.cmb_Materias.Size = new System.Drawing.Size(121, 23);
            this.cmb_Materias.TabIndex = 20;
            // 
            // lbl_Materias
            // 
            this.lbl_Materias.AutoSize = true;
            this.lbl_Materias.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Materias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Materias.Location = new System.Drawing.Point(385, 129);
            this.lbl_Materias.Name = "lbl_Materias";
            this.lbl_Materias.Size = new System.Drawing.Size(69, 19);
            this.lbl_Materias.TabIndex = 21;
            this.lbl_Materias.Text = "Materias";
            // 
            // frm_AsignarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.lbl_Materias);
            this.Controls.Add(this.cmb_Materias);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_AceptarAltaAlumno);
            this.Controls.Add(this.txt_UserAlumno);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.lbl_TituloAsignarMateria);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AsignarMateria";
            this.Text = "AsignarMateria";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_TituloAsignarMateria;
        private Label lbl_user;
        private Button btn_AceptarAltaAlumno;
        private TextBox txt_UserAlumno;
        private DataGridView dgv_Usuarios;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materiaCursadaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examenNombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examenNotaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoMateriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn EstadoDelAlumno;
        private BindingSource alumnoBindingSource;
        private ComboBox cmb_Materias;
        private Label lbl_Materias;
    }
}