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
            this.gbDraw = new System.Windows.Forms.GroupBox();
            this.rdbtnLine = new System.Windows.Forms.RadioButton();
            this.rdbtnUseCase = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.rdbtnActor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDraw)).BeginInit();
            this.gbDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBoxDraw
            // 
            this.PicBoxDraw.BackColor = System.Drawing.Color.White;
            this.PicBoxDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBoxDraw.Location = new System.Drawing.Point(12, 95);
            this.PicBoxDraw.Name = "PicBoxDraw";
            this.PicBoxDraw.Size = new System.Drawing.Size(791, 385);
            this.PicBoxDraw.TabIndex = 0;
            this.PicBoxDraw.TabStop = false;
            this.PicBoxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxDraw_Paint);
            this.PicBoxDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBoxDraw_MouseDown);
            // 
            // gbDraw
            // 
            this.gbDraw.Controls.Add(this.rdbtnActor);
            this.gbDraw.Controls.Add(this.rdbtnLine);
            this.gbDraw.Controls.Add(this.rdbtnUseCase);
            this.gbDraw.Location = new System.Drawing.Point(12, 12);
            this.gbDraw.Name = "gbDraw";
            this.gbDraw.Size = new System.Drawing.Size(205, 77);
            this.gbDraw.TabIndex = 1;
            this.gbDraw.TabStop = false;
            this.gbDraw.Text = "Draw";
            // 
            // rdbtnLine
            // 
            this.rdbtnLine.AutoSize = true;
            this.rdbtnLine.Location = new System.Drawing.Point(6, 48);
            this.rdbtnLine.Name = "rdbtnLine";
            this.rdbtnLine.Size = new System.Drawing.Size(56, 21);
            this.rdbtnLine.TabIndex = 3;
            this.rdbtnLine.Text = "Line";
            this.rdbtnLine.UseVisualStyleBackColor = true;
            // 
            // rdbtnUseCase
            // 
            this.rdbtnUseCase.AutoSize = true;
            this.rdbtnUseCase.Checked = true;
            this.rdbtnUseCase.Location = new System.Drawing.Point(6, 21);
            this.rdbtnUseCase.Name = "rdbtnUseCase";
            this.rdbtnUseCase.Size = new System.Drawing.Size(90, 21);
            this.rdbtnUseCase.TabIndex = 2;
            this.rdbtnUseCase.TabStop = true;
            this.rdbtnUseCase.Text = "Use Case";
            this.rdbtnUseCase.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(720, 57);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(83, 32);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // rdbtnActor
            // 
            this.rdbtnActor.AutoSize = true;
            this.rdbtnActor.Location = new System.Drawing.Point(126, 21);
            this.rdbtnActor.Name = "rdbtnActor";
            this.rdbtnActor.Size = new System.Drawing.Size(62, 21);
            this.rdbtnActor.TabIndex = 4;
            this.rdbtnActor.TabStop = true;
            this.rdbtnActor.Text = "Actor";
            this.rdbtnActor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 492);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbDraw);
            this.Controls.Add(this.PicBoxDraw);
            this.Name = "Form1";
            this.Text = "Use Case Helper";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDraw)).EndInit();
            this.gbDraw.ResumeLayout(false);
            this.gbDraw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxDraw;
        private System.Windows.Forms.GroupBox gbDraw;
        private System.Windows.Forms.RadioButton rdbtnLine;
        private System.Windows.Forms.RadioButton rdbtnUseCase;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton rdbtnActor;
    }
}

