namespace ProyectoFinal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PassworddTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EntrarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PassworddTextBox
            // 
            this.PassworddTextBox.Location = new System.Drawing.Point(105, 201);
            this.PassworddTextBox.Name = "PassworddTextBox";
            this.PassworddTextBox.PasswordChar = '*';
            this.PassworddTextBox.Size = new System.Drawing.Size(166, 20);
            this.PassworddTextBox.TabIndex = 7;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(105, 157);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(166, 20);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // EntrarButton
            // 
            this.EntrarButton.BackColor = System.Drawing.SystemColors.Control;
            this.EntrarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EntrarButton.Image = global::ProyectoFinal.Properties.Resources.icons8_find_user_male_16;
            this.EntrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EntrarButton.Location = new System.Drawing.Point(50, 245);
            this.EntrarButton.Name = "EntrarButton";
            this.EntrarButton.Size = new System.Drawing.Size(75, 23);
            this.EntrarButton.TabIndex = 8;
            this.EntrarButton.Text = "Entrar";
            this.EntrarButton.UseVisualStyleBackColor = false;
            this.EntrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalirButton.Image = global::ProyectoFinal.Properties.Resources.icons8_delete_16;
            this.SalirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalirButton.Location = new System.Drawing.Point(196, 245);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 9;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.Blockbuster_logo_svg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 274);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.EntrarButton);
            this.Controls.Add(this.PassworddTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassworddTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EntrarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}