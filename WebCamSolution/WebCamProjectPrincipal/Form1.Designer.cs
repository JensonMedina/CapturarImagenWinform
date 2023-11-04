
namespace WebCamProjectPrincipal
{
    partial class Form1
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.pbxGrabar = new System.Windows.Forms.PictureBox();
            this.pbxCapturar = new System.Windows.Forms.PictureBox();
            this.cbxGrabar = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrabar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapturar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(284, 38);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(82, 23);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(616, 81);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(156, 23);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // pbxGrabar
            // 
            this.pbxGrabar.Location = new System.Drawing.Point(12, 114);
            this.pbxGrabar.Name = "pbxGrabar";
            this.pbxGrabar.Size = new System.Drawing.Size(352, 273);
            this.pbxGrabar.TabIndex = 2;
            this.pbxGrabar.TabStop = false;
            // 
            // pbxCapturar
            // 
            this.pbxCapturar.Location = new System.Drawing.Point(420, 114);
            this.pbxCapturar.Name = "pbxCapturar";
            this.pbxCapturar.Size = new System.Drawing.Size(352, 273);
            this.pbxCapturar.TabIndex = 3;
            this.pbxCapturar.TabStop = false;
            // 
            // cbxGrabar
            // 
            this.cbxGrabar.FormattingEnabled = true;
            this.cbxGrabar.Location = new System.Drawing.Point(29, 38);
            this.cbxGrabar.Name = "cbxGrabar";
            this.cbxGrabar.Size = new System.Drawing.Size(249, 21);
            this.cbxGrabar.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(575, 406);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxGrabar);
            this.Controls.Add(this.pbxCapturar);
            this.Controls.Add(this.pbxGrabar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnGrabar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrabar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapturar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.PictureBox pbxGrabar;
        private System.Windows.Forms.PictureBox pbxCapturar;
        private System.Windows.Forms.ComboBox cbxGrabar;
        private System.Windows.Forms.Button btnGuardar;
    }
}

