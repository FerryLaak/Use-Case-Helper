namespace Use_Case_Helper
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
            this.PicBoxDraw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxDraw
            // 
            this.PicBoxDraw.BackColor = System.Drawing.Color.White;
            this.PicBoxDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBoxDraw.Location = new System.Drawing.Point(12, 12);
            this.PicBoxDraw.Name = "PicBoxDraw";
            this.PicBoxDraw.Size = new System.Drawing.Size(791, 468);
            this.PicBoxDraw.TabIndex = 0;
            this.PicBoxDraw.TabStop = false;
            this.PicBoxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxDraw_Paint);
            this.PicBoxDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBoxDraw_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 492);
            this.Controls.Add(this.PicBoxDraw);
            this.Name = "Form1";
            this.Text = "Use Case Helper";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxDraw;
    }
}

