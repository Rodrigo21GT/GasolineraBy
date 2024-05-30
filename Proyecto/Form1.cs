using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProyectoFinalProgra
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        List<Abastecimiento> abastecimientos = new List<Abastecimiento>();
        List<Reporte> reportes = new List<Reporte>();

        int contador_b1 = 0;
        int contador_b2 = 0;
        int contador_a1 = 0;
        int contador_a2 = 0;
        bool sePresionoAbastecer = false;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM7", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Acceso denegado al puerto COM. Asegúrate de que no esté siendo utilizado por otra aplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            if (data.Contains("OK"))
            {
                MessageBox.Show("Datos recibidos correctamente por el Arduino.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (data.Contains("Precio total:"))
            {
                string[] parts = data.Split(':');
                if (parts.Length == 2)
                {
                    string precioTotalStr = parts[1].Trim();
                    int precioTotal;
                    if (int.TryParse(precioTotalStr, out precioTotal))
                    {
                        MessageBox.Show($"El precio total es: {precioTotal}");
                    }
                }
            }
        }

        public void MostrarAbastecimientos()
        {
            //Mostrar la lista de Abastecimiento en el DataGridView
            dataGridView.DataSource = null;
            dataGridView.DataSource = reportes;
            dataGridView.Refresh();
        }

        private void buttonAbastecer_Click(object sender, EventArgs e)
        {
            // Obtener datos
            abastecimientos.Clear();
            Abastecimiento abastecimiento = new Abastecimiento();
            abastecimiento.Bomba = comboBoxBomba.Text;
            abastecimiento.Cliente = textBoxCliente.Text;
            abastecimiento.FechaHora = DateTime.Now;
            abastecimiento.Monto = textBoxMontoPagar.Text;
            abastecimiento.TipoAbastecimiento = comboBoxTipoAbastecimiento.Text;
            abastecimiento.Espacio = "";

            // Guardar datos
            abastecimientos.Add(abastecimiento);

            Reporte reporte = new Reporte();
            reporte.Bomba = abastecimiento.Bomba;
            reporte.Cliente = abastecimiento.Cliente;
            reporte.FechaHora = DateTime.Now;
            reporte.Monto = abastecimiento.Monto;
            reporte.TipoAbastecimiento = abastecimiento.TipoAbastecimiento;

            reportes.Add(reporte);

            sePresionoAbastecer = true;

            InformeAbastecimientosPorEstilo();
            InformeBombasUtilizadas();
            MostrarAbastecimientos();
            GrabarAbastecimientos();
            GuardarDatosComoJson();

            textBoxCliente.Clear();
            textBoxMontoPagar.Clear();

            sePresionoAbastecer = false;
        }

        private void GuardarDatosComoJson()
        {
            string json = JsonConvert.SerializeObject(abastecimientos, Formatting.Indented);
            File.WriteAllText("datos.json", json);

            EnviarDatosArduino(json);
        }

        private void EnviarDatosArduino(string datos)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(datos);
            }
            else
            {
                MessageBox.Show("El puerto COM no está abierto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrabarAbastecimientos()
        {
            FileStream stream = new FileStream("Abastecimientos.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var abastecimiento in abastecimientos)
            {
                writer.WriteLine(abastecimiento.Cliente);
                writer.WriteLine(abastecimiento.FechaHora);
                writer.WriteLine(abastecimiento.Bomba);
                writer.WriteLine(abastecimiento.Monto);
                writer.WriteLine(abastecimiento.TipoAbastecimiento);
                writer.WriteLine(abastecimiento.Espacio);
            }
            writer.Close();
        }

        private void buttonMostrarAbastecimiento_Click(object sender, EventArgs e)
        {
            // Ruta de archivo
            string filePath = "C:\\Users\\rodri\\Downloads\\Proyecto\\bin\\Debug\\abastecimientos.txt";

            if (File.Exists(filePath))
            {
                FileStream flujo = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader lector = new StreamReader(flujo);

                // Limpiar el contenido previo del richTextBox
                richTextBox1.Clear();

                // Leer y mostrar el contenido del archivo en el richTextBox
                while (lector.Peek() > -1)
                {
                    richTextBox1.AppendText(lector.ReadLine() + "\n");
                }
                lector.Close();
            }
            else
            {
                MessageBox.Show("El archivo especificado no existe.");
            }
        }

        private void CierreDeCajaDiario(DateTime fecha)
        {
            decimal total = 0;
            foreach (var reporte in reportes)
            {
                if (reporte.FechaHora.Date == fecha.Date)
                {
                    total += Convert.ToDecimal(reporte.Monto);
                }
            }
            labelCierreCaja.Visible = true;
            labelCierreCaja.Text = $"Cierre de caja para el {fecha.ToShortDateString()}: Total: {total}";
        }


        private void InformeAbastecimientosPorEstilo()
        {
            if (comboBoxTipoAbastecimiento.Text == "Prepago limitado" && sePresionoAbastecer == true)
            {
                contador_a1++;

            }
            else if (comboBoxTipoAbastecimiento.Text == "Tanque lleno" && sePresionoAbastecer == true)
            {
                contador_a2++;

            }

            labelPrepago.Text = contador_a1 + " veces";
            labelTanque.Text = contador_a2 + " veces";

            labelPrepago.Visible = true;
            labelTanque.Visible = true;
        }


        private void InformeBombasUtilizadas()
        {
            if (comboBoxBomba.Text == "Bomba 1" && sePresionoAbastecer == true)
            {
                contador_b1++;

            }
            else if (comboBoxBomba.Text == "Bomba 2" && sePresionoAbastecer == true)
            {
                contador_b2++;

            }
            if (contador_b1 > contador_b2)
            {
                labelBombaMasUtilizada.Text = "Bomba 1 usos: " + contador_b1 + " veces";
                labelBombaMenosUtilizada.Text = "Bomba 2 usos:" + contador_b2 + " veces";
            }
            else if (contador_b1 < contador_b2)
            {
                labelBombaMenosUtilizada.Text = "Bomba 1 usos: " + contador_b1 + " veces";
                labelBombaMasUtilizada.Text = "Bomba 2 usos: " + contador_b2 + " veces";
            }
            else if(contador_b1 == contador_b2)
            {
                labelBombaMenosUtilizada.Text = "Ambas bombas lo son";
                labelBombaMasUtilizada.Text = "Ambas bombas lo son";
            }
            labelBombaMasUtilizada.Visible = true;
            labelBombaMenosUtilizada.Visible = true;
        }

        private void buttonEstadisticas_Click_1(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            CierreDeCajaDiario(fechaActual);
            InformeAbastecimientosPorEstilo();
            InformeBombasUtilizadas();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

