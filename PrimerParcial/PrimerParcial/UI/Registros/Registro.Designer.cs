namespace PrimerParcial.UI.Registros
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.GruposID = new System.Windows.Forms.Label();
            this.GruposIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.Label();
            this.Decripcion = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.grupos1 = new System.Windows.Forms.Label();
            this.Integrantes = new System.Windows.Forms.Label();
            this.DescripciontextBox1 = new System.Windows.Forms.TextBox();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GrupoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IntegrantesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GruposIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegrantesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // GruposID
            // 
            this.GruposID.AutoSize = true;
            this.GruposID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GruposID.Location = new System.Drawing.Point(24, 86);
            this.GruposID.Name = "GruposID";
            this.GruposID.Size = new System.Drawing.Size(59, 15);
            this.GruposID.TabIndex = 1;
            this.GruposID.Text = "GruposID";
            // 
            // GruposIDnumericUpDown
            // 
            this.GruposIDnumericUpDown.Location = new System.Drawing.Point(95, 84);
            this.GruposIDnumericUpDown.Name = "GruposIDnumericUpDown";
            this.GruposIDnumericUpDown.Size = new System.Drawing.Size(189, 20);
            this.GruposIDnumericUpDown.TabIndex = 2;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::PrimerParcial.Properties.Resources.Delete;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(288, 339);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(92, 58);
            this.Eliminarbutton.TabIndex = 6;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::PrimerParcial.Properties.Resources.Save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(170, 339);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(84, 58);
            this.Guardarbutton.TabIndex = 5;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::PrimerParcial.Properties.Resources.new2;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(43, 339);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(89, 58);
            this.Nuevobutton.TabIndex = 4;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::PrimerParcial.Properties.Resources.find;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(303, 75);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(84, 35);
            this.BuscarButton.TabIndex = 3;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(27, 133);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 7;
            this.Fecha.Text = "Fecha";
            // 
            // Decripcion
            // 
            this.Decripcion.AutoSize = true;
            this.Decripcion.Location = new System.Drawing.Point(29, 172);
            this.Decripcion.Name = "Decripcion";
            this.Decripcion.Size = new System.Drawing.Size(63, 13);
            this.Decripcion.TabIndex = 8;
            this.Decripcion.Text = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(30, 212);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 9;
            this.Cantidad.Text = "Cantidad";
            // 
            // grupos1
            // 
            this.grupos1.AutoSize = true;
            this.grupos1.Location = new System.Drawing.Point(36, 253);
            this.grupos1.Name = "grupos1";
            this.grupos1.Size = new System.Drawing.Size(41, 13);
            this.grupos1.TabIndex = 10;
            this.grupos1.Text = "Grupos";
            // 
            // Integrantes
            // 
            this.Integrantes.AutoSize = true;
            this.Integrantes.Location = new System.Drawing.Point(33, 287);
            this.Integrantes.Name = "Integrantes";
            this.Integrantes.Size = new System.Drawing.Size(60, 13);
            this.Integrantes.TabIndex = 11;
            this.Integrantes.Text = "Integrantes";
            // 
            // DescripciontextBox1
            // 
            this.DescripciontextBox1.Location = new System.Drawing.Point(99, 161);
            this.DescripciontextBox1.Multiline = true;
            this.DescripciontextBox1.Name = "DescripciontextBox1";
            this.DescripciontextBox1.Size = new System.Drawing.Size(185, 35);
            this.DescripciontextBox1.TabIndex = 12;
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(99, 211);
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(185, 20);
            this.CantidadNumericUpDown.TabIndex = 13;
            this.CantidadNumericUpDown.ValueChanged += new System.EventHandler(this.CantidadNumericUpDown_ValueChanged);
            // 
            // GrupoNumericUpDown
            // 
            this.GrupoNumericUpDown.Location = new System.Drawing.Point(99, 249);
            this.GrupoNumericUpDown.Name = "GrupoNumericUpDown";
            this.GrupoNumericUpDown.Size = new System.Drawing.Size(185, 20);
            this.GrupoNumericUpDown.TabIndex = 14;
            this.GrupoNumericUpDown.ValueChanged += new System.EventHandler(this.GrupoNumericUpDown_ValueChanged);
            // 
            // IntegrantesNumericUpDown
            // 
            this.IntegrantesNumericUpDown.Location = new System.Drawing.Point(99, 282);
            this.IntegrantesNumericUpDown.Name = "IntegrantesNumericUpDown";
            this.IntegrantesNumericUpDown.ReadOnly = true;
            this.IntegrantesNumericUpDown.Size = new System.Drawing.Size(185, 20);
            this.IntegrantesNumericUpDown.TabIndex = 15;
            
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(99, 125);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(185, 20);
            this.FechaDateTimePicker.TabIndex = 16;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(425, 420);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.IntegrantesNumericUpDown);
            this.Controls.Add(this.GrupoNumericUpDown);
            this.Controls.Add(this.CantidadNumericUpDown);
            this.Controls.Add(this.DescripciontextBox1);
            this.Controls.Add(this.Integrantes);
            this.Controls.Add(this.grupos1);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Decripcion);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GruposIDnumericUpDown);
            this.Controls.Add(this.GruposID);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro De Personas";
            ((System.ComponentModel.ISupportInitialize)(this.GruposIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegrantesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GruposID;
        private System.Windows.Forms.NumericUpDown GruposIDnumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Decripcion;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label grupos1;
        private System.Windows.Forms.Label Integrantes;
        private System.Windows.Forms.TextBox DescripciontextBox1;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.NumericUpDown GrupoNumericUpDown;
        private System.Windows.Forms.NumericUpDown IntegrantesNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
    }
}