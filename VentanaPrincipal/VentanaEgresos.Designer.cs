namespace VentanaPrincipal
{
    partial class VentanaEgresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEgresos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.b_imprimir = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.b_final = new System.Windows.Forms.Button();
            this.b_siguiente = new System.Windows.Forms.Button();
            this.b_anterior = new System.Windows.Forms.Button();
            this.b_inicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_f5 = new System.Windows.Forms.Button();
            this.b_nuevo = new System.Windows.Forms.Button();
            this.b_modificar = new System.Windows.Forms.Button();
            this.b_historial = new System.Windows.Forms.Button();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_guardar = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.tb_talon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_descipcion = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_boleta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.cb_colegio = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(950, 283);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.b_imprimir);
            this.panel3.Controls.Add(this.b_salir);
            this.panel3.Controls.Add(this.b_final);
            this.panel3.Controls.Add(this.b_siguiente);
            this.panel3.Controls.Add(this.b_anterior);
            this.panel3.Controls.Add(this.b_inicio);
            this.panel3.Location = new System.Drawing.Point(30, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 30);
            this.panel3.TabIndex = 67;
            // 
            // b_imprimir
            // 
            this.b_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.b_imprimir.Location = new System.Drawing.Point(711, 3);
            this.b_imprimir.Name = "b_imprimir";
            this.b_imprimir.Size = new System.Drawing.Size(120, 25);
            this.b_imprimir.TabIndex = 23;
            this.b_imprimir.TabStop = false;
            this.b_imprimir.Text = "Vista Previa";
            this.b_imprimir.UseVisualStyleBackColor = true;
            this.b_imprimir.Click += new System.EventHandler(this.b_imprimir_Click);
            // 
            // b_salir
            // 
            this.b_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_salir.Location = new System.Drawing.Point(585, 3);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(120, 25);
            this.b_salir.TabIndex = 64;
            this.b_salir.TabStop = false;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // b_final
            // 
            this.b_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_final.Location = new System.Drawing.Point(459, 3);
            this.b_final.Name = "b_final";
            this.b_final.Size = new System.Drawing.Size(120, 25);
            this.b_final.TabIndex = 63;
            this.b_final.TabStop = false;
            this.b_final.Text = ">>";
            this.b_final.UseVisualStyleBackColor = true;
            this.b_final.Click += new System.EventHandler(this.b_final_Click);
            // 
            // b_siguiente
            // 
            this.b_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_siguiente.Location = new System.Drawing.Point(333, 3);
            this.b_siguiente.Name = "b_siguiente";
            this.b_siguiente.Size = new System.Drawing.Size(120, 25);
            this.b_siguiente.TabIndex = 62;
            this.b_siguiente.TabStop = false;
            this.b_siguiente.Text = ">";
            this.b_siguiente.UseVisualStyleBackColor = true;
            this.b_siguiente.Click += new System.EventHandler(this.b_siguiente_Click);
            // 
            // b_anterior
            // 
            this.b_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_anterior.Location = new System.Drawing.Point(207, 3);
            this.b_anterior.Name = "b_anterior";
            this.b_anterior.Size = new System.Drawing.Size(120, 25);
            this.b_anterior.TabIndex = 61;
            this.b_anterior.TabStop = false;
            this.b_anterior.Text = "<";
            this.b_anterior.UseVisualStyleBackColor = true;
            this.b_anterior.Click += new System.EventHandler(this.b_anterior_Click);
            // 
            // b_inicio
            // 
            this.b_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_inicio.Location = new System.Drawing.Point(81, 3);
            this.b_inicio.Name = "b_inicio";
            this.b_inicio.Size = new System.Drawing.Size(120, 25);
            this.b_inicio.TabIndex = 60;
            this.b_inicio.TabStop = false;
            this.b_inicio.Text = "<<";
            this.b_inicio.UseVisualStyleBackColor = true;
            this.b_inicio.Click += new System.EventHandler(this.b_inicio_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.b_f5);
            this.panel2.Controls.Add(this.b_nuevo);
            this.panel2.Controls.Add(this.b_modificar);
            this.panel2.Controls.Add(this.b_historial);
            this.panel2.Controls.Add(this.b_eliminar);
            this.panel2.Controls.Add(this.b_cancelar);
            this.panel2.Controls.Add(this.b_guardar);
            this.panel2.Location = new System.Drawing.Point(30, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 33);
            this.panel2.TabIndex = 70;
            // 
            // b_f5
            // 
            this.b_f5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_f5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_f5.Location = new System.Drawing.Point(776, 5);
            this.b_f5.Name = "b_f5";
            this.b_f5.Size = new System.Drawing.Size(120, 25);
            this.b_f5.TabIndex = 22;
            this.b_f5.TabStop = false;
            this.b_f5.Text = "Actualizar";
            this.b_f5.UseVisualStyleBackColor = true;
            this.b_f5.Click += new System.EventHandler(this.b_f5_Click);
            // 
            // b_nuevo
            // 
            this.b_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_nuevo.Location = new System.Drawing.Point(20, 5);
            this.b_nuevo.Name = "b_nuevo";
            this.b_nuevo.Size = new System.Drawing.Size(120, 25);
            this.b_nuevo.TabIndex = 19;
            this.b_nuevo.TabStop = false;
            this.b_nuevo.Text = "Nuevo";
            this.b_nuevo.UseVisualStyleBackColor = true;
            this.b_nuevo.Click += new System.EventHandler(this.b_nuevo_Click);
            // 
            // b_modificar
            // 
            this.b_modificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_modificar.Location = new System.Drawing.Point(146, 5);
            this.b_modificar.Name = "b_modificar";
            this.b_modificar.Size = new System.Drawing.Size(120, 25);
            this.b_modificar.TabIndex = 16;
            this.b_modificar.TabStop = false;
            this.b_modificar.Text = "Modificar";
            this.b_modificar.UseVisualStyleBackColor = true;
            this.b_modificar.Click += new System.EventHandler(this.b_modificar_Click);
            // 
            // b_historial
            // 
            this.b_historial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_historial.Location = new System.Drawing.Point(650, 5);
            this.b_historial.Name = "b_historial";
            this.b_historial.Size = new System.Drawing.Size(120, 25);
            this.b_historial.TabIndex = 21;
            this.b_historial.TabStop = false;
            this.b_historial.Text = "Historial";
            this.b_historial.UseVisualStyleBackColor = true;
            this.b_historial.Click += new System.EventHandler(this.b_historial_Click);
            // 
            // b_eliminar
            // 
            this.b_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_eliminar.Enabled = false;
            this.b_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eliminar.Location = new System.Drawing.Point(272, 5);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(120, 25);
            this.b_eliminar.TabIndex = 17;
            this.b_eliminar.TabStop = false;
            this.b_eliminar.Text = "Eliminar";
            this.b_eliminar.UseVisualStyleBackColor = true;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_cancelar.Enabled = false;
            this.b_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cancelar.Location = new System.Drawing.Point(524, 5);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(120, 25);
            this.b_cancelar.TabIndex = 20;
            this.b_cancelar.TabStop = false;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_guardar
            // 
            this.b_guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_guardar.Enabled = false;
            this.b_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_guardar.Location = new System.Drawing.Point(398, 5);
            this.b_guardar.Name = "b_guardar";
            this.b_guardar.Size = new System.Drawing.Size(120, 25);
            this.b_guardar.TabIndex = 18;
            this.b_guardar.TabStop = false;
            this.b_guardar.Text = "Guardar";
            this.b_guardar.UseVisualStyleBackColor = true;
            this.b_guardar.Click += new System.EventHandler(this.b_guardar_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tb_monto
            // 
            this.tb_monto.Enabled = false;
            this.tb_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_monto.Location = new System.Drawing.Point(717, 70);
            this.tb_monto.MaxLength = 10;
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(120, 23);
            this.tb_monto.TabIndex = 6;
            this.tb_monto.Tag = "Monto";
            this.tb_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_talon
            // 
            this.tb_talon.Enabled = false;
            this.tb_talon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_talon.Location = new System.Drawing.Point(167, 70);
            this.tb_talon.MaxLength = 20;
            this.tb_talon.Name = "tb_talon";
            this.tb_talon.Size = new System.Drawing.Size(120, 23);
            this.tb_talon.TabIndex = 4;
            this.tb_talon.Tag = "Número de Talón";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Número de Boleta";
            // 
            // tb_descipcion
            // 
            this.tb_descipcion.Enabled = false;
            this.tb_descipcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descipcion.Location = new System.Drawing.Point(232, 120);
            this.tb_descipcion.MaxLength = 42;
            this.tb_descipcion.Name = "tb_descipcion";
            this.tb_descipcion.Size = new System.Drawing.Size(500, 23);
            this.tb_descipcion.TabIndex = 7;
            this.tb_descipcion.Tag = "Descripción";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Enabled = false;
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(467, 20);
            this.tb_codigo.MaxLength = 6;
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(120, 23);
            this.tb_codigo.TabIndex = 2;
            this.tb_codigo.Tag = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(617, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto";
            // 
            // tb_boleta
            // 
            this.tb_boleta.Enabled = false;
            this.tb_boleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_boleta.Location = new System.Drawing.Point(467, 70);
            this.tb_boleta.MaxLength = 8;
            this.tb_boleta.Name = "tb_boleta";
            this.tb_boleta.Size = new System.Drawing.Size(120, 23);
            this.tb_boleta.TabIndex = 5;
            this.tb_boleta.Tag = "Número de Boleta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Talón";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Colegio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(617, 20);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(47, 17);
            this.Fecha.TabIndex = 16;
            this.Fecha.Text = "Fecha";
            // 
            // cb_colegio
            // 
            this.cb_colegio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_colegio.FormattingEnabled = true;
            this.cb_colegio.Items.AddRange(new object[] {
            "France la sorbona",
            "Michel Duclercq"});
            this.cb_colegio.Location = new System.Drawing.Point(167, 20);
            this.cb_colegio.Name = "cb_colegio";
            this.cb_colegio.Size = new System.Drawing.Size(121, 21);
            this.cb_colegio.TabIndex = 17;
            this.cb_colegio.SelectedIndexChanged += new System.EventHandler(this.cb_colegio_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(670, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cb_colegio);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_boleta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_codigo);
            this.panel1.Controls.Add(this.tb_descipcion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_talon);
            this.panel1.Controls.Add(this.tb_monto);
            this.panel1.Location = new System.Drawing.Point(30, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 175);
            this.panel1.TabIndex = 71;
            // 
            // VentanaEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "VentanaEgresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egresos";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VentanaEgresos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button b_imprimir;
        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.Button b_final;
        private System.Windows.Forms.Button b_siguiente;
        private System.Windows.Forms.Button b_anterior;
        private System.Windows.Forms.Button b_inicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_f5;
        private System.Windows.Forms.Button b_nuevo;
        private System.Windows.Forms.Button b_modificar;
        private System.Windows.Forms.Button b_historial;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_guardar;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox tb_monto;
        private System.Windows.Forms.TextBox tb_talon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_descipcion;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_boleta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.ComboBox cb_colegio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
    }
}