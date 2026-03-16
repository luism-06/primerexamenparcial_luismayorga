using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PrimerExamenParcial_LuisMayorga
{
    public partial class Form4 : Form
    {
        List<Doctor> doctores = new List<Doctor>();
        List<Paciente> pacientes = new List<Paciente>();
        List<Citas> citas = new List<Citas>();

        string rutaDoctor = "doctores.txt";
        string rutaPaciente = "pacientes.txt";
        string rutaCitas = "citas.txt";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargarDoctores();
            CargarPacientes();
            CargarCitas();

            CargarComboDoctores();
            CargarComboPacientes();

            dateTimePickerFecha.Format = DateTimePickerFormat.Short;
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.ShowUpDown = true;

            MostrarCitasEnGrid();
        }

        private void CargarDoctores()
        {
            doctores.Clear();

            if (File.Exists(rutaDoctor))
            {
                using (StreamReader sr = new StreamReader(rutaDoctor))
                {
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] datos = linea.Split(',');

                        if (datos.Length == 3)
                        {
                            Doctor d = new Doctor();
                            d.ID = datos[0];
                            d.NombreCompleto = datos[1];
                            d.Especialidad = datos[2];

                            doctores.Add(d);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo doctores.txt");
            }
        }

        private void CargarPacientes()
        {
            pacientes.Clear();

            if (File.Exists(rutaPaciente))
            {
                using (StreamReader sr = new StreamReader(rutaPaciente))
                {
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] datos = linea.Split(',');

                        if (datos.Length == 3)
                        {
                            Paciente p = new Paciente();
                            p.DPI = datos[0];
                            p.Nombre = datos[1];
                            p.Telefono = datos[2];

                            pacientes.Add(p);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo pacientes.txt");
            }
        }

        private void CargarCitas()
        {
            citas.Clear();

            if (File.Exists(rutaCitas))
            {
                using (StreamReader sr = new StreamReader(rutaCitas))
                {
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] datos = linea.Split(',');

                        if (datos.Length == 4)
                        {
                            Citas c = new Citas();
                            c.ID_Doctor = datos[0];
                            c.DPI_Paciente = datos[1];
                            c.Fecha = datos[2];
                            c.Hora = datos[3];

                            citas.Add(c);
                        }
                    }
                }
            }
        }

        private void CargarComboDoctores()
        {
            comboBoxID.DataSource = null;
            comboBoxID.DataSource = doctores;
            comboBoxID.DisplayMember = "NombreCompleto";
            comboBoxID.ValueMember = "ID";
        }

        private void CargarComboPacientes()
        {
            comboBoxDPI.DataSource = null;
            comboBoxDPI.DataSource = pacientes;
            comboBoxDPI.DisplayMember = "Nombre";
            comboBoxDPI.ValueMember = "DPI";
        }

        private void MostrarCitasEnGrid()
        {
            var reporte = from c in citas
                          join d in doctores on c.ID_Doctor equals d.ID
                          join p in pacientes on c.DPI_Paciente equals p.DPI
                          select new
                          {
                              Doctor = d.NombreCompleto,
                              Especialidad = d.Especialidad,
                              Paciente = p.Nombre,
                              Fecha = c.Fecha,
                              Hora = c.Hora
                          };

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reporte.ToList();
        }

        private void GuardarCitasEnArchivo()
        {
            using (StreamWriter sw = new StreamWriter(rutaCitas, false))
            {
                foreach (Citas c in citas)
                {
                    sw.WriteLine($"{c.ID_Doctor},{c.DPI_Paciente},{c.Fecha},{c.Hora}");
                }
            }
        }

        private void buttonGuardarCita_Click(object sender, EventArgs e)
        {
            if (comboBoxID.SelectedItem == null || comboBoxDPI.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un doctor y un paciente.");
                return;
            }

            Doctor doctorSeleccionado = (Doctor)comboBoxID.SelectedItem;
            Paciente pacienteSeleccionado = (Paciente)comboBoxDPI.SelectedItem;

            Citas nuevaCita = new Citas();
            nuevaCita.ID_Doctor = doctorSeleccionado.ID;
            nuevaCita.DPI_Paciente = pacienteSeleccionado.DPI;
            nuevaCita.Fecha = dateTimePickerFecha.Value.ToString("dd/MM/yyyy");
            nuevaCita.Hora = dateTimePickerHora.Value.ToString("HH:mm");

            citas.Add(nuevaCita);
            GuardarCitasEnArchivo();
            MostrarCitasEnGrid();

            MessageBox.Show("Cita guardada correctamente.");
        }

        private void buttonEliminarCita_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cita para eliminar.");
                return;
            }

            string nombreDoctor = dataGridView1.CurrentRow.Cells["Doctor"].Value.ToString();
            string nombrePaciente = dataGridView1.CurrentRow.Cells["Paciente"].Value.ToString();
            string fecha = dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString();
            string hora = dataGridView1.CurrentRow.Cells["Hora"].Value.ToString();

            Citas citaEliminar = (from c in citas
                                  join d in doctores on c.ID_Doctor equals d.ID
                                  join p in pacientes on c.DPI_Paciente equals p.DPI
                                  where d.NombreCompleto == nombreDoctor
                                     && p.Nombre == nombrePaciente
                                     && c.Fecha == fecha
                                     && c.Hora == hora
                                  select c).FirstOrDefault();

            if (citaEliminar != null)
            {
                citas.Remove(citaEliminar);
                GuardarCitasEnArchivo();
                MostrarCitasEnGrid();
                MessageBox.Show("Cita eliminada correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró la cita.");
            }
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxDPI_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonOrdenarPorNombreDoctor_Click(object sender, EventArgs e)
        {
            var reporte = from c in citas
                          join d in doctores on c.ID_Doctor equals d.ID
                          join p in pacientes on c.DPI_Paciente equals p.DPI
                          orderby d.NombreCompleto
                          select new
                          {
                              Doctor = d.NombreCompleto,
                              Especialidad = d.Especialidad,
                              Paciente = p.Nombre,
                              Fecha = c.Fecha,
                              Hora = c.Hora
                          };

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reporte.ToList();
        }

        private void buttonMostrarCantidadCitasRegistradas_Click(object sender, EventArgs e)
        {
            int total = citas.Count;

            MessageBox.Show("Total de citas registradas: " + total);
        }
    }
}
