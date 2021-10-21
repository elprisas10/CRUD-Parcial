
namespace Parcial_2
{
    partial class Form1
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
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(149, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre de usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(484, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Contraseña";
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(435, 332);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "Registrarse";
            this.metroLink1.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(254, 336);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(175, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Si no tiene cuenta, registrese";
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(116, 206);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(190, 23);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContrasena
            // 
            // 
            // 
            // 
            this.txtContrasena.CustomButton.Image = null;
            this.txtContrasena.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtContrasena.CustomButton.Name = "";
            this.txtContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasena.CustomButton.TabIndex = 1;
            this.txtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasena.CustomButton.UseSelectable = true;
            this.txtContrasena.CustomButton.Visible = false;
            this.txtContrasena.Lines = new string[0];
            this.txtContrasena.Location = new System.Drawing.Point(425, 206);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '\0';
            this.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.ShortcutsEnabled = true;
            this.txtContrasena.Size = new System.Drawing.Size(190, 23);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.UseSelectable = true;
            this.txtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(327, 256);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(318, 37);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "INICIO DE SESION";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(693, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtContrasena;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnSalir;
    }
}

