namespace zapatosweb
{
    partial class Frmclientes
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
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtnomcliente = new System.Windows.Forms.TextBox();
            this.txtdsccliente = new System.Windows.Forms.TextBox();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.nombre_cliente = new System.Windows.Forms.Label();
            this.lbldsccliente = new System.Windows.Forms.Label();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblapellido2 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(103, 16);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(100, 20);
            this.txtidcliente.TabIndex = 0;
            // 
            // txtnomcliente
            // 
            this.txtnomcliente.Location = new System.Drawing.Point(103, 55);
            this.txtnomcliente.Name = "txtnomcliente";
            this.txtnomcliente.Size = new System.Drawing.Size(100, 20);
            this.txtnomcliente.TabIndex = 1;
            // 
            // txtdsccliente
            // 
            this.txtdsccliente.Location = new System.Drawing.Point(103, 166);
            this.txtdsccliente.Multiline = true;
            this.txtdsccliente.Name = "txtdsccliente";
            this.txtdsccliente.Size = new System.Drawing.Size(100, 26);
            this.txtdsccliente.TabIndex = 2;
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(35, 19);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(52, 13);
            this.lblidcliente.TabIndex = 3;
            this.lblidcliente.Text = "id_cliente";
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSize = true;
            this.nombre_cliente.Location = new System.Drawing.Point(35, 55);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(42, 13);
            this.nombre_cliente.TabIndex = 4;
            this.nombre_cliente.Text = "nombre";
            // 
            // lbldsccliente
            // 
            this.lbldsccliente.AutoSize = true;
            this.lbldsccliente.Location = new System.Drawing.Point(32, 169);
            this.lbldsccliente.Name = "lbldsccliente";
            this.lbldsccliente.Size = new System.Drawing.Size(45, 13);
            this.lbldsccliente.TabIndex = 5;
            this.lbldsccliente.Text = "telefono";
            // 
            // dgvcliente
            // 
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(13, 277);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(660, 150);
            this.dgvcliente.TabIndex = 6;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(489, 31);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(489, 86);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(489, 134);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 9;
            this.btnactualizar.Text = "actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(489, 187);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(38, 96);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(49, 13);
            this.lblapellido.TabIndex = 11;
            this.lblapellido.Text = "apellido1";
            // 
            // lblapellido2
            // 
            this.lblapellido2.AutoSize = true;
            this.lblapellido2.Location = new System.Drawing.Point(35, 134);
            this.lblapellido2.Name = "lblapellido2";
            this.lblapellido2.Size = new System.Drawing.Size(49, 13);
            this.lblapellido2.TabIndex = 12;
            this.lblapellido2.Text = "apellido2";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(35, 223);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 13);
            this.lblemail.TabIndex = 13;
            this.lblemail.Text = "email";
            // 
            // txtapellido1
            // 
            this.txtapellido1.Location = new System.Drawing.Point(103, 96);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(100, 20);
            this.txtapellido1.TabIndex = 14;
            // 
            // txtapellido2
            // 
            this.txtapellido2.Location = new System.Drawing.Point(103, 126);
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(100, 20);
            this.txtapellido2.TabIndex = 15;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(103, 223);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 16;
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtapellido2);
            this.Controls.Add(this.txtapellido1);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblapellido2);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.lbldsccliente);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.lblidcliente);
            this.Controls.Add(this.txtdsccliente);
            this.Controls.Add(this.txtnomcliente);
            this.Controls.Add(this.txtidcliente);
            this.Name = "Frmclientes";
            this.Text = "clientes";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtnomcliente;
        private System.Windows.Forms.TextBox txtdsccliente;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label nombre_cliente;
        private System.Windows.Forms.Label lbldsccliente;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblapellido2;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.TextBox txtapellido2;
        private System.Windows.Forms.TextBox txtemail;
    }
}

