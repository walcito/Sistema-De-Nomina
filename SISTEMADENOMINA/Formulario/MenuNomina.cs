using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SISTEMADENOMINA;

namespace SISTEMADENOMINA.Formulario
{
    public partial class MenuNomina : Form
    {
        // Almacenamiento en memoria RAM
        private List<Empleado> listaMemoria = new List<Empleado>();
        private System.Windows.Forms.RichTextBox rtbReportes;

        public MenuNomina()
        {
            InitializeComponent();
            ConfigurarColumnasTabla();
            rtbReportes = new System.Windows.Forms.RichTextBox();
            rtbReportes.Dock = DockStyle.Bottom;
            rtbReportes.Height = 200;
            this.Controls.Add(rtbReportes);
        }

        // Prepara las columnas de la tabla (DataGridView)
        private void ConfigurarColumnasTabla()
        {
            dgvDatos.Columns.Clear();
            dgvDatos.Columns.Add("nom", "Nombre");
            dgvDatos.Columns.Add("ape", "Apellido");
            dgvDatos.Columns.Add("nss", "Seguro Social");
            dgvDatos.Columns.Add("tipo", "Tipo");
            dgvDatos.Columns.Add("pago", "Monto a Pagar");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado nuevo = null;
            string tipo = cbTipoEmpleado.Text;

            try
            {

                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtSalarioSemanal.Text))
                {
                    MessageBox.Show("Por favor, completa los campos requeridos :3.");
                    return;
                }

                //variables
                string nombre = txtNombre.Text;
                string apellido = txtApellidos.Text;
                string nss = txtNSS.Text;
                double montoReferencia = double.Parse(txtSalarioSemanal.Text);

                // Polimorfismo
                if (tipo == "Asalariado")
                {
                    nuevo = new EmpleadoAsalariado
                    {
                        PrimerNombre = nombre,
                        ApellidoPaterno = apellido,
                        NumeroSeguroSocial = nss,
                        SalarioSemanal = montoReferencia
                    };
                }
                else if (tipo == "Por Horas")
                {
                    nuevo = new EmpleadoPorHoras
                    {
                        PrimerNombre = nombre,
                        ApellidoPaterno = apellido,
                        NumeroSeguroSocial = nss,
                        SueldoPorHora = montoReferencia,
                        HorasTrabajadas = 40 // Valor estandar por defecto
                    };
                }
                else if (tipo == "Comision")
                {
                    nuevo = new EmpleadoComision
                    {
                        PrimerNombre = nombre,
                        ApellidoPaterno = apellido,
                        NumeroSeguroSocial = nss,
                        VentasBrutas = montoReferencia,
                        TarifaComision = 0.10 // 10% de comision estandar
                    };
                }
                else if (tipo == "Asalariado Comision")
                {
                    nuevo = new EmpleadoAsalariadoComision
                    {
                        PrimerNombre = nombre,
                        ApellidoPaterno = apellido,
                        NumeroSeguroSocial = nss,
                        VentasBrutas = montoReferencia * 0.5,
                        TarifaComision = 0.10,
                        SalarioBase = montoReferencia
                    };
                }


                if (nuevo != null)
                {
                    listaMemoria.Add(nuevo); // Almacenamiento 


                    dgvDatos.Rows.Add(nuevo.PrimerNombre,
                                      nuevo.ApellidoPaterno,
                                      nuevo.NumeroSeguroSocial,
                                      tipo,
                                      nuevo.CalcularPago().ToString("C2"));

                    MessageBox.Show("Empleado agregado UwU");


                    txtSalarioSemanal.Clear();
                }
                else
                {
                    MessageBox.Show("Selecciona un tipo de empleado valido :v.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduce un numero valido en el salario... " + ex.Message);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            
            rtbReporte.Clear();

            if (listaMemoria.Count == 0)
            {
                MessageBox.Show("No hay empleados registrados para generar el reporte.");
                return;
            }

           
            rtbReporte.AppendText("❀° ┄───────────────────────────╮\n");
            rtbReporte.AppendText("          REPORTE DE NOMINA          \n");
            rtbReporte.AppendText("╰───────────────────────────┄ °❀\n\n");

           
            foreach (var emp in listaMemoria)
            {
                rtbReporte.AppendText($" > {emp.ToString()}\n");
                rtbReporte.AppendText($" > MONTO CALCULADO: {emp.CalcularPago():C2}\n");
                rtbReporte.AppendText(" ───────────────────────────────\n");
            }

            rtbReporte.AppendText("\n        FIN DEL REPORTE        ");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (listaMemoria.Count > 0)
            {
                Empleado ultimo = listaMemoria[listaMemoria.Count - 1];
                MessageBox.Show($"Calculo rApido del ultimo ingreso: {ultimo.CalcularPago():C2}");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Corregido: Ahora revisa el control 'rtbReporte' que es el que tiene el texto
                if (string.IsNullOrEmpty(rtbReporte.Text))
                {
                    MessageBox.Show("El reporte esta vacio. Presiona el boton 'Reporte' primero :3.");
                    return;
                }

                // Genera el nombre del archivo con la fecha actual
                string nombreArchivo = "ReporteNomina_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

                // Corregido: Guarda el contenido de 'rtbReporte' en el archivo
                System.IO.File.WriteAllText(nombreArchivo, rtbReporte.Text);

                MessageBox.Show("Archivito ha sido guardado con exito como: " + nombreArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir :v: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // Empleado por Comision
        public class EmpleadoComision : Empleado
        {
            public double VentasBrutas { get; set; }
            public double TarifaComision { get; set; }
            public override double CalcularPago() => VentasBrutas * TarifaComision;
        }

        // Empleado Asalariado por Comision
        public class EmpleadoAsalariadoComision : EmpleadoComision
        {
            public double SalarioBase { get; set; }
            public override double CalcularPago() => base.CalcularPago() + SalarioBase + (SalarioBase * 0.10);
        }

      
            private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtNombre.Clear();
            txtApellidos.Clear();
            txtNSS.Clear();
            txtSalarioSemanal.Clear();
            cbTipoEmpleado.SelectedIndex = -1;
            rtbReporte.Clear();
            dgvDatos.Rows.Clear();
            listaMemoria.Clear();

            MessageBox.Show("Ahora si, to clin, clin");
        }
    }
   
}