namespace PrimerExamenParcial_LuisMayorga
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.comboBoxDPI = new System.Windows.Forms.ComboBox();
            this.buttonGuardarCita = new System.Windows.Forms.Button();
            this.buttonEliminarCita = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.buttonOrdenarPorNombreDoctor = new System.Windows.Forms.Button();
            this.buttonMostrarCantidadCitasRegistradas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DPI de Paciente";
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(240, 36);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(286, 24);
            this.comboBoxID.TabIndex = 2;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // comboBoxDPI
            // 
            this.comboBoxDPI.FormattingEnabled = true;
            this.comboBoxDPI.Location = new System.Drawing.Point(240, 96);
            this.comboBoxDPI.Name = "comboBoxDPI";
            this.comboBoxDPI.Size = new System.Drawing.Size(286, 24);
            this.comboBoxDPI.TabIndex = 3;
            this.comboBoxDPI.SelectedIndexChanged += new System.EventHandler(this.comboBoxDPI_SelectedIndexChanged);
            // 
            // buttonGuardarCita
            // 
            this.buttonGuardarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCita.Location = new System.Drawing.Point(584, 25);
            this.buttonGuardarCita.Name = "buttonGuardarCita";
            this.buttonGuardarCita.Size = new System.Drawing.Size(170, 38);
            this.buttonGuardarCita.TabIndex = 4;
            this.buttonGuardarCita.Text = "GUARDAR";
            this.buttonGuardarCita.UseVisualStyleBackColor = true;
            this.buttonGuardarCita.Click += new System.EventHandler(this.buttonGuardarCita_Click);
            // 
            // buttonEliminarCita
            // 
            this.buttonEliminarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCita.Location = new System.Drawing.Point(584, 80);
            this.buttonEliminarCita.Name = "buttonEliminarCita";
            this.buttonEliminarCita.Size = new System.Drawing.Size(170, 41);
            this.buttonEliminarCita.TabIndex = 5;
            this.buttonEliminarCita.Text = "ELIMINAR";
            this.buttonEliminarCita.UseVisualStyleBackColor = true;
            this.buttonEliminarCita.Click += new System.EventHandler(this.buttonEliminarCita_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 180);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Location = new System.Drawing.Point(115, 355);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerHora.TabIndex = 7;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(501, 355);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFecha.TabIndex = 8;
            // 
            // buttonOrdenarPorNombreDoctor
            // 
            this.buttonOrdenarPorNombreDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrdenarPorNombreDoctor.Location = new System.Drawing.Point(35, 397);
            this.buttonOrdenarPorNombreDoctor.Name = "buttonOrdenarPorNombreDoctor";
            this.buttonOrdenarPorNombreDoctor.Size = new System.Drawing.Size(262, 81);
            this.buttonOrdenarPorNombreDoctor.TabIndex = 9;
            this.buttonOrdenarPorNombreDoctor.Text = "Ordenar Alfabeticamente por Nombre de Doctor ";
            this.buttonOrdenarPorNombreDoctor.UseVisualStyleBackColor = true;
            this.buttonOrdenarPorNombreDoctor.Click += new System.EventHandler(this.buttonOrdenarPorNombreDoctor_Click);
            // 
            // buttonMostrarCantidadCitasRegistradas
            // 
            this.buttonMostrarCantidadCitasRegistradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarCantidadCitasRegistradas.Location = new System.Drawing.Point(474, 404);
            this.buttonMostrarCantidadCitasRegistradas.Name = "buttonMostrarCantidadCitasRegistradas";
            this.buttonMostrarCantidadCitasRegistradas.Size = new System.Drawing.Size(280, 74);
            this.buttonMostrarCantidadCitasRegistradas.TabIndex = 10;
            this.buttonMostrarCantidadCitasRegistradas.Text = "Mostrar Cantidad de Citas Registradas";
            this.buttonMostrarCantidadCitasRegistradas.UseVisualStyleBackColor = true;
            this.buttonMostrarCantidadCitasRegistradas.Click += new System.EventHandler(this.buttonMostrarCantidadCitasRegistradas_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 501);
            this.Controls.Add(this.buttonMostrarCantidadCitasRegistradas);
            this.Controls.Add(this.buttonOrdenarPorNombreDoctor);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEliminarCita);
            this.Controls.Add(this.buttonGuardarCita);
            this.Controls.Add(this.comboBoxDPI);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ComboBox comboBoxDPI;
        private System.Windows.Forms.Button buttonGuardarCita;
        private System.Windows.Forms.Button buttonEliminarCita;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button buttonOrdenarPorNombreDoctor;
        private System.Windows.Forms.Button buttonMostrarCantidadCitasRegistradas;
    }
}