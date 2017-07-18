namespace VentanaPrincipal
{
    partial class VentanaBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaBalance));
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_intervalo = new System.Windows.Forms.RadioButton();
            this.rb_year = new System.Windows.Forms.RadioButton();
            this.rb_mes = new System.Windows.Forms.RadioButton();
            this.rb_dia = new System.Windows.Forms.RadioButton();
            this.gb_dia = new System.Windows.Forms.GroupBox();
            this.picker_dia = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picker_final = new System.Windows.Forms.DateTimePicker();
            this.picker_inicio = new System.Windows.Forms.DateTimePicker();
            this.picker_year = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.picker_mes = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_mes = new System.Windows.Forms.GroupBox();
            this.gb_year = new System.Windows.Forms.GroupBox();
            this.gb_intervalo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_dia.SuspendLayout();
            this.gb_mes.SuspendLayout();
            this.gb_year.SuspendLayout();
            this.gb_intervalo.SuspendLayout();
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
            this.panel2.TabIndex = 71;
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
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(90, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 170);
            this.panel4.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_intervalo);
            this.groupBox1.Controls.Add(this.rb_year);
            this.groupBox1.Controls.Add(this.rb_mes);
            this.groupBox1.Controls.Add(this.rb_dia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegir tipo de Balance";
            // 
            // rb_intervalo
            // 
            this.rb_intervalo.AutoSize = true;
            this.rb_intervalo.Location = new System.Drawing.Point(20, 107);
            this.rb_intervalo.Name = "rb_intervalo";
            this.rb_intervalo.Size = new System.Drawing.Size(176, 21);
            this.rb_intervalo.TabIndex = 3;
            this.rb_intervalo.Text = "Por intervalo de Fechas";
            this.rb_intervalo.UseVisualStyleBackColor = true;
            this.rb_intervalo.CheckedChanged += new System.EventHandler(this.rb_intervalo_CheckedChanged);
            // 
            // rb_year
            // 
            this.rb_year.AutoSize = true;
            this.rb_year.Location = new System.Drawing.Point(20, 83);
            this.rb_year.Name = "rb_year";
            this.rb_year.Size = new System.Drawing.Size(76, 21);
            this.rb_year.TabIndex = 2;
            this.rb_year.Text = "Por año";
            this.rb_year.UseVisualStyleBackColor = true;
            this.rb_year.CheckedChanged += new System.EventHandler(this.rb_year_CheckedChanged);
            // 
            // rb_mes
            // 
            this.rb_mes.AutoSize = true;
            this.rb_mes.Location = new System.Drawing.Point(20, 59);
            this.rb_mes.Name = "rb_mes";
            this.rb_mes.Size = new System.Drawing.Size(78, 21);
            this.rb_mes.TabIndex = 1;
            this.rb_mes.Text = "Por mes";
            this.rb_mes.UseVisualStyleBackColor = true;
            this.rb_mes.CheckedChanged += new System.EventHandler(this.rb_mes_CheckedChanged);
            // 
            // rb_dia
            // 
            this.rb_dia.AutoSize = true;
            this.rb_dia.Checked = true;
            this.rb_dia.Location = new System.Drawing.Point(20, 35);
            this.rb_dia.Name = "rb_dia";
            this.rb_dia.Size = new System.Drawing.Size(71, 21);
            this.rb_dia.TabIndex = 0;
            this.rb_dia.TabStop = true;
            this.rb_dia.Text = "Por día";
            this.rb_dia.UseVisualStyleBackColor = true;
            this.rb_dia.CheckedChanged += new System.EventHandler(this.rb_dia_CheckedChanged);
            // 
            // gb_dia
            // 
            this.gb_dia.Controls.Add(this.picker_dia);
            this.gb_dia.Controls.Add(this.label2);
            this.gb_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_dia.Location = new System.Drawing.Point(20, 10);
            this.gb_dia.Name = "gb_dia";
            this.gb_dia.Size = new System.Drawing.Size(450, 150);
            this.gb_dia.TabIndex = 4;
            this.gb_dia.TabStop = false;
            this.gb_dia.Text = "Balance por día";
            // 
            // picker_dia
            // 
            this.picker_dia.Location = new System.Drawing.Point(170, 70);
            this.picker_dia.Name = "picker_dia";
            this.picker_dia.Size = new System.Drawing.Size(250, 23);
            this.picker_dia.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Elegir el día";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 95;
            this.label7.Text = "Fecha de Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 94;
            this.label6.Text = "Fecha de Inicio";
            // 
            // picker_final
            // 
            this.picker_final.Location = new System.Drawing.Point(172, 94);
            this.picker_final.Name = "picker_final";
            this.picker_final.Size = new System.Drawing.Size(250, 23);
            this.picker_final.TabIndex = 93;
            // 
            // picker_inicio
            // 
            this.picker_inicio.Location = new System.Drawing.Point(172, 43);
            this.picker_inicio.Name = "picker_inicio";
            this.picker_inicio.Size = new System.Drawing.Size(250, 23);
            this.picker_inicio.TabIndex = 92;
            // 
            // picker_year
            // 
            this.picker_year.Location = new System.Drawing.Point(170, 70);
            this.picker_year.Name = "picker_year";
            this.picker_year.Size = new System.Drawing.Size(250, 23);
            this.picker_year.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Elegir el año";
            // 
            // picker_mes
            // 
            this.picker_mes.Location = new System.Drawing.Point(170, 70);
            this.picker_mes.Name = "picker_mes";
            this.picker_mes.Size = new System.Drawing.Size(250, 23);
            this.picker_mes.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Por mes";
            // 
            // gb_mes
            // 
            this.gb_mes.Controls.Add(this.picker_mes);
            this.gb_mes.Controls.Add(this.label3);
            this.gb_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_mes.Location = new System.Drawing.Point(20, 10);
            this.gb_mes.Name = "gb_mes";
            this.gb_mes.Size = new System.Drawing.Size(450, 150);
            this.gb_mes.TabIndex = 87;
            this.gb_mes.TabStop = false;
            this.gb_mes.Text = "Balance por mes";
            this.gb_mes.Visible = false;
            // 
            // gb_year
            // 
            this.gb_year.Controls.Add(this.picker_year);
            this.gb_year.Controls.Add(this.label4);
            this.gb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_year.Location = new System.Drawing.Point(20, 10);
            this.gb_year.Name = "gb_year";
            this.gb_year.Size = new System.Drawing.Size(450, 150);
            this.gb_year.TabIndex = 89;
            this.gb_year.TabStop = false;
            this.gb_year.Text = "Balance por año";
            this.gb_year.Visible = false;
            // 
            // gb_intervalo
            // 
            this.gb_intervalo.Controls.Add(this.picker_final);
            this.gb_intervalo.Controls.Add(this.picker_inicio);
            this.gb_intervalo.Controls.Add(this.label6);
            this.gb_intervalo.Controls.Add(this.label7);
            this.gb_intervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_intervalo.Location = new System.Drawing.Point(20, 10);
            this.gb_intervalo.Name = "gb_intervalo";
            this.gb_intervalo.Size = new System.Drawing.Size(450, 150);
            this.gb_intervalo.TabIndex = 90;
            this.gb_intervalo.TabStop = false;
            this.gb_intervalo.Text = "Balance por intervalo de Fechas";
            this.gb_intervalo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gb_mes);
            this.panel1.Controls.Add(this.gb_dia);
            this.panel1.Controls.Add(this.gb_intervalo);
            this.panel1.Controls.Add(this.gb_year);
            this.panel1.Location = new System.Drawing.Point(409, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 172);
            this.panel1.TabIndex = 91;
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
            // VentanaBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "VentanaBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance de Cuentas";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VentanaBalance_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_dia.ResumeLayout(false);
            this.gb_dia.PerformLayout();
            this.gb_mes.ResumeLayout(false);
            this.gb_mes.PerformLayout();
            this.gb_year.ResumeLayout(false);
            this.gb_year.PerformLayout();
            this.gb_intervalo.ResumeLayout(false);
            this.gb_intervalo.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_year;
        private System.Windows.Forms.RadioButton rb_mes;
        private System.Windows.Forms.RadioButton rb_dia;
        private System.Windows.Forms.RadioButton rb_intervalo;
        private System.Windows.Forms.GroupBox gb_dia;
        private System.Windows.Forms.DateTimePicker picker_dia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker picker_final;
        private System.Windows.Forms.DateTimePicker picker_inicio;
        private System.Windows.Forms.DateTimePicker picker_year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker picker_mes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_mes;
        private System.Windows.Forms.GroupBox gb_year;
        private System.Windows.Forms.GroupBox gb_intervalo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}