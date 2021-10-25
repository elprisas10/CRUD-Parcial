
namespace Parcial_2
{
    partial class AdminPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPerfil));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgtAdmin = new System.Windows.Forms.DataGridView();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel1.Location = new System.Drawing.Point(106, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "PERFIL";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // dgtAdmin
            // 
            this.dgtAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtAdmin.Location = new System.Drawing.Point(279, 97);
            this.dgtAdmin.Name = "dgtAdmin";
            this.dgtAdmin.Size = new System.Drawing.Size(498, 266);
            this.dgtAdmin.TabIndex = 2;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Lime;
            this.btnAdmin.ForeColor = System.Drawing.Color.Blue;
            this.btnAdmin.Location = new System.Drawing.Point(473, 56);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(131, 23);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Ver perfil ";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.dgtAdmin);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AdminPerfil";
            this.Text = "AdminPerfil";
            this.Load += new System.EventHandler(this.AdminPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgtAdmin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}