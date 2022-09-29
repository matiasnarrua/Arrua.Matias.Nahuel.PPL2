namespace Arrua.Matias.Nahuel.Tp1.AlumnoPages
{
    partial class frm_IncripcionMaterias
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
            this.label1 = new System.Windows.Forms.Label();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AgregarMateria = new System.Windows.Forms.Button();
            this.txt_AgregarMateria = new System.Windows.Forms.TextBox();
            this.dgv_Materias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inscripcion a materias";
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = typeof(TiposDeUsuarios.Materia);
            // 
            // btn_AgregarMateria
            // 
            this.btn_AgregarMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AgregarMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_AgregarMateria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AgregarMateria.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarMateria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AgregarMateria.Location = new System.Drawing.Point(357, 203);
            this.btn_AgregarMateria.Name = "btn_AgregarMateria";
            this.btn_AgregarMateria.Size = new System.Drawing.Size(95, 27);
            this.btn_AgregarMateria.TabIndex = 3;
            this.btn_AgregarMateria.Text = "Agregar";
            this.btn_AgregarMateria.UseVisualStyleBackColor = false;
            // 
            // txt_AgregarMateria
            // 
            this.txt_AgregarMateria.Location = new System.Drawing.Point(319, 159);
            this.txt_AgregarMateria.Name = "txt_AgregarMateria";
            this.txt_AgregarMateria.PlaceholderText = "Ingrese Materia";
            this.txt_AgregarMateria.Size = new System.Drawing.Size(166, 22);
            this.txt_AgregarMateria.TabIndex = 4;
            // 
            // dgv_Materias
            // 
            this.dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Materias.Location = new System.Drawing.Point(32, 114);
            this.dgv_Materias.Name = "dgv_Materias";
            this.dgv_Materias.RowTemplate.Height = 25;
            this.dgv_Materias.Size = new System.Drawing.Size(240, 150);
            this.dgv_Materias.TabIndex = 5;
            // 
            // frm_IncripcionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.dgv_Materias);
            this.Controls.Add(this.txt_AgregarMateria);
            this.Controls.Add(this.btn_AgregarMateria);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_IncripcionMaterias";
            this.Text = "Incripcion_Materias";
            this.Load += new System.EventHandler(this.frm_IncripcionMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private BindingSource materiaBindingSource;
        private Button btn_AgregarMateria;
        private TextBox txt_AgregarMateria;
        private DataGridView dgv_Materias;
    }
}