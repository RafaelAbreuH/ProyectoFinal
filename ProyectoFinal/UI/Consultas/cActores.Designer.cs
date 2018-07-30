namespace ProyectoFinal.UI.Consultas
{
    partial class cActores
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
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.ReporteButton = new System.Windows.Forms.Button();
            this.Consultabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "id",
            "Nombre",
            "Fecha Nacimiento",
            "Listar Todo"});
            this.FiltroComboBox.Location = new System.Drawing.Point(12, 45);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(160, 21);
            this.FiltroComboBox.TabIndex = 45;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(199, 46);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(164, 20);
            this.CriterioTextBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Criterio";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(12, 23);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(29, 13);
            this.Tipo.TabIndex = 42;
            this.Tipo.Text = "Filtro";
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(12, 90);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(586, 297);
            this.ConsultaDataGridView.TabIndex = 41;
            // 
            // ReporteButton
            // 
            this.ReporteButton.Image = global::ProyectoFinal.Properties.Resources.icons8_file_261;
            this.ReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReporteButton.Location = new System.Drawing.Point(476, 5);
            this.ReporteButton.Name = "ReporteButton";
            this.ReporteButton.Size = new System.Drawing.Size(121, 31);
            this.ReporteButton.TabIndex = 56;
            this.ReporteButton.Text = "Reporte";
            this.ReporteButton.UseVisualStyleBackColor = true;
            // 
            // Consultabutton
            // 
            this.Consultabutton.Image = global::ProyectoFinal.Properties.Resources.icons8_find_user_male_24;
            this.Consultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultabutton.Location = new System.Drawing.Point(349, 5);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(121, 31);
            this.Consultabutton.TabIndex = 55;
            this.Consultabutton.Text = "Consultar";
            this.Consultabutton.UseVisualStyleBackColor = true;
            // 
            // cActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 393);
            this.Controls.Add(this.ReporteButton);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Name = "cActores";
            this.Text = "cActores";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.Button ReporteButton;
        private System.Windows.Forms.Button Consultabutton;
    }
}