namespace Proyecto
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAdmi = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(399, 135);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(399, 195);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(156, 20);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(399, 161);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(156, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(274, 328);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 30);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(512, 328);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(92, 30);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Usuario";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(268, 39);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(248, 31);
            this.lblRegistro.TabIndex = 10;
            this.lblRegistro.Text = "Registro de perfiles";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(399, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rbAdmi);
            this.groupBox1.Controls.Add(this.rbRegular);
            this.groupBox1.Location = new System.Drawing.Point(399, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 79);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de usuario";
            // 
            // rbAdmi
            // 
            this.rbAdmi.AutoSize = true;
            this.rbAdmi.Location = new System.Drawing.Point(7, 43);
            this.rbAdmi.Name = "rbAdmi";
            this.rbAdmi.Size = new System.Drawing.Size(90, 17);
            this.rbAdmi.TabIndex = 1;
            this.rbAdmi.TabStop = true;
            this.rbAdmi.Text = "Administrativo";
            this.rbAdmi.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(7, 20);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(62, 17);
            this.rbRegular.TabIndex = 0;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAdmi;
        private System.Windows.Forms.RadioButton rbRegular;
    }
}