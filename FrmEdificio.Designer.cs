
namespace Practicasemana12
{
    partial class FrmEdificio
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
            this.txtnombre = new MetroFramework.Controls.MetroLabel();
            this.txtdireccion = new MetroFramework.Controls.MetroLabel();
            this.txtrentados = new MetroFramework.Controls.MetroLabel();
            this.txtcantidad = new MetroFramework.Controls.MetroLabel();
            this.txnombre = new MetroFramework.Controls.MetroTextBox();
            this.txdireccion = new MetroFramework.Controls.MetroTextBox();
            this.txcantidad = new MetroFramework.Controls.MetroTextBox();
            this.txrentados = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.dtgEdificio = new System.Windows.Forms.DataGridView();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEdificio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(30, 51);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(184, 44);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.Text = "Nombre del edificio:";
            this.txtnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(30, 111);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(184, 49);
            this.txtdireccion.TabIndex = 2;
            this.txtdireccion.Text = "Direccion del edificio:";
            this.txtdireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtrentados
            // 
            this.txtrentados.Location = new System.Drawing.Point(30, 243);
            this.txtrentados.Name = "txtrentados";
            this.txtrentados.Size = new System.Drawing.Size(212, 40);
            this.txtrentados.TabIndex = 3;
            this.txtrentados.Text = "Departamentos rentados:";
            this.txtrentados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(30, 174);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(212, 57);
            this.txtcantidad.TabIndex = 4;
            this.txtcantidad.Text = "Cantidad de departamentos:";
            this.txtcantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txnombre
            // 
            // 
            // 
            // 
            this.txnombre.CustomButton.Image = null;
            this.txnombre.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txnombre.CustomButton.Name = "";
            this.txnombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txnombre.CustomButton.TabIndex = 1;
            this.txnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txnombre.CustomButton.UseSelectable = true;
            this.txnombre.CustomButton.Visible = false;
            this.txnombre.Lines = new string[0];
            this.txnombre.Location = new System.Drawing.Point(316, 62);
            this.txnombre.MaxLength = 32767;
            this.txnombre.Name = "txnombre";
            this.txnombre.PasswordChar = '\0';
            this.txnombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txnombre.SelectedText = "";
            this.txnombre.SelectionLength = 0;
            this.txnombre.SelectionStart = 0;
            this.txnombre.ShortcutsEnabled = true;
            this.txnombre.Size = new System.Drawing.Size(206, 23);
            this.txnombre.TabIndex = 5;
            this.txnombre.UseSelectable = true;
            this.txnombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txnombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txdireccion
            // 
            // 
            // 
            // 
            this.txdireccion.CustomButton.Image = null;
            this.txdireccion.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txdireccion.CustomButton.Name = "";
            this.txdireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txdireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txdireccion.CustomButton.TabIndex = 1;
            this.txdireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txdireccion.CustomButton.UseSelectable = true;
            this.txdireccion.CustomButton.Visible = false;
            this.txdireccion.Lines = new string[0];
            this.txdireccion.Location = new System.Drawing.Point(316, 131);
            this.txdireccion.MaxLength = 32767;
            this.txdireccion.Name = "txdireccion";
            this.txdireccion.PasswordChar = '\0';
            this.txdireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txdireccion.SelectedText = "";
            this.txdireccion.SelectionLength = 0;
            this.txdireccion.SelectionStart = 0;
            this.txdireccion.ShortcutsEnabled = true;
            this.txdireccion.Size = new System.Drawing.Size(206, 23);
            this.txdireccion.TabIndex = 6;
            this.txdireccion.UseSelectable = true;
            this.txdireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txdireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txcantidad
            // 
            // 
            // 
            // 
            this.txcantidad.CustomButton.Image = null;
            this.txcantidad.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txcantidad.CustomButton.Name = "";
            this.txcantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txcantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txcantidad.CustomButton.TabIndex = 1;
            this.txcantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txcantidad.CustomButton.UseSelectable = true;
            this.txcantidad.CustomButton.Visible = false;
            this.txcantidad.Lines = new string[0];
            this.txcantidad.Location = new System.Drawing.Point(316, 196);
            this.txcantidad.MaxLength = 32767;
            this.txcantidad.Name = "txcantidad";
            this.txcantidad.PasswordChar = '\0';
            this.txcantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txcantidad.SelectedText = "";
            this.txcantidad.SelectionLength = 0;
            this.txcantidad.SelectionStart = 0;
            this.txcantidad.ShortcutsEnabled = true;
            this.txcantidad.Size = new System.Drawing.Size(206, 23);
            this.txcantidad.TabIndex = 7;
            this.txcantidad.UseSelectable = true;
            this.txcantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txcantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txrentados
            // 
            // 
            // 
            // 
            this.txrentados.CustomButton.Image = null;
            this.txrentados.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txrentados.CustomButton.Name = "";
            this.txrentados.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txrentados.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txrentados.CustomButton.TabIndex = 1;
            this.txrentados.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txrentados.CustomButton.UseSelectable = true;
            this.txrentados.CustomButton.Visible = false;
            this.txrentados.Lines = new string[0];
            this.txrentados.Location = new System.Drawing.Point(316, 260);
            this.txrentados.MaxLength = 32767;
            this.txrentados.Name = "txrentados";
            this.txrentados.PasswordChar = '\0';
            this.txrentados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txrentados.SelectedText = "";
            this.txrentados.SelectionLength = 0;
            this.txrentados.SelectionStart = 0;
            this.txrentados.ShortcutsEnabled = true;
            this.txrentados.Size = new System.Drawing.Size(206, 23);
            this.txrentados.TabIndex = 8;
            this.txrentados.UseSelectable = true;
            this.txrentados.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txrentados.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(600, 41);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 44);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(731, 41);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 44);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(600, 111);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 43);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(731, 111);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 43);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // dtgEdificio
            // 
            this.dtgEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEdificio.Location = new System.Drawing.Point(43, 348);
            this.dtgEdificio.Name = "dtgEdificio";
            this.dtgEdificio.RowHeadersWidth = 51;
            this.dtgEdificio.RowTemplate.Height = 24;
            this.dtgEdificio.Size = new System.Drawing.Size(933, 252);
            this.dtgEdificio.TabIndex = 13;
            this.dtgEdificio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEdificio_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(878, 618);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 44);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 706);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgEdificio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txrentados);
            this.Controls.Add(this.txcantidad);
            this.Controls.Add(this.txdireccion);
            this.Controls.Add(this.txnombre);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtrentados);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Name = "FrmEdificio";
            this.Text = "FrmEdificio";
            this.Load += new System.EventHandler(this.FrmEdificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEdificio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel txtnombre;
        private MetroFramework.Controls.MetroLabel txtdireccion;
        private MetroFramework.Controls.MetroLabel txtrentados;
        private MetroFramework.Controls.MetroLabel txtcantidad;
        private MetroFramework.Controls.MetroTextBox txnombre;
        private MetroFramework.Controls.MetroTextBox txdireccion;
        private MetroFramework.Controls.MetroTextBox txcantidad;
        private MetroFramework.Controls.MetroTextBox txrentados;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.DataGridView dtgEdificio;
        private MetroFramework.Controls.MetroButton btnSalir;
    }
}