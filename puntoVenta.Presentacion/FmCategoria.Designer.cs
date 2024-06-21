namespace puntoVenta.Presentacion
{
    partial class FmCategoria
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
            this.Tap_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btReporte = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tboxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.Tap_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // Tap_principal
            // 
            this.Tap_principal.Controls.Add(this.tabPage1);
            this.Tap_principal.Controls.Add(this.tabPage2);
            this.Tap_principal.Location = new System.Drawing.Point(3, 12);
            this.Tap_principal.Name = "Tap_principal";
            this.Tap_principal.SelectedIndex = 0;
            this.Tap_principal.Size = new System.Drawing.Size(740, 301);
            this.Tap_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPrincipal);
            this.tabPage1.Controls.Add(this.btBuscar);
            this.tabPage1.Controls.Add(this.tboxBuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btCancelar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.tboxDescripcionCategoria);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(95, 344);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 1;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(197, 344);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 2;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(314, 344);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 3;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // btReporte
            // 
            this.btReporte.Location = new System.Drawing.Point(428, 344);
            this.btReporte.Name = "btReporte";
            this.btReporte.Size = new System.Drawing.Size(75, 23);
            this.btReporte.TabIndex = 4;
            this.btReporte.Text = "Reporte";
            this.btReporte.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(533, 344);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(25, 72);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.Size = new System.Drawing.Size(686, 173);
            this.dgvPrincipal.TabIndex = 9;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(263, 29);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // tboxBuscar
            // 
            this.tboxBuscar.Location = new System.Drawing.Point(64, 29);
            this.tboxBuscar.Name = "tboxBuscar";
            this.tboxBuscar.Size = new System.Drawing.Size(184, 20);
            this.tboxBuscar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tboxDescripcionCategoria
            // 
            this.tboxDescripcionCategoria.Location = new System.Drawing.Point(110, 61);
            this.tboxDescripcionCategoria.Name = "tboxDescripcionCategoria";
            this.tboxDescripcionCategoria.Size = new System.Drawing.Size(235, 20);
            this.tboxDescripcionCategoria.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(98, 156);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(227, 156);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // FmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 391);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btReporte);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.Tap_principal);
            this.Name = "FmCategoria";
            this.Text = " ";
            this.Tap_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tap_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btReporte;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tboxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxDescripcionCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}