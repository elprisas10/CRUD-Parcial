
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
            this.dgtINew = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnMenuVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtINew)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtINew
            // 
            this.dgtINew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtINew.Location = new System.Drawing.Point(77, 96);
            this.dgtINew.Name = "dgtINew";
            this.dgtINew.Size = new System.Drawing.Size(648, 180);
            this.dgtINew.TabIndex = 0;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(175, 304);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver Usuarios";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.txtVer_Click);
            // 
            // btnMenuVolver
            // 
            this.btnMenuVolver.Location = new System.Drawing.Point(590, 401);
            this.btnMenuVolver.Name = "btnMenuVolver";
            this.btnMenuVolver.Size = new System.Drawing.Size(135, 23);
            this.btnMenuVolver.TabIndex = 2;
            this.btnMenuVolver.Text = "Volver al Menu";
            this.btnMenuVolver.UseVisualStyleBackColor = true;
            this.btnMenuVolver.Click += new System.EventHandler(this.btnMenuVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // UsuarioR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenuVolver);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dgtINew);
            this.Name = "UsuarioR";
            this.Text = "UsuarioR";
            this.Load += new System.EventHandler(this.UsuarioR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtINew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtINew;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnMenuVolver;
        private System.Windows.Forms.Label label1;
    }
}