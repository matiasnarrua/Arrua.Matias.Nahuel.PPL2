namespace Arrua.Matias.Nahuel.Tp1.AlumnoPages
{
    partial class frm_DarPresente
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
            this.btn_DarPresente = new System.Windows.Forms.Button();
            this.cmb_MateriasPresente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dar Presente";
            // 
            // btn_DarPresente
            // 
            this.btn_DarPresente.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DarPresente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DarPresente.Location = new System.Drawing.Point(164, 246);
            this.btn_DarPresente.Name = "btn_DarPresente";
            this.btn_DarPresente.Size = new System.Drawing.Size(204, 56);
            this.btn_DarPresente.TabIndex = 2;
            this.btn_DarPresente.Text = "Dar Presente";
            this.btn_DarPresente.UseVisualStyleBackColor = true;
            this.btn_DarPresente.Click += new System.EventHandler(this.btn_DarPresente_Click);
            // 
            // cmb_MateriasPresente
            // 
            this.cmb_MateriasPresente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MateriasPresente.FormattingEnabled = true;
            this.cmb_MateriasPresente.Location = new System.Drawing.Point(164, 121);
            this.cmb_MateriasPresente.Name = "cmb_MateriasPresente";
            this.cmb_MateriasPresente.Size = new System.Drawing.Size(204, 22);
            this.cmb_MateriasPresente.TabIndex = 3;
            // 
            // frm_DarPresente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.cmb_MateriasPresente);
            this.Controls.Add(this.btn_DarPresente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DarPresente";
            this.Text = "DarPresente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_DarPresente;
        private ComboBox cmb_MateriasPresente;
    }
}