namespace VentanaPrincipal
{
    partial class VentanaMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_balance = new System.Windows.Forms.Button();
            this.b_servicios = new System.Windows.Forms.Button();
            this.b_egresos = new System.Windows.Forms.Button();
            this.b_ingresos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_balance);
            this.panel1.Controls.Add(this.b_servicios);
            this.panel1.Controls.Add(this.b_egresos);
            this.panel1.Controls.Add(this.b_ingresos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 298);
            this.panel1.TabIndex = 0;
            // 
            // b_balance
            // 
            this.b_balance.Location = new System.Drawing.Point(183, 169);
            this.b_balance.Name = "b_balance";
            this.b_balance.Size = new System.Drawing.Size(337, 90);
            this.b_balance.TabIndex = 3;
            this.b_balance.Text = "Balance de Cuentas";
            this.b_balance.UseVisualStyleBackColor = true;
            this.b_balance.Click += new System.EventHandler(this.b_balance_Click);
            // 
            // b_servicios
            // 
            this.b_servicios.Location = new System.Drawing.Point(455, 57);
            this.b_servicios.Name = "b_servicios";
            this.b_servicios.Size = new System.Drawing.Size(180, 90);
            this.b_servicios.TabIndex = 2;
            this.b_servicios.Text = "Servicios";
            this.b_servicios.UseVisualStyleBackColor = true;
            this.b_servicios.Click += new System.EventHandler(this.b_servicios_Click);
            // 
            // b_egresos
            // 
            this.b_egresos.Location = new System.Drawing.Point(243, 57);
            this.b_egresos.Name = "b_egresos";
            this.b_egresos.Size = new System.Drawing.Size(180, 90);
            this.b_egresos.TabIndex = 1;
            this.b_egresos.Text = "Egresos";
            this.b_egresos.UseVisualStyleBackColor = true;
            this.b_egresos.Click += new System.EventHandler(this.b_egresos_Click);
            // 
            // b_ingresos
            // 
            this.b_ingresos.Location = new System.Drawing.Point(40, 57);
            this.b_ingresos.Name = "b_ingresos";
            this.b_ingresos.Size = new System.Drawing.Size(180, 90);
            this.b_ingresos.TabIndex = 0;
            this.b_ingresos.Text = "Ingresos";
            this.b_ingresos.UseVisualStyleBackColor = true;
            this.b_ingresos.Click += new System.EventHandler(this.b_ingresos_Click);
            // 
            // VentanaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 322);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "VentanaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VentanaMenu_KeyUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_ingresos;
        private System.Windows.Forms.Button b_balance;
        private System.Windows.Forms.Button b_servicios;
        private System.Windows.Forms.Button b_egresos;
    }
}