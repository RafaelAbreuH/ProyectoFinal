namespace ProyectoFinal.UI.Registro
{
    partial class rFacturaDetalle
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
            this.components = new System.ComponentModel.Container();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.ImportenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ObservacionesTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.PeliculaComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FactIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImportenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(402, 327);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(89, 20);
            this.TotaltextBox.TabIndex = 164;
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::ProyectoFinal.Properties.Resources.icons8_delete_16;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(12, 328);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(70, 26);
            this.Removerbutton.TabIndex = 163;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            // 
            // ImportenumericUpDown
            // 
            this.ImportenumericUpDown.Location = new System.Drawing.Point(331, 124);
            this.ImportenumericUpDown.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.ImportenumericUpDown.Name = "ImportenumericUpDown";
            this.ImportenumericUpDown.ReadOnly = true;
            this.ImportenumericUpDown.Size = new System.Drawing.Size(107, 20);
            this.ImportenumericUpDown.TabIndex = 162;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 161;
            this.label9.Text = "Importe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 160;
            this.label8.Text = "Precio";
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(203, 124);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.CantidadnumericUpDown.TabIndex = 159;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 157;
            this.label7.Text = "Fecha Salida:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(371, 5);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.FechaDateTimePicker.TabIndex = 156;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 155;
            this.label5.Text = "Comentarios:";
            // 
            // ObservacionesTextBox
            // 
            this.ObservacionesTextBox.Location = new System.Drawing.Point(149, 327);
            this.ObservacionesTextBox.Multiline = true;
            this.ObservacionesTextBox.Name = "ObservacionesTextBox";
            this.ObservacionesTextBox.Size = new System.Drawing.Size(213, 53);
            this.ObservacionesTextBox.TabIndex = 154;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = global::ProyectoFinal.Properties.Resources.icons8_add_new_16;
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(444, 121);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(48, 26);
            this.AgregarButton.TabIndex = 153;
            this.AgregarButton.Text = "Add";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // PeliculaComboBox
            // 
            this.PeliculaComboBox.FormattingEnabled = true;
            this.PeliculaComboBox.Location = new System.Drawing.Point(331, 54);
            this.PeliculaComboBox.Name = "PeliculaComboBox";
            this.PeliculaComboBox.Size = new System.Drawing.Size(160, 21);
            this.PeliculaComboBox.TabIndex = 152;
            this.PeliculaComboBox.SelectedIndexChanged += new System.EventHandler(this.PeliculaComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 151;
            this.label6.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 147;
            this.label4.Text = "Cantidad";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(58, 124);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.ReadOnly = true;
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(84, 20);
            this.PrecioNumericUpDown.TabIndex = 146;
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(62, 54);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(140, 21);
            this.ClienteComboBox.TabIndex = 145;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 144;
            this.label3.Text = "Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 143;
            this.label2.Text = "Cliente: ";
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AllowDrop = true;
            this.DetalleDataGridView.AllowUserToOrderColumns = true;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(12, 152);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.RowHeadersVisible = false;
            this.DetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DetalleDataGridView.Size = new System.Drawing.Size(479, 169);
            this.DetalleDataGridView.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 141;
            this.label1.Text = "Factura Id";
            // 
            // FactIdNumericUpDown
            // 
            this.FactIdNumericUpDown.Location = new System.Drawing.Point(68, 7);
            this.FactIdNumericUpDown.Name = "FactIdNumericUpDown";
            this.FactIdNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.FactIdNumericUpDown.TabIndex = 140;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources.icons8_trash_16;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(371, 413);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 33);
            this.EliminarButton.TabIndex = 167;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources.icons8_save_as_16;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(203, 413);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(101, 33);
            this.GuardarButton.TabIndex = 166;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::ProyectoFinal.Properties.Resources.icons8_file_16;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(41, 413);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(101, 33);
            this.NuevoButton.TabIndex = 165;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // rFacturaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 459);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.ImportenumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ObservacionesTextBox);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.PeliculaComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FactIdNumericUpDown);
            this.Name = "rFacturaDetalle";
            this.Text = "FacturaDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.ImportenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.NumericUpDown ImportenumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ObservacionesTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ComboBox PeliculaComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FactIdNumericUpDown;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}