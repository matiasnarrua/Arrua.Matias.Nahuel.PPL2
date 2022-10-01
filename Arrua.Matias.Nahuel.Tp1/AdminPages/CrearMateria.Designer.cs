namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    partial class frm_CrearMateria
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Materias = new System.Windows.Forms.DataGridView();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_AltaMateria = new System.Windows.Forms.Button();
            this.txt_Correlativa = new System.Windows.Forms.TextBox();
            this.txt_Cuatrimestre = new System.Windows.Forms.TextBox();
            this.txt_NombreMateria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Materia";
            // 
            // dgv_Materias
            // 
            this.dgv_Materias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Materias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_Materias.Location = new System.Drawing.Point(21, 64);
            this.dgv_Materias.Name = "dgv_Materias";
            this.dgv_Materias.RowTemplate.Height = 25;
            this.dgv_Materias.Size = new System.Drawing.Size(334, 300);
            this.dgv_Materias.TabIndex = 5;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_User.Location = new System.Drawing.Point(381, 208);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(86, 19);
            this.lbl_User.TabIndex = 15;
            this.lbl_User.Text = "Correlativa";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Pass.Location = new System.Drawing.Point(381, 149);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(99, 19);
            this.lbl_Pass.TabIndex = 14;
            this.lbl_Pass.Text = "Cuatrimestre";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Nombre.Location = new System.Drawing.Point(361, 86);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(160, 19);
            this.lbl_Nombre.TabIndex = 13;
            this.lbl_Nombre.Text = "Nombre de la materia";
            // 
            // btn_AltaMateria
            // 
            this.btn_AltaMateria.Location = new System.Drawing.Point(406, 274);
            this.btn_AltaMateria.Name = "btn_AltaMateria";
            this.btn_AltaMateria.Size = new System.Drawing.Size(75, 23);
            this.btn_AltaMateria.TabIndex = 12;
            this.btn_AltaMateria.Text = "Agregar";
            this.btn_AltaMateria.UseVisualStyleBackColor = true;
            this.btn_AltaMateria.Click += new System.EventHandler(this.btn_AltaMateria_Click);
            // 
            // txt_Correlativa
            // 
            this.txt_Correlativa.Location = new System.Drawing.Point(381, 230);
            this.txt_Correlativa.Name = "txt_Correlativa";
            this.txt_Correlativa.Size = new System.Drawing.Size(124, 23);
            this.txt_Correlativa.TabIndex = 11;
            // 
            // txt_Cuatrimestre
            // 
            this.txt_Cuatrimestre.Location = new System.Drawing.Point(381, 171);
            this.txt_Cuatrimestre.Name = "txt_Cuatrimestre";
            this.txt_Cuatrimestre.Size = new System.Drawing.Size(124, 23);
            this.txt_Cuatrimestre.TabIndex = 10;
            // 
            // txt_NombreMateria
            // 
            this.txt_NombreMateria.Location = new System.Drawing.Point(381, 108);
            this.txt_NombreMateria.Name = "txt_NombreMateria";
            this.txt_NombreMateria.Size = new System.Drawing.Size(124, 23);
            this.txt_NombreMateria.TabIndex = 9;
            // 
            // frm_CrearMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_AltaMateria);
            this.Controls.Add(this.txt_Correlativa);
            this.Controls.Add(this.txt_Cuatrimestre);
            this.Controls.Add(this.txt_NombreMateria);
            this.Controls.Add(this.dgv_Materias);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CrearMateria";
            this.Text = "CrearMateria";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgv_Materias;
        private Label lbl_User;
        private Label lbl_Pass;
        private Label lbl_Nombre;
        private Button btn_AltaMateria;
        private TextBox txt_Correlativa;
        private TextBox txt_Cuatrimestre;
        private TextBox txt_NombreMateria;
    }
}