namespace PrimerExamenParcial_LuisMayorga
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegistrarDoctor = new System.Windows.Forms.Button();
            this.buttonRegistrarPaciente = new System.Windows.Forms.Button();
            this.buttonRegistarCitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistrarDoctor
            // 
            this.buttonRegistrarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarDoctor.Location = new System.Drawing.Point(104, 99);
            this.buttonRegistrarDoctor.Name = "buttonRegistrarDoctor";
            this.buttonRegistrarDoctor.Size = new System.Drawing.Size(175, 78);
            this.buttonRegistrarDoctor.TabIndex = 0;
            this.buttonRegistrarDoctor.Text = "Registrar Doctor";
            this.buttonRegistrarDoctor.UseVisualStyleBackColor = true;
            this.buttonRegistrarDoctor.Click += new System.EventHandler(this.buttonRegistrarDoctor_Click);
            // 
            // buttonRegistrarPaciente
            // 
            this.buttonRegistrarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarPaciente.Location = new System.Drawing.Point(461, 99);
            this.buttonRegistrarPaciente.Name = "buttonRegistrarPaciente";
            this.buttonRegistrarPaciente.Size = new System.Drawing.Size(172, 75);
            this.buttonRegistrarPaciente.TabIndex = 1;
            this.buttonRegistrarPaciente.Text = "Registrar Paciente";
            this.buttonRegistrarPaciente.UseVisualStyleBackColor = true;
            this.buttonRegistrarPaciente.Click += new System.EventHandler(this.buttonRegistrarPaciente_Click);
            // 
            // buttonRegistarCitas
            // 
            this.buttonRegistarCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistarCitas.Location = new System.Drawing.Point(295, 260);
            this.buttonRegistarCitas.Name = "buttonRegistarCitas";
            this.buttonRegistarCitas.Size = new System.Drawing.Size(208, 89);
            this.buttonRegistarCitas.TabIndex = 2;
            this.buttonRegistarCitas.Text = "Registar Citas Medicas";
            this.buttonRegistarCitas.UseVisualStyleBackColor = true;
            this.buttonRegistarCitas.Click += new System.EventHandler(this.buttonRegistarCitas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegistarCitas);
            this.Controls.Add(this.buttonRegistrarPaciente);
            this.Controls.Add(this.buttonRegistrarDoctor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrarDoctor;
        private System.Windows.Forms.Button buttonRegistrarPaciente;
        private System.Windows.Forms.Button buttonRegistarCitas;
    }
}

