namespace Proyecto
{
    partial class controlDeAccesso
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
            this.rbRegistroUsuario = new System.Windows.Forms.RadioButton();
            this.rbParametros = new System.Windows.Forms.RadioButton();
            this.gbOpcion = new System.Windows.Forms.GroupBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbRegistroUsuario
            // 
            this.rbRegistroUsuario.AutoSize = true;
            this.rbRegistroUsuario.Location = new System.Drawing.Point(25, 19);
            this.rbRegistroUsuario.Name = "rbRegistroUsuario";
            this.rbRegistroUsuario.Size = new System.Drawing.Size(159, 21);
            this.rbRegistroUsuario.TabIndex = 0;
            this.rbRegistroUsuario.TabStop = true;
            this.rbRegistroUsuario.Text = "Registro de Usuarios";
            this.rbRegistroUsuario.UseVisualStyleBackColor = true;
            // 
            // rbParametros
            // 
            this.rbParametros.AutoSize = true;
            this.rbParametros.Location = new System.Drawing.Point(221, 19);
            this.rbParametros.Name = "rbParametros";
            this.rbParametros.Size = new System.Drawing.Size(228, 21);
            this.rbParametros.TabIndex = 1;
            this.rbParametros.TabStop = true;
            this.rbParametros.Text = "Ingreso de parametros del agua";
            this.rbParametros.UseVisualStyleBackColor = true;
            // 
            // gbOpcion
            // 
            this.gbOpcion.Controls.Add(this.rbRegistroUsuario);
            this.gbOpcion.Controls.Add(this.rbParametros);
            this.gbOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcion.Location = new System.Drawing.Point(103, 92);
            this.gbOpcion.Name = "gbOpcion";
            this.gbOpcion.Size = new System.Drawing.Size(499, 57);
            this.gbOpcion.TabIndex = 2;
            this.gbOpcion.TabStop = false;
            this.gbOpcion.Text = "Seleccione una opcion";
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(161, 220);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(87, 33);
            this.btnIngreso.TabIndex = 3;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(404, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 33);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu de acceso";
            // 
            // controlDeAccesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.gbOpcion);
            this.MaximizeBox = false;
            this.Name = "controlDeAccesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "controlDeAccesso";
            this.gbOpcion.ResumeLayout(false);
            this.gbOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRegistroUsuario;
        private System.Windows.Forms.RadioButton rbParametros;
        private System.Windows.Forms.GroupBox gbOpcion;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}