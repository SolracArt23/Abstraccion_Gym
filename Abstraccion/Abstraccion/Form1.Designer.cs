namespace Abstraccion
{
    partial class Form1
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
            this.Validacion = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Validacion
            // 
            this.Validacion.Location = new System.Drawing.Point(190, 301);
            this.Validacion.Name = "Validacion";
            this.Validacion.Size = new System.Drawing.Size(281, 78);
            this.Validacion.TabIndex = 0;
            this.Validacion.Text = "Validar";
            this.Validacion.UseVisualStyleBackColor = true;
            this.Validacion.UseWaitCursor = true;
            this.Validacion.Click += new System.EventHandler(this.Validacion_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(294, 202);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderText = "Coloca tu contrasena";
            this.password.Size = new System.Drawing.Size(241, 31);
            this.password.TabIndex = 1;
            this.password.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "CURSO ESTRUCTURA DE DATOS";
            this.label2.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(163, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Carlos Arturo Corredor Muñoz";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);

            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label49.Location = new System.Drawing.Point(228, 147);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(200, 32);
            this.label49.TabIndex = 5;
            this.label49.Text = "Acceso al sistema";
            this.label49.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(683, 426);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Validacion);
            this.Name = "Form1";
            this.Text = "Login";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Validacion;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label49;
    }
}