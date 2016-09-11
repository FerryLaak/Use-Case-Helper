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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PicBoxDraw = new System.Windows.Forms.PictureBox();
            this.gbDraw = new System.Windows.Forms.GroupBox();
            this.rdbtnActor = new System.Windows.Forms.RadioButton();
            this.rdbtnLine = new System.Windows.Forms.RadioButton();
            this.rdbtnUseCase = new System.Windows.Forms.RadioButton();
            this.txtbActor = new System.Windows.Forms.TextBox();
            this.lblNaamActor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDraw)).BeginInit();
            this.gbDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxDraw
            // 
            this.PicBoxDraw.BackColor = System.Drawing.Color.White;
            this.PicBoxDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBoxDraw.Location = new System.Drawing.Point(12, 95);
            this.PicBoxDraw.Name = "PicBoxDraw";
            this.PicBoxDraw.Size = new System.Drawing.Size(1236, 661);
            this.PicBoxDraw.TabIndex = 0;
            this.PicBoxDraw.TabStop = false;
            this.PicBoxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoxDraw_Paint);
            this.PicBoxDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBoxDraw_MouseDown);
            this.PicBoxDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicBoxDraw_MouseUp);
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
            this.rdbtnActor.CheckedChanged += new System.EventHandler(this.rdbtnActor_CheckedChanged);
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
            // txtbActor
            // 
            this.txtbActor.Location = new System.Drawing.Point(312, 60);
            this.txtbActor.Name = "txtbActor";
            this.txtbActor.Size = new System.Drawing.Size(225, 22);
            this.txtbActor.TabIndex = 3;
            // 
            // lblNaamActor
            // 
            this.lblNaamActor.AutoSize = true;
            this.lblNaamActor.Location = new System.Drawing.Point(220, 62);
            this.lblNaamActor.Name = "lblNaamActor";
            this.lblNaamActor.Size = new System.Drawing.Size(86, 17);
            this.lblNaamActor.TabIndex = 4;
            this.lblNaamActor.Text = "Naam Actor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 22);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1064, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNaamActor);
            this.Controls.Add(this.txtbActor);
            this.Controls.Add(this.gbDraw);
            this.Controls.Add(this.PicBoxDraw);
            this.Name = "Form1";
            this.Text = "Use Case Helper";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDraw)).EndInit();
            this.gbDraw.ResumeLayout(false);
            this.gbDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxDraw;
        private System.Windows.Forms.GroupBox gbDraw;
        private System.Windows.Forms.RadioButton rdbtnLine;
        private System.Windows.Forms.RadioButton rdbtnUseCase;
        private System.Windows.Forms.RadioButton rdbtnActor;
        private System.Windows.Forms.TextBox txtbActor;
        private System.Windows.Forms.Label lblNaamActor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

