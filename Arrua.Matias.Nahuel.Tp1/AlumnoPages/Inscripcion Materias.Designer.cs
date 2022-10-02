namespace Arrua.Matias.Nahuel.Tp1.AlumnoPages
{
    partial class frm_InscripcionMaterias
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
            this.btn_Inscribirse = new System.Windows.Forms.Button();
            this.cmb_Materias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inscripcion a materias";
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = typeof(TiposDeUsuarios.Materia);
            // 
            // btn_Inscribirse
            // 
            this.btn_Inscribirse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Inscribirse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btn_Inscribirse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Inscribirse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Inscribirse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Inscribirse.Location = new System.Drawing.Point(194, 257);
            this.btn_Inscribirse.Name = "btn_Inscribirse";
            this.btn_Inscribirse.Size = new System.Drawing.Size(124, 37);
            this.btn_Inscribirse.TabIndex = 3;
            this.btn_Inscribirse.Text = "Inscribirse";
            this.btn_Inscribirse.UseVisualStyleBackColor = false;
            this.btn_Inscribirse.Click += new System.EventHandler(this.btn_Inscribirse_Click);
            // 
            // cmb_Materias
            // 
            this.cmb_Materias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Materias.FormattingEnabled = true;
            this.cmb_Materias.Location = new System.Drawing.Point(166, 129);
            this.cmb_Materias.Name = "cmb_Materias";
            this.cmb_Materias.Size = new System.Drawing.Size(182, 22);
            this.cmb_Materias.TabIndex = 4;
            // 
            // frm_InscripcionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.cmb_Materias);
            this.Controls.Add(this.btn_Inscribirse);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_InscripcionMaterias";
            this.Text = "Inscripcion_Materias";
            this.Load += new System.EventHandler(this.frm_InscripcionMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private BindingSource materiaBindingSource;
        private Button btn_Inscribirse;
        private ComboBox cmb_Materias;
    }
}