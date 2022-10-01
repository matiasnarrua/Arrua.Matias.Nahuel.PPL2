namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    partial class frm_AsignarProfesor
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
            this.cmb_Materias = new System.Windows.Forms.ComboBox();
            this.cmb_Profesores = new System.Windows.Forms.ComboBox();
            this.btn_Asignar = new System.Windows.Forms.Button();
            this.lbl_Materias = new System.Windows.Forms.Label();
            this.lbl_Profesores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Titulo.Location = new System.Drawing.Point(146, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(248, 37);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Asignar Profesor";
            // 
            // cmb_Materias
            // 
            this.cmb_Materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Materias.FormattingEnabled = true;
            this.cmb_Materias.Location = new System.Drawing.Point(182, 114);
            this.cmb_Materias.Name = "cmb_Materias";
            this.cmb_Materias.Size = new System.Drawing.Size(175, 23);
            this.cmb_Materias.TabIndex = 1;
            // 
            // cmb_Profesores
            // 
            this.cmb_Profesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Profesores.FormattingEnabled = true;
            this.cmb_Profesores.Location = new System.Drawing.Point(182, 201);
            this.cmb_Profesores.Name = "cmb_Profesores";
            this.cmb_Profesores.Size = new System.Drawing.Size(175, 23);
            this.cmb_Profesores.TabIndex = 2;
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Asignar.Location = new System.Drawing.Point(198, 264);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(137, 32);
            this.btn_Asignar.TabIndex = 3;
            this.btn_Asignar.Text = "Asignar";
            this.btn_Asignar.UseVisualStyleBackColor = true;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // lbl_Materias
            // 
            this.lbl_Materias.AutoSize = true;
            this.lbl_Materias.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Materias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Materias.Location = new System.Drawing.Point(182, 92);
            this.lbl_Materias.Name = "lbl_Materias";
            this.lbl_Materias.Size = new System.Drawing.Size(69, 19);
            this.lbl_Materias.TabIndex = 22;
            this.lbl_Materias.Text = "Materias";
            // 
            // lbl_Profesores
            // 
            this.lbl_Profesores.AutoSize = true;
            this.lbl_Profesores.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Profesores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Profesores.Location = new System.Drawing.Point(182, 179);
            this.lbl_Profesores.Name = "lbl_Profesores";
            this.lbl_Profesores.Size = new System.Drawing.Size(85, 19);
            this.lbl_Profesores.TabIndex = 23;
            this.lbl_Profesores.Text = "Profesores";
            // 
            // frm_AsignarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.lbl_Profesores);
            this.Controls.Add(this.lbl_Materias);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.cmb_Profesores);
            this.Controls.Add(this.cmb_Materias);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AsignarProfesor";
            this.Text = "AsignarProfesor";
            this.Load += new System.EventHandler(this.frm_AsignarProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Titulo;
        private ComboBox cmb_Materias;
        private ComboBox cmb_Profesores;
        private Button btn_Asignar;
        private Label lbl_Materias;
        private Label lbl_Profesores;
    }
}