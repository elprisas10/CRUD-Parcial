
namespace Parcial_2
{
    partial class Registros
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
            this.btnMenu = new MetroFramework.Controls.MetroButton();
            this.dgt2 = new System.Windows.Forms.DataGridView();
            this.Int1 = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.dgt2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(233, 329);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(159, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Volver al menu";
            this.btnMenu.UseSelectable = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dgt2
            // 
            this.dgt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt2.Location = new System.Drawing.Point(32, 22);
            this.dgt2.Name = "dgt2";
            this.dgt2.Size = new System.Drawing.Size(517, 266);
            this.dgt2.TabIndex = 1;
            // 
            // Int1
            // 
            this.Int1.AutoSize = true;
            this.Int1.Location = new System.Drawing.Point(599, 123);
            this.Int1.Name = "Int1";
            this.Int1.Size = new System.Drawing.Size(80, 17);
            this.Int1.TabIndex = 2;
            this.Int1.Text = "Off";
            this.Int1.UseSelectable = true;
            this.Int1.CheckedChanged += new System.EventHandler(this.Int1_CheckedChanged);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Int1);
            this.Controls.Add(this.dgt2);
            this.Controls.Add(this.btnMenu);
            this.Name = "Registros";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnMenu;
        private System.Windows.Forms.DataGridView dgt2;
        private MetroFramework.Controls.MetroToggle Int1;
    }
}