
namespace Parcial_2
{
    partial class MenuUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuario));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.metroTile1.ForeColor = System.Drawing.Color.ForestGreen;
            this.metroTile1.Location = new System.Drawing.Point(231, 131);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(301, 197);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Perfil";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile1);
            this.Name = "MenuUsuario";
            this.Text = "MenuUsuario";
            this.Load += new System.EventHandler(this.MenuUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
    }
}