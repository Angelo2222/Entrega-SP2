namespace prysp2
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mrcCabaña = new System.Windows.Forms.GroupBox();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.mrcFormadepago = new System.Windows.Forms.GroupBox();
            this.cmbTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.mrcAdi = new System.Windows.Forms.GroupBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkTelevision = new System.Windows.Forms.CheckBox();
            this.mrcTitular = new System.Windows.Forms.GroupBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.mrcCabaña.SuspendLayout();
            this.mrcFormadepago.SuspendLayout();
            this.mrcAdi.SuspendLayout();
            this.mrcTitular.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcCabaña
            // 
            this.mrcCabaña.Controls.Add(this.cmbDias);
            this.mrcCabaña.Controls.Add(this.cmbTipo);
            this.mrcCabaña.Controls.Add(this.cmbPersonas);
            this.mrcCabaña.Controls.Add(this.lblPersonas);
            this.mrcCabaña.Controls.Add(this.lblDias);
            this.mrcCabaña.Controls.Add(this.lblTipo);
            this.mrcCabaña.Location = new System.Drawing.Point(87, 44);
            this.mrcCabaña.Name = "mrcCabaña";
            this.mrcCabaña.Size = new System.Drawing.Size(597, 103);
            this.mrcCabaña.TabIndex = 0;
            this.mrcCabaña.TabStop = false;
            this.mrcCabaña.Text = "Tipo de Cabaña";
            // 
            // cmbDias
            // 
            this.cmbDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDias.Enabled = false;
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20+"});
            this.cmbDias.Location = new System.Drawing.Point(403, 44);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(121, 21);
            this.cmbDias.TabIndex = 14;
            this.cmbDias.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbTipo.Location = new System.Drawing.Point(65, 44);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(114, 21);
            this.cmbTipo.TabIndex = 5;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonas.Enabled = false;
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbPersonas.Location = new System.Drawing.Point(242, 44);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonas.TabIndex = 4;
            this.cmbPersonas.SelectedIndexChanged += new System.EventHandler(this.cmbPersonas_SelectedIndexChanged);
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Enabled = false;
            this.lblPersonas.Location = new System.Drawing.Point(185, 47);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 12;
            this.lblPersonas.Text = "Personas";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Enabled = false;
            this.lblDias.Location = new System.Drawing.Point(369, 47);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 13;
            this.lblDias.Text = "Dias";
            this.lblDias.Click += new System.EventHandler(this.lblDias_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(24, 47);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo";
            // 
            // mrcFormadepago
            // 
            this.mrcFormadepago.Controls.Add(this.cmbTarjetas);
            this.mrcFormadepago.Controls.Add(this.lblTarjetas);
            this.mrcFormadepago.Controls.Add(this.optEfectivo);
            this.mrcFormadepago.Controls.Add(this.optTarjeta);
            this.mrcFormadepago.Enabled = false;
            this.mrcFormadepago.Location = new System.Drawing.Point(313, 165);
            this.mrcFormadepago.Name = "mrcFormadepago";
            this.mrcFormadepago.Size = new System.Drawing.Size(371, 100);
            this.mrcFormadepago.TabIndex = 1;
            this.mrcFormadepago.TabStop = false;
            this.mrcFormadepago.Text = "Forma de Pago";
            this.mrcFormadepago.Enter += new System.EventHandler(this.mrcFormadepago_Enter);
            // 
            // cmbTarjetas
            // 
            this.cmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjetas.Enabled = false;
            this.cmbTarjetas.FormattingEnabled = true;
            this.cmbTarjetas.Items.AddRange(new object[] {
            "Card Red con recargo del %10",
            "Card Green con recargo del %20",
            "Card Blue con recargo del %20"});
            this.cmbTarjetas.Location = new System.Drawing.Point(32, 70);
            this.cmbTarjetas.Name = "cmbTarjetas";
            this.cmbTarjetas.Size = new System.Drawing.Size(266, 21);
            this.cmbTarjetas.TabIndex = 18;
            this.cmbTarjetas.SelectedIndexChanged += new System.EventHandler(this.cmbTarjetas_SelectedIndexChanged);
            this.cmbTarjetas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(29, 51);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(40, 13);
            this.lblTarjetas.TabIndex = 15;
            this.lblTarjetas.Text = "Tarjeta";
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(32, 27);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 9;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(198, 27);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 10;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // mrcAdi
            // 
            this.mrcAdi.Controls.Add(this.chkCocina);
            this.mrcAdi.Controls.Add(this.chkHeladera);
            this.mrcAdi.Controls.Add(this.chkTelevision);
            this.mrcAdi.Enabled = false;
            this.mrcAdi.Location = new System.Drawing.Point(87, 165);
            this.mrcAdi.Name = "mrcAdi";
            this.mrcAdi.Size = new System.Drawing.Size(200, 100);
            this.mrcAdi.TabIndex = 0;
            this.mrcAdi.TabStop = false;
            this.mrcAdi.Text = "Adicionales";
            this.mrcAdi.Enter += new System.EventHandler(this.mrcAdi_Enter);
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(27, 27);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 6;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(27, 51);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 7;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkTelevision
            // 
            this.chkTelevision.AutoSize = true;
            this.chkTelevision.Location = new System.Drawing.Point(27, 74);
            this.chkTelevision.Name = "chkTelevision";
            this.chkTelevision.Size = new System.Drawing.Size(74, 17);
            this.chkTelevision.TabIndex = 8;
            this.chkTelevision.Text = "Television";
            this.chkTelevision.UseVisualStyleBackColor = true;
            // 
            // mrcTitular
            // 
            this.mrcTitular.Controls.Add(this.lblTelefono);
            this.mrcTitular.Controls.Add(this.txtTelefono);
            this.mrcTitular.Controls.Add(this.txtNombre);
            this.mrcTitular.Controls.Add(this.lblNombre);
            this.mrcTitular.Enabled = false;
            this.mrcTitular.Location = new System.Drawing.Point(87, 281);
            this.mrcTitular.Name = "mrcTitular";
            this.mrcTitular.Size = new System.Drawing.Size(597, 100);
            this.mrcTitular.TabIndex = 2;
            this.mrcTitular.TabStop = false;
            this.mrcTitular.Text = "Titutal de la Reserva";
            this.mrcTitular.Enter += new System.EventHandler(this.mrcTitular_Enter);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(33, 68);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(88, 65);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(436, 20);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 39);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(436, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(656, 405);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(84, 415);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(0, 13);
            this.lblResumen.TabIndex = 18;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 508);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTitular);
            this.Controls.Add(this.mrcAdi);
            this.Controls.Add(this.mrcFormadepago);
            this.Controls.Add(this.mrcCabaña);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Reserva de Cabañas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mrcCabaña.ResumeLayout(false);
            this.mrcCabaña.PerformLayout();
            this.mrcFormadepago.ResumeLayout(false);
            this.mrcFormadepago.PerformLayout();
            this.mrcAdi.ResumeLayout(false);
            this.mrcAdi.PerformLayout();
            this.mrcTitular.ResumeLayout(false);
            this.mrcTitular.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCabaña;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox mrcFormadepago;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.GroupBox mrcAdi;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkTelevision;
        private System.Windows.Forms.GroupBox mrcTitular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbTarjetas;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Label lblResumen;
    }
}

