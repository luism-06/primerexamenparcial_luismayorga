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
    public partial class Form3 : Form
    {

        List<Paciente> paciente = new List<Paciente>();
        String ruta = "pacientes.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
                            Paciente est = new Paciente();
                            est.DPI = datos[0];
                            est.Nombre = datos[1];
                            est.Telefono = datos[2];

                            paciente.Add(est);
                        }
                    }
                }
            }

            ActualizarGrid();
        }


        private void ActualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = paciente;
        }

        private void buttonRegistrarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDPI.Text.Trim() == "" ||
                    textBoxNombre.Text.Trim() == "" ||
                    textBoxTelefono.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }

                bool existe = paciente.Any(x => x.DPI == textBoxDPI.Text.Trim());

                if (existe)
                {
                    MessageBox.Show("El DPI ya existe");
                    return;
                }

                Paciente nuevo = new Paciente();
                nuevo.DPI = textBoxDPI.Text.Trim();
                nuevo.Nombre = textBoxNombre.Text.Trim();
                nuevo.Telefono = textBoxTelefono.Text.Trim();

                paciente.Add(nuevo);

                using (StreamWriter sw = new StreamWriter(ruta, false))
                {
                    foreach (Paciente est in paciente)
                    {
                        sw.WriteLine($"{est.DPI},{est.Nombre},{est.Telefono}");
                    }
                }

                ActualizarGrid();

                MessageBox.Show("Paciente guardado correctamente");

                textBoxDPI.Clear();
                textBoxNombre.Clear();
                textBoxTelefono.Clear();
            }
            catch
            {
                MessageBox.Show("Error en los datos");
            }
        }

        private void buttonEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int indice = dataGridView1.CurrentRow.Index;

                if (indice >= 0 && indice < paciente.Count)
                {
                    paciente.RemoveAt(indice);

                    using (StreamWriter sw = new StreamWriter(ruta, false))
                    {
                        foreach (Paciente est in paciente)
                        {
                            sw.WriteLine($"{est.DPI},{est.Nombre},{est.Telefono}");
                        }
                    }

                    ActualizarGrid();

                    MessageBox.Show("Paciente eliminado");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para eliminar");
            }
        }
    }
}
