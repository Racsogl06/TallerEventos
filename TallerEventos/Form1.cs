using System;
using System.Drawing;
using System.Windows.Forms;
using TallerEventos.Clases;

namespace TallerEventos
{
    public partial class Form1 : Form
    {
        List<Clases.Tarea> tareas = new List<Clases.Tarea>();

        public Form1()
        {
            InitializeComponent();
            // Inicializar ComboBox con los estados posibles
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("En Progreso");
            cmbEstado.Items.Add("Completada");
            cmbEstado.SelectedIndex = 0; // Establecer el estado predeterminado
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            AgregarTarea();
        }

        private void txtNombreTarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarTarea();
                e.SuppressKeyPress = true; // Evitar el sonido de "ding"
            }
        }

        private void AgregarTarea()
        {
            if (txtNombreTarea.Text.Trim() == "")
            {
                MessageBox.Show("Debe agregar un nombre para la tarea");
                return;
            }
            Clases.Tarea nuevaTarea = new Clases.Tarea(txtNombreTarea.Text, cmbEstado.SelectedItem.ToString());
            tareas.Add(nuevaTarea);
            txtNombreTarea.Clear();
            RenderizarTareas();
        }

        private void RenderizarTareas()
        {
            flowPanelTareasPendientes.Controls.Clear();
            flowPanelTareasEnProgreso.Controls.Clear();
            flowPanelTareasCompletadas.Controls.Clear();

            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = new Label();
                tarjeta.Text = tarea.nombre;
                tarjeta.AutoSize = true;
                tarjeta.Padding = new Padding(10);
                tarjeta.Margin = new Padding(10);
                tarjeta.BackColor = Color.White;
                tarjeta.ForeColor = Color.Black;
                tarjeta.BorderStyle = BorderStyle.FixedSingle;
                tarjeta.Tag = tarea; // Guardar la tarea en la etiqueta para su eliminación

                tarjeta.MouseHover += (sender, e) =>
                {
                    tarjeta.BackColor = Color.LightGray;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Bold);
                };

                tarjeta.MouseLeave += (sender, e) =>
                {
                    tarjeta.BackColor = Color.White;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Regular);
                };

                tarjeta.DoubleClick += (sender, e) =>
                {
                    tareas.Remove((Tarea)tarjeta.Tag);
                    RenderizarTareas();
                };

                switch (tarea.estado)
                {
                    case "Pendiente":
                        flowPanelTareasPendientes.Controls.Add(tarjeta);
                        break;
                    case "En Progreso":
                        flowPanelTareasEnProgreso.Controls.Add(tarjeta);
                        break;
                    case "Completada":
                        flowPanelTareasCompletadas.Controls.Add(tarjeta);
                        break;
                }
            }
        }
    }
}
