namespace Arrua.Matias.Nahuel.Tp1.AdminPages
{
    partial class frm_AltaAdmin
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
            this.txt_NombreAdminAlta = new System.Windows.Forms.TextBox();
            this.txt_PassAdminAlta = new System.Windows.Forms.TextBox();
            this.txt_UserAdminAlta = new System.Windows.Forms.TextBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_AceptarAltaAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta Admin";
            // 
            // txt_NombreAdminAlta
            // 
            this.txt_NombreAdminAlta.Location = new System.Drawing.Point(375, 100);
            this.txt_NombreAdminAlta.Name = "txt_NombreAdminAlta";
            this.txt_NombreAdminAlta.Size = new System.Drawing.Size(124, 23);
            this.txt_NombreAdminAlta.TabIndex = 1;
            // 
            // txt_PassAdminAlta
            // 
            this.txt_PassAdminAlta.Location = new System.Drawing.Point(375, 163);
            this.txt_PassAdminAlta.Name = "txt_PassAdminAlta";
            this.txt_PassAdminAlta.Size = new System.Drawing.Size(124, 23);
            this.txt_PassAdminAlta.TabIndex = 2;
            // 
            // txt_UserAdminAlta
            // 
            this.txt_UserAdminAlta.Location = new System.Drawing.Point(375, 222);
            this.txt_UserAdminAlta.Name = "txt_UserAdminAlta";
            this.txt_UserAdminAlta.Size = new System.Drawing.Size(124, 23);
            this.txt_UserAdminAlta.TabIndex = 3;
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(12, 69);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.RowTemplate.Height = 25;
            this.dgv_Usuarios.Size = new System.Drawing.Size(334, 300);
            this.dgv_Usuarios.TabIndex = 4;
            // 
            // btn_AceptarAltaAdmin
            // 
            this.btn_AceptarAltaAdmin.Location = new System.Drawing.Point(400, 266);
            this.btn_AceptarAltaAdmin.Name = "btn_AceptarAltaAdmin";
            this.btn_AceptarAltaAdmin.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarAltaAdmin.TabIndex = 5;
            this.btn_AceptarAltaAdmin.Text = "Agregar";
            this.btn_AceptarAltaAdmin.UseVisualStyleBackColor = true;
            this.btn_AceptarAltaAdmin.Click += new System.EventHandler(this.btn_AceptarAltaAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(375, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(375, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(375, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuario";
            // 
            // frm_AltaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AceptarAltaAdmin);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.txt_UserAdminAlta);
            this.Controls.Add(this.txt_PassAdminAlta);
            this.Controls.Add(this.txt_NombreAdminAlta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AltaAdmin";
            this.Text = "AltaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_NombreAdminAlta;
        private TextBox txt_PassAdminAlta;
        private TextBox txt_UserAdminAlta;
        private DataGridView dgv_Usuarios;
        private Button btn_AceptarAltaAdmin;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}