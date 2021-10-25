
namespace Parcial_2
{
    partial class UsuarioR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioR));
            this.dgtINew = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnMenuVolver = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtINew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtINew
            // 
            this.dgtINew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtINew.Location = new System.Drawing.Point(33, 69);
            this.dgtINew.Name = "dgtINew";
            this.dgtINew.Size = new System.Drawing.Size(648, 180);
            this.dgtINew.TabIndex = 0;
            this.dgtINew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtINew_CellContentClick);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Aqua;
            this.btnVer.Location = new System.Drawing.Point(510, 37);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver Usuarios";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.txtVer_Click);
            // 
            // btnMenuVolver
            // 
            this.btnMenuVolver.BackColor = System.Drawing.Color.Aqua;
            this.btnMenuVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuVolver.Location = new System.Drawing.Point(653, 415);
            this.btnMenuVolver.Name = "btnMenuVolver";
            this.btnMenuVolver.Size = new System.Drawing.Size(135, 23);
            this.btnMenuVolver.TabIndex = 2;
            this.btnMenuVolver.Text = "Volver al Menu";
            this.btnMenuVolver.UseVisualStyleBackColor = false;
            this.btnMenuVolver.Click += new System.EventHandler(this.btnMenuVolver_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.metroLabel1.Location = new System.Drawing.Point(137, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(169, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Registro De Usuarios";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UsuarioR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnMenuVolver);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dgtINew);
            this.Name = "UsuarioR";
            this.Text = "UsuarioR";
            this.Load += new System.EventHandler(this.UsuarioR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtINew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtINew;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnMenuVolver;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}