namespace Arrua.Matias.Nahuel.Tp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Close);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Image = global::Arrua.Matias.Nahuel.Tp1.Properties.Resources.Minimize_Icon;
            resources.ApplyResources(this.btn_Minimize, "btn_Minimize");
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::Arrua.Matias.Nahuel.Tp1.Properties.Resources.Close_Icon;
            resources.ApplyResources(this.btn_Close, "btn_Close");
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox btn_Minimize;
        private PictureBox btn_Close;
        private Button button1;
    }
}