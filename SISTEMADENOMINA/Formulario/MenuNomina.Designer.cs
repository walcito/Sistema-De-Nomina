namespace SISTEMADENOMINA.Formulario
{
    partial class MenuNomina
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
            groupBox1 = new GroupBox();
            cbTipoEmpleado = new ComboBox();
            txtSalarioSemanal = new TextBox();
            txtNSS = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvDatos = new DataGridView();
            btnAgregar = new Button();
            btnReporte = new Button();
            btnImprimir = new Button();
            btnCalcular = new Button();
            rtbReporte = new RichTextBox();
            label7 = new Label();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTipoEmpleado);
            groupBox1.Controls.Add(txtSalarioSemanal);
            groupBox1.Controls.Add(txtNSS);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 250);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos De Empleados";
            // 
            // cbTipoEmpleado
            // 
            cbTipoEmpleado.FormattingEnabled = true;
            cbTipoEmpleado.Items.AddRange(new object[] { "Asalariado", "Por Horas", "Comision", "Asalariado Comision" });
            cbTipoEmpleado.Location = new Point(147, 177);
            cbTipoEmpleado.Name = "cbTipoEmpleado";
            cbTipoEmpleado.Size = new Size(322, 28);
            cbTipoEmpleado.TabIndex = 5;
            // 
            // txtSalarioSemanal
            // 
            txtSalarioSemanal.BorderStyle = BorderStyle.FixedSingle;
            txtSalarioSemanal.Location = new Point(147, 139);
            txtSalarioSemanal.Name = "txtSalarioSemanal";
            txtSalarioSemanal.Size = new Size(322, 27);
            txtSalarioSemanal.TabIndex = 8;
            // 
            // txtNSS
            // 
            txtNSS.BorderStyle = BorderStyle.FixedSingle;
            txtNSS.Location = new Point(147, 104);
            txtNSS.Name = "txtNSS";
            txtNSS.Size = new Size(322, 27);
            txtNSS.TabIndex = 7;
            // 
            // txtApellidos
            // 
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.Location = new Point(147, 70);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(322, 27);
            txtApellidos.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(147, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(322, 27);
            txtNombre.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 177);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 4;
            label6.Text = "Tipo De Empleado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 107);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 3;
            label5.Text = "Seguro Social ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 141);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 2;
            label4.Text = "Salario Semanal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 72);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 1;
            label3.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 37);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-4, -5);
            label1.Name = "label1";
            label1.Size = new Size(1030, 70);
            label1.TabIndex = 3;
            label1.Text = "SISTEMA DE NOMINA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(12, 417);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(1096, 321);
            dgvDatos.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 376);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(145, 35);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = SystemColors.ButtonHighlight;
            btnReporte.Location = new Point(310, 376);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(145, 35);
            btnReporte.TabIndex = 7;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(929, 97);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(145, 88);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(159, 375);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(145, 35);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rtbReporte
            // 
            rtbReporte.BorderStyle = BorderStyle.FixedSingle;
            rtbReporte.Location = new Point(517, 77);
            rtbReporte.Name = "rtbReporte";
            rtbReporte.ReadOnly = true;
            rtbReporte.Size = new Size(366, 292);
            rtbReporte.TabIndex = 10;
            rtbReporte.Text = "";
            // 
            // label7
            // 
            label7.BackColor = Color.MidnightBlue;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 77);
            label7.Name = "label7";
            label7.Size = new Size(482, 39);
            label7.TabIndex = 11;
            label7.Text = "MENU";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1032, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 70);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagen_impresora;
            pictureBox1.Location = new Point(911, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(461, 375);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 35);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // MenuNomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 742);
            Controls.Add(btnLimpiar);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(label7);
            Controls.Add(rtbReporte);
            Controls.Add(btnCalcular);
            Controls.Add(btnImprimir);
            Controls.Add(btnReporte);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDatos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "MenuNomina";
            Text = "MenuNomina";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbTipoEmpleado;
        private TextBox txtSalarioSemanal;
        private TextBox txtNSS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvDatos;
        private Button btnAgregar;
        private Button btnReporte;
        private Button btnImprimir;
        private Button btnCalcular;
        private RichTextBox rtbReporte;
        private Label label7;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Button btnLimpiar;
    }
}