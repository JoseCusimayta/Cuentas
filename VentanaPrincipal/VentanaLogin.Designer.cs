namespace VentanaPrincipal
{
    partial class VentanaLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.b_ingresar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_tipo);
            this.panel1.Controls.Add(this.b_ingresar);
            this.panel1.Controls.Add(this.b_cancelar);
            this.panel1.Controls.Add(this.tb_usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_clave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 197);
            this.panel1.TabIndex = 13;
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cb_tipo.Location = new System.Drawing.Point(62, 108);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(142, 21);
            this.cb_tipo.TabIndex = 11;
            // 
            // b_ingresar
            // 
            this.b_ingresar.Location = new System.Drawing.Point(28, 150);
            this.b_ingresar.Name = "b_ingresar";
            this.b_ingresar.Size = new System.Drawing.Size(75, 23);
            this.b_ingresar.TabIndex = 3;
            this.b_ingresar.TabStop = false;
            this.b_ingresar.Text = "Ingresar";
            this.b_ingresar.UseVisualStyleBackColor = true;
            this.b_ingresar.Click += new System.EventHandler(this.b_ingresar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancelar.Location = new System.Drawing.Point(154, 150);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 23);
            this.b_cancelar.TabIndex = 4;
            this.b_cancelar.TabStop = false;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(129, 19);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_usuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Clave";
            // 
            // tb_clave
            // 
            this.tb_clave.Location = new System.Drawing.Point(129, 66);
            this.tb_clave.Name = "tb_clave";
            this.tb_clave.PasswordChar = '*';
            this.tb_clave.Size = new System.Drawing.Size(100, 20);
            this.tb_clave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // VentanaLogin
            // 
            this.AcceptButton = this.b_ingresar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.b_cancelar;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 265);
            this.MinimumSize = new System.Drawing.Size(300, 265);
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_ingresar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tipo;
    }
}

