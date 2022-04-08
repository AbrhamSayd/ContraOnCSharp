namespace contraMapa
{
    partial class Form1
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
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.timerMoveMenu = new System.Windows.Forms.Timer(this.components);
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.Black;
            this.pbMenu.BackgroundImage = global::contraMapa.ResourceSprites.Menu;
            this.pbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMenu.Image = global::contraMapa.ResourceSprites.Menu;
            this.pbMenu.Location = new System.Drawing.Point(1200, 0);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(980, 580);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            // 
            // timerMoveMenu
            // 
            this.timerMoveMenu.Enabled = true;
            this.timerMoveMenu.Tick += new System.EventHandler(this.timerMoveMenu_Tick);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(304, 344);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(207, 26);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Presione enter para jugar";
            this.lblText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Timer timerMoveMenu;
        private System.Windows.Forms.Label lblText;
    }
}