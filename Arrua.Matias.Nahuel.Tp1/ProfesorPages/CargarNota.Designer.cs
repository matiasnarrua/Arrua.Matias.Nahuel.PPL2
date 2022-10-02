namespace Arrua.Matias.Nahuel.Tp1.ProfesorPages
{
    partial class frm_CargarNota
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_CargarNota1 = new System.Windows.Forms.Button();
            this.btn_CargarNota2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Examen1 = new System.Windows.Forms.Label();
            this.lbl_Examen2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_UserrAlumno = new System.Windows.Forms.Label();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Title.Location = new System.Drawing.Point(170, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(192, 37);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Cargar notas";
            // 
            // btn_CargarNota1
            // 
            this.btn_CargarNota1.Location = new System.Drawing.Point(239, 347);
            this.btn_CargarNota1.Name = "btn_CargarNota1";
            this.btn_CargarNota1.Size = new System.Drawing.Size(100, 23);
            this.btn_CargarNota1.TabIndex = 3;
            this.btn_CargarNota1.Text = "Cargar Nota";
            this.btn_CargarNota1.UseVisualStyleBackColor = true;
            // 
            // btn_CargarNota2
            // 
            this.btn_CargarNota2.Location = new System.Drawing.Point(374, 347);
            this.btn_CargarNota2.Name = "btn_CargarNota2";
            this.btn_CargarNota2.Size = new System.Drawing.Size(100, 23);
            this.btn_CargarNota2.TabIndex = 4;
            this.btn_CargarNota2.Text = "Cargar Nota";
            this.btn_CargarNota2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(374, 318);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            // 
            // lbl_Examen1
            // 
            this.lbl_Examen1.AutoSize = true;
            this.lbl_Examen1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Examen1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Examen1.Location = new System.Drawing.Point(239, 295);
            this.lbl_Examen1.Name = "lbl_Examen1";
            this.lbl_Examen1.Size = new System.Drawing.Size(50, 20);
            this.lbl_Examen1.TabIndex = 7;
            this.lbl_Examen1.Text = "label2";
            // 
            // lbl_Examen2
            // 
            this.lbl_Examen2.AutoSize = true;
            this.lbl_Examen2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Examen2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Examen2.Location = new System.Drawing.Point(374, 295);
            this.lbl_Examen2.Name = "lbl_Examen2";
            this.lbl_Examen2.Size = new System.Drawing.Size(50, 20);
            this.lbl_Examen2.TabIndex = 8;
            this.lbl_Examen2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(508, 213);
            this.dataGridView1.TabIndex = 9;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(TiposDeUsuarios.Alumno);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 318);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 23);
            this.textBox3.TabIndex = 10;
            // 
            // lbl_UserrAlumno
            // 
            this.lbl_UserrAlumno.AutoSize = true;
            this.lbl_UserrAlumno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UserrAlumno.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_UserrAlumno.Location = new System.Drawing.Point(27, 295);
            this.lbl_UserrAlumno.Name = "lbl_UserrAlumno";
            this.lbl_UserrAlumno.Size = new System.Drawing.Size(140, 20);
            this.lbl_UserrAlumno.TabIndex = 11;
            this.lbl_UserrAlumno.Text = "Usuario del Alumno";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "Nota1";
            this.nota1DataGridViewTextBoxColumn.HeaderText = "Nota1";
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            this.nota1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "Nota2";
            this.nota2DataGridViewTextBoxColumn.HeaderText = "Nota2";
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            this.nota2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_CargarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.lbl_UserrAlumno);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Examen2);
            this.Controls.Add(this.lbl_Examen1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_CargarNota2);
            this.Controls.Add(this.btn_CargarNota1);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CargarNota";
            this.Text = "CargarNota";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Title;
        private Button btn_CargarNota1;
        private Button btn_CargarNota2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbl_Examen1;
        private Label lbl_Examen2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private BindingSource alumnoBindingSource;
        private TextBox textBox3;
        private Label lbl_UserrAlumno;
    }
}