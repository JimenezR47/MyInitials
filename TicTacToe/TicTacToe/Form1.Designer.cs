namespace TicTacToe
{
    partial class TicTacToe
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
         this.bReset = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.pb00 = new System.Windows.Forms.PictureBox();
         this.pb01 = new System.Windows.Forms.PictureBox();
         this.pb02 = new System.Windows.Forms.PictureBox();
         this.pb22 = new System.Windows.Forms.PictureBox();
         this.pb21 = new System.Windows.Forms.PictureBox();
         this.pb20 = new System.Windows.Forms.PictureBox();
         this.pb12 = new System.Windows.Forms.PictureBox();
         this.pb11 = new System.Windows.Forms.PictureBox();
         this.pb10 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb00)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb01)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb02)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb22)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb21)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
         this.SuspendLayout();
         // 
         // bReset
         // 
         this.bReset.Location = new System.Drawing.Point(266, 405);
         this.bReset.Name = "bReset";
         this.bReset.Size = new System.Drawing.Size(75, 23);
         this.bReset.TabIndex = 10;
         this.bReset.Text = "Reset";
         this.bReset.UseVisualStyleBackColor = true;
         this.bReset.Click += new System.EventHandler(this.bReset_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(0, 0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(607, 611);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // pb00
         // 
         this.pb00.Location = new System.Drawing.Point(12, 17);
         this.pb00.MaximumSize = new System.Drawing.Size(152, 152);
         this.pb00.MinimumSize = new System.Drawing.Size(152, 152);
         this.pb00.Name = "pb00";
         this.pb00.Size = new System.Drawing.Size(152, 152);
         this.pb00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pb00.TabIndex = 20;
         this.pb00.TabStop = false;
         this.pb00.Tag = "00";
         this.pb00.Click += new System.EventHandler(this.AssignImage);
         // 
         // pb01
         // 
         this.pb01.Location = new System.Drawing.Point(228, 17);
         this.pb01.MaximumSize = new System.Drawing.Size(152, 152);
         this.pb01.MinimumSize = new System.Drawing.Size(152, 152);
         this.pb01.Name = "pb01";
         this.pb01.Size = new System.Drawing.Size(152, 152);
         this.pb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pb01.TabIndex = 21;
         this.pb01.TabStop = false;
         this.pb01.Tag = "01";
         this.pb01.Click += new System.EventHandler(this.AssignImage);
         // 
         // pb02
         // 
         this.pb02.Location = new System.Drawing.Point(442, 17);
         this.pb02.MaximumSize = new System.Drawing.Size(152, 152);
         this.pb02.MinimumSize = new System.Drawing.Size(152, 152);
         this.pb02.Name = "pb02";
         this.pb02.Size = new System.Drawing.Size(152, 152);
         this.pb02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pb02.TabIndex = 22;
         this.pb02.TabStop = false;
         this.pb02.Tag = "02";
         this.pb02.Click += new System.EventHandler(this.AssignImage);
         // 
         // pb22
         // 
         this.pb22.Location = new System.Drawing.Point(442, 446);
         this.pb22.MaximumSize = new System.Drawing.Size(152, 152);
         this.pb22.MinimumSize = new System.Drawing.Size(152, 152);
         this.pb22.Name = "pb22";
         this.pb22.Size = new System.Drawing.Size(152, 152);
         this.pb22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pb22.TabIndex = 25;
         this.pb22.TabStop = false;
         this.pb22.Tag = "22";
         this.pb22.Click += new System.EventHandler(this.AssignImage);
         // 
         // pb21
         // 
         this.pb21.Location = new System.Drawing.Point(228, 446);
         this.pb21.MaximumSize = new System.Drawing.Size(152, 152);
         this.pb21.MinimumSize = new System.Drawing.Size(152, 152);
         this.pb21.Name = "pb21";
         this.pb21.Size = new System.Drawing.Size(152, 152);
         this.pb21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pb21.TabIndex = 24;
         this.pb21.TabStop = false;
         this.pb21.Tag = "21";
         this.pb21.Click += new System.EventHandler(this.AssignImage);
         // 
         // pb20
         // 
         this.pb20.Location = new System.Drawing.Point(12, 446);
         this.pb20.MaximumSize = new System.Drawing.Size(152, 152);
         this.pb20.MinimumSize = new System.Drawing.Size(152, 152);
         this.pb20.Name = "pb20";
         this.pb20.Size = new System.Drawing.Size(152, 152);
         this.pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pb20.TabIndex = 23;
         this.pb20.TabStop = false;
         this.pb20.Tag = "20";
         this.pb20.Click += new System.EventHandler(this.AssignImage);
         // 
         // pb12
         // 
         this.pb12.Location = new System.Drawing.Point(442, 238);
         this.pb12.MaximumSize = new System.Drawing.Size(152, 152);
         this.pb12.MinimumSize = new System.Drawing.Size(152, 152);
         this.pb12.Name = "pb12";
         this.pb12.Size = new System.Drawing.Size(152, 152);
         this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pb12.TabIndex = 28;
         this.pb12.TabStop = false;
         this.pb12.Tag = "12";
         this.pb12.Click += new System.EventHandler(this.AssignImage);
         // 
         // pb11
         // 
         this.pb11.Location = new System.Drawing.Point(228, 238);
         this.pb11.MaximumSize = new System.Drawing.Size(152, 152);
         this.pb11.MinimumSize = new System.Drawing.Size(152, 152);
         this.pb11.Name = "pb11";
         this.pb11.Size = new System.Drawing.Size(152, 152);
         this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pb11.TabIndex = 27;
         this.pb11.TabStop = false;
         this.pb11.Tag = "11";
         this.pb11.Click += new System.EventHandler(this.AssignImage);
         // 
         // pb10
         // 
         this.pb10.Location = new System.Drawing.Point(12, 238);
         this.pb10.MaximumSize = new System.Drawing.Size(152, 152);
         this.pb10.MinimumSize = new System.Drawing.Size(152, 152);
         this.pb10.Name = "pb10";
         this.pb10.Size = new System.Drawing.Size(152, 152);
         this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pb10.TabIndex = 26;
         this.pb10.TabStop = false;
         this.pb10.Tag = "10";
         this.pb10.Click += new System.EventHandler(this.AssignImage);
         // 
         // TicTacToe
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(606, 609);
         this.Controls.Add(this.pb12);
         this.Controls.Add(this.pb11);
         this.Controls.Add(this.pb10);
         this.Controls.Add(this.pb22);
         this.Controls.Add(this.pb21);
         this.Controls.Add(this.pb20);
         this.Controls.Add(this.pb02);
         this.Controls.Add(this.pb01);
         this.Controls.Add(this.pb00);
         this.Controls.Add(this.bReset);
         this.Controls.Add(this.pictureBox1);
         this.Name = "TicTacToe";
         this.Text = "Tic-Tac-Toe";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb00)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb01)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb02)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb22)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb21)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.PictureBox pb00;
      private System.Windows.Forms.PictureBox pb01;
      private System.Windows.Forms.PictureBox pb02;
      private System.Windows.Forms.PictureBox pb22;
      private System.Windows.Forms.PictureBox pb21;
      private System.Windows.Forms.PictureBox pb20;
      private System.Windows.Forms.PictureBox pb12;
      private System.Windows.Forms.PictureBox pb11;
      private System.Windows.Forms.PictureBox pb10;
   }
}

