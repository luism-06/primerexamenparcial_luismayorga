using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerExamenParcial_LuisMayorga
{
    public partial class Form2 : Form
    {

        List<Doctor> doctor = new List<Doctor>();
        String ruta = "doctores.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            if (File.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] datos = linea.Split(',');

                        if (datos.Length == 3)
                        {
                            Doctor est = new Doctor();
                            est.ID = datos[0];
                            est.NombreCompleto = datos[1];
                            est.Especialidad = datos[2];

                            doctor.Add(est);
                        }
                    }
                }
            }

            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = doctor;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text.Trim() == "" ||
                    textBoxNombre.Text.Trim() == "" ||
                    textBoxEspecialidad.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }

                bool existe = doctor.Any(x => x.ID == textBoxID.Text.Trim());

                if (existe)
                {
                    MessageBox.Show("El ID ya existe");
                    return;
                }

                Doctor nuevo = new Doctor();
                nuevo.ID = textBoxID.Text.Trim();
                nuevo.NombreCompleto = textBoxNombre.Text.Trim();
                nuevo.Especialidad = textBoxEspecialidad.Text.Trim();

                doctor.Add(nuevo);

                using (StreamWriter sw = new StreamWriter(ruta, false))
                {
                    foreach (Doctor est in doctor)
                    {
                        sw.WriteLine($"{est.ID},{est.NombreCompleto},{est.Especialidad}");
                    }
                }

                ActualizarGrid();

                MessageBox.Show("Doctor guardado correctamente");

                textBoxID.Clear();
                textBoxNombre.Clear();
                textBoxEspecialidad.Clear();
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int indice = dataGridView1.CurrentRow.Index;

                if (indice >= 0 && indice < doctor.Count)
                {
                    doctor.RemoveAt(indice);

                    using (StreamWriter sw = new StreamWriter(ruta, false))
                    {
                        foreach (Doctor est in doctor)
                        {
                            sw.WriteLine($"{est.ID},{est.NombreCompleto},{est.Especialidad}");
                        }
                    }

                    ActualizarGrid();

                    MessageBox.Show("Doctor eliminado");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un doctor para eliminar");
            }
        }

      
    }
}
