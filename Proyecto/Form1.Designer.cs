namespace ProyectoFinalProgra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAbastecer = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.comboBoxBomba = new System.Windows.Forms.ComboBox();
            this.labelBomba = new System.Windows.Forms.Label();
            this.buttonMostrarAbastecimiento = new System.Windows.Forms.Button();
            this.textBoxMontoPagar = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxTipoAbastecimiento = new System.Windows.Forms.ComboBox();
            this.labelMetodoAbastecimiento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCierreCaja = new System.Windows.Forms.Label();
            this.buttonEstadisticas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrepago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBombaMasUtilizada = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBombaMenosUtilizada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTanque = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAbastecer
            // 
            this.buttonAbastecer.BackColor = System.Drawing.Color.Red;
            this.buttonAbastecer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbastecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbastecer.Location = new System.Drawing.Point(72, 390);
            this.buttonAbastecer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbastecer.Name = "buttonAbastecer";
            this.buttonAbastecer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAbastecer.Size = new System.Drawing.Size(147, 59);
            this.buttonAbastecer.TabIndex = 0;
            this.buttonAbastecer.Text = "Abastecer";
            this.buttonAbastecer.UseVisualStyleBackColor = false;
            this.buttonAbastecer.Click += new System.EventHandler(this.buttonAbastecer_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(451, 168);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(195, 22);
            this.textBoxCliente.TabIndex = 1;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.ForeColor = System.Drawing.Color.Red;
            this.labelNombreCliente.Location = new System.Drawing.Point(37, 158);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(317, 30);
            this.labelNombreCliente.TabIndex = 4;
            this.labelNombreCliente.Text = "Nombre del cliente:";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.ForeColor = System.Drawing.Color.Red;
            this.labelMonto.Location = new System.Drawing.Point(37, 206);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(285, 30);
            this.labelMonto.TabIndex = 5;
            this.labelMonto.Text = "Cantidad a pagar:";
            // 
            // comboBoxBomba
            // 
            this.comboBoxBomba.FormattingEnabled = true;
            this.comboBoxBomba.Items.AddRange(new object[] {
            "Bomba 1",
            "Bomba 2"});
            this.comboBoxBomba.Location = new System.Drawing.Point(451, 117);
            this.comboBoxBomba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBomba.Name = "comboBoxBomba";
            this.comboBoxBomba.Size = new System.Drawing.Size(195, 24);
            this.comboBoxBomba.TabIndex = 7;
            // 
            // labelBomba
            // 
            this.labelBomba.AutoSize = true;
            this.labelBomba.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBomba.ForeColor = System.Drawing.Color.Red;
            this.labelBomba.Location = new System.Drawing.Point(37, 107);
            this.labelBomba.Name = "labelBomba";
            this.labelBomba.Size = new System.Drawing.Size(109, 30);
            this.labelBomba.TabIndex = 8;
            this.labelBomba.Text = "Bomba:";
            // 
            // buttonMostrarAbastecimiento
            // 
            this.buttonMostrarAbastecimiento.BackColor = System.Drawing.Color.Red;
            this.buttonMostrarAbastecimiento.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarAbastecimiento.Location = new System.Drawing.Point(505, 380);
            this.buttonMostrarAbastecimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMostrarAbastecimiento.Name = "buttonMostrarAbastecimiento";
            this.buttonMostrarAbastecimiento.Size = new System.Drawing.Size(217, 73);
            this.buttonMostrarAbastecimiento.TabIndex = 9;
            this.buttonMostrarAbastecimiento.Text = "Abastecimientos Previos";
            this.buttonMostrarAbastecimiento.UseVisualStyleBackColor = false;
            this.buttonMostrarAbastecimiento.Click += new System.EventHandler(this.buttonMostrarAbastecimiento_Click);
            // 
            // textBoxMontoPagar
            // 
            this.textBoxMontoPagar.Location = new System.Drawing.Point(451, 214);
            this.textBoxMontoPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMontoPagar.Name = "textBoxMontoPagar";
            this.textBoxMontoPagar.Size = new System.Drawing.Size(195, 22);
            this.textBoxMontoPagar.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(826, 155);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(811, 242);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(826, 401);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(809, 267);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // comboBoxTipoAbastecimiento
            // 
            this.comboBoxTipoAbastecimiento.FormattingEnabled = true;
            this.comboBoxTipoAbastecimiento.Items.AddRange(new object[] {
            "Prepago limitado",
            "Tanque lleno"});
            this.comboBoxTipoAbastecimiento.Location = new System.Drawing.Point(451, 254);
            this.comboBoxTipoAbastecimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTipoAbastecimiento.Name = "comboBoxTipoAbastecimiento";
            this.comboBoxTipoAbastecimiento.Size = new System.Drawing.Size(195, 24);
            this.comboBoxTipoAbastecimiento.TabIndex = 14;
            // 
            // labelMetodoAbastecimiento
            // 
            this.labelMetodoAbastecimiento.AutoSize = true;
            this.labelMetodoAbastecimiento.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodoAbastecimiento.ForeColor = System.Drawing.Color.Red;
            this.labelMetodoAbastecimiento.Location = new System.Drawing.Point(37, 254);
            this.labelMetodoAbastecimiento.Name = "labelMetodoAbastecimiento";
            this.labelMetodoAbastecimiento.Size = new System.Drawing.Size(381, 30);
            this.labelMetodoAbastecimiento.TabIndex = 15;
            this.labelMetodoAbastecimiento.Text = "Tipo de abastecimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(618, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 96);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gasolinera By";
            // 
            // labelCierreCaja
            // 
            this.labelCierreCaja.AutoSize = true;
            this.labelCierreCaja.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCierreCaja.Location = new System.Drawing.Point(288, 581);
            this.labelCierreCaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCierreCaja.Name = "labelCierreCaja";
            this.labelCierreCaja.Size = new System.Drawing.Size(0, 16);
            this.labelCierreCaja.TabIndex = 18;
            this.labelCierreCaja.Visible = false;
            // 
            // buttonEstadisticas
            // 
            this.buttonEstadisticas.BackColor = System.Drawing.Color.Red;
            this.buttonEstadisticas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEstadisticas.Location = new System.Drawing.Point(282, 383);
            this.buttonEstadisticas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEstadisticas.Name = "buttonEstadisticas";
            this.buttonEstadisticas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEstadisticas.Size = new System.Drawing.Size(167, 66);
            this.buttonEstadisticas.TabIndex = 19;
            this.buttonEstadisticas.Text = "Estadisticas";
            this.buttonEstadisticas.UseVisualStyleBackColor = false;
            this.buttonEstadisticas.Click += new System.EventHandler(this.buttonEstadisticas_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(53, 581);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cierre de caja diario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(51, 632);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Abastecimiento por prepago limitado:";
            // 
            // labelPrepago
            // 
            this.labelPrepago.AutoSize = true;
            this.labelPrepago.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPrepago.Location = new System.Drawing.Point(405, 632);
            this.labelPrepago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrepago.Name = "labelPrepago";
            this.labelPrepago.Size = new System.Drawing.Size(0, 16);
            this.labelPrepago.TabIndex = 22;
            this.labelPrepago.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(51, 720);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bomba más utilizada:";
            // 
            // labelBombaMasUtilizada
            // 
            this.labelBombaMasUtilizada.AutoSize = true;
            this.labelBombaMasUtilizada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelBombaMasUtilizada.Location = new System.Drawing.Point(311, 720);
            this.labelBombaMasUtilizada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBombaMasUtilizada.Name = "labelBombaMasUtilizada";
            this.labelBombaMasUtilizada.Size = new System.Drawing.Size(0, 16);
            this.labelBombaMasUtilizada.TabIndex = 24;
            this.labelBombaMasUtilizada.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(51, 767);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Bomba menos utilizada:";
            // 
            // labelBombaMenosUtilizada
            // 
            this.labelBombaMenosUtilizada.AutoSize = true;
            this.labelBombaMenosUtilizada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelBombaMenosUtilizada.Location = new System.Drawing.Point(311, 767);
            this.labelBombaMenosUtilizada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBombaMenosUtilizada.Name = "labelBombaMenosUtilizada";
            this.labelBombaMenosUtilizada.Size = new System.Drawing.Size(0, 16);
            this.labelBombaMenosUtilizada.TabIndex = 26;
            this.labelBombaMenosUtilizada.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(51, 675);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Abastecimiento por Tanque lleno:";
            // 
            // labelTanque
            // 
            this.labelTanque.AutoSize = true;
            this.labelTanque.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTanque.Location = new System.Drawing.Point(370, 675);
            this.labelTanque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTanque.Name = "labelTanque";
            this.labelTanque.Size = new System.Drawing.Size(0, 16);
            this.labelTanque.TabIndex = 28;
            this.labelTanque.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(826, 702);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1694, 881);
            this.Controls.Add(this.labelTanque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelBombaMenosUtilizada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelBombaMasUtilizada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPrepago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEstadisticas);
            this.Controls.Add(this.labelCierreCaja);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMetodoAbastecimiento);
            this.Controls.Add(this.comboBoxTipoAbastecimiento);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxMontoPagar);
            this.Controls.Add(this.buttonMostrarAbastecimiento);
            this.Controls.Add(this.labelBomba);
            this.Controls.Add(this.comboBoxBomba);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.buttonAbastecer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Proyecto Final";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbastecer;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.ComboBox comboBoxBomba;
        private System.Windows.Forms.Label labelBomba;
        private System.Windows.Forms.Button buttonMostrarAbastecimiento;
        private System.Windows.Forms.TextBox textBoxMontoPagar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxTipoAbastecimiento;
        private System.Windows.Forms.Label labelMetodoAbastecimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCierreCaja;
        private System.Windows.Forms.Button buttonEstadisticas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrepago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelBombaMasUtilizada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBombaMenosUtilizada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTanque;
    }
}

