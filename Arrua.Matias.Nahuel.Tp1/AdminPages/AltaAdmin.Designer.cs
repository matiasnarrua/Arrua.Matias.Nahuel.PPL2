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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_NombreAdminAlta = new System.Windows.Forms.TextBox();
            this.txt_PassAdminAlta = new System.Windows.Forms.TextBox();
            this.txt_UserAdminAlta = new System.Windows.Forms.TextBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_AceptarAltaAdmin = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Titulo.Location = new System.Drawing.Point(174, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(172, 37);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Alta Admin";
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
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AllowUserToDeleteRows = false;
            this.dgv_Usuarios.AutoGenerateColumns = false;
            this.dgv_Usuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgv_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.dgv_Usuarios.DataSource = this.adminBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Usuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Usuarios.GridColor = System.Drawing.Color.White;
            this.dgv_Usuarios.Location = new System.Drawing.Point(12, 69);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.dgv_Usuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Nombre.Location = new System.Drawing.Point(375, 78);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 19);
            this.lbl_Nombre.TabIndex = 6;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Pass.Location = new System.Drawing.Point(375, 141);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(88, 19);
            this.lbl_Pass.TabIndex = 7;
            this.lbl_Pass.Text = "Contraseña";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_User.Location = new System.Drawing.Point(375, 200);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(63, 19);
            this.lbl_User.TabIndex = 8;
            this.lbl_User.Text = "Usuario";
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataSource = typeof(TiposDeUsuarios.Admin);
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
            this.userDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_AltaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_AceptarAltaAdmin);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.txt_UserAdminAlta);
            this.Controls.Add(this.txt_PassAdminAlta);
            this.Controls.Add(this.txt_NombreAdminAlta);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AltaAdmin";
            this.Text = "AltaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Titulo;
        private TextBox txt_NombreAdminAlta;
        private TextBox txt_PassAdminAlta;
        private TextBox txt_UserAdminAlta;
        private DataGridView dgv_Usuarios;
        private Button btn_AceptarAltaAdmin;
        private Label lbl_Nombre;
        private Label lbl_Pass;
        private Label lbl_User;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private BindingSource adminBindingSource;
    }
}