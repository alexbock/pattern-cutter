namespace pattern_cutter
{
    partial class ImageRegionSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ImageRegionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ImageRegionSelector";
            this.Size = new System.Drawing.Size(325, 222);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageRegionSelector_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageRegionSelector_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ImageRegionSelector_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageRegionSelector_MouseDown);
            this.MouseLeave += new System.EventHandler(this.ImageRegionSelector_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageRegionSelector_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageRegionSelector_MouseUp);
            this.Resize += new System.EventHandler(this.ImageRegionSelector_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
