namespace SwapListBoxValues
{
    partial class SwapBox
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
            this.lbGenerate50 = new System.Windows.Forms.ListBox();
            this.lbGenerate10 = new System.Windows.Forms.ListBox();
            this.bGenerate50 = new System.Windows.Forms.Button();
            this.bSwap = new System.Windows.Forms.Button();
            this.bGenerate10 = new System.Windows.Forms.Button();
            this.bSave50 = new System.Windows.Forms.Button();
            this.bLoad50 = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bSave10 = new System.Windows.Forms.Button();
            this.bLoad10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGenerate50
            // 
            this.lbGenerate50.FormattingEnabled = true;
            this.lbGenerate50.Location = new System.Drawing.Point(12, 12);
            this.lbGenerate50.Name = "lbGenerate50";
            this.lbGenerate50.Size = new System.Drawing.Size(120, 420);
            this.lbGenerate50.TabIndex = 0;
            // 
            // lbGenerate10
            // 
            this.lbGenerate10.FormattingEnabled = true;
            this.lbGenerate10.Location = new System.Drawing.Point(219, 12);
            this.lbGenerate10.Name = "lbGenerate10";
            this.lbGenerate10.Size = new System.Drawing.Size(120, 420);
            this.lbGenerate10.TabIndex = 1;
            // 
            // bGenerate50
            // 
            this.bGenerate50.Location = new System.Drawing.Point(138, 12);
            this.bGenerate50.Name = "bGenerate50";
            this.bGenerate50.Size = new System.Drawing.Size(75, 23);
            this.bGenerate50.TabIndex = 2;
            this.bGenerate50.Text = "Generate 50";
            this.bGenerate50.UseVisualStyleBackColor = true;
            this.bGenerate50.Click += new System.EventHandler(this.bGenerate50_Click);
            // 
            // bSwap
            // 
            this.bSwap.Enabled = false;
            this.bSwap.Location = new System.Drawing.Point(138, 70);
            this.bSwap.Name = "bSwap";
            this.bSwap.Size = new System.Drawing.Size(75, 23);
            this.bSwap.TabIndex = 3;
            this.bSwap.Text = "Swap";
            this.bSwap.UseVisualStyleBackColor = true;
            this.bSwap.Click += new System.EventHandler(this.bSwap_Click);
            // 
            // bGenerate10
            // 
            this.bGenerate10.Enabled = false;
            this.bGenerate10.Location = new System.Drawing.Point(138, 41);
            this.bGenerate10.Name = "bGenerate10";
            this.bGenerate10.Size = new System.Drawing.Size(75, 23);
            this.bGenerate10.TabIndex = 4;
            this.bGenerate10.Text = "Generate 10";
            this.bGenerate10.UseVisualStyleBackColor = true;
            this.bGenerate10.Click += new System.EventHandler(this.bGenerate10_Click);
            // 
            // bSave50
            // 
            this.bSave50.Enabled = false;
            this.bSave50.Location = new System.Drawing.Point(138, 119);
            this.bSave50.Name = "bSave50";
            this.bSave50.Size = new System.Drawing.Size(75, 23);
            this.bSave50.TabIndex = 5;
            this.bSave50.Text = "Save 50";
            this.bSave50.UseVisualStyleBackColor = true;
            this.bSave50.Click += new System.EventHandler(this.bSave50_Click);
            // 
            // bLoad50
            // 
            this.bLoad50.Enabled = false;
            this.bLoad50.Location = new System.Drawing.Point(138, 201);
            this.bLoad50.Name = "bLoad50";
            this.bLoad50.Size = new System.Drawing.Size(75, 23);
            this.bLoad50.TabIndex = 6;
            this.bLoad50.Text = "Load 50";
            this.bLoad50.UseVisualStyleBackColor = true;
            this.bLoad50.Click += new System.EventHandler(this.bLoad50_Click);
            // 
            // bClear
            // 
            this.bClear.Enabled = false;
            this.bClear.Location = new System.Drawing.Point(138, 409);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 7;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // bSave10
            // 
            this.bSave10.Enabled = false;
            this.bSave10.Location = new System.Drawing.Point(138, 148);
            this.bSave10.Name = "bSave10";
            this.bSave10.Size = new System.Drawing.Size(75, 23);
            this.bSave10.TabIndex = 8;
            this.bSave10.Text = "Save 10";
            this.bSave10.UseVisualStyleBackColor = true;
            this.bSave10.Click += new System.EventHandler(this.bSave10_Click);
            // 
            // bLoad10
            // 
            this.bLoad10.Enabled = false;
            this.bLoad10.Location = new System.Drawing.Point(138, 230);
            this.bLoad10.Name = "bLoad10";
            this.bLoad10.Size = new System.Drawing.Size(75, 23);
            this.bLoad10.TabIndex = 9;
            this.bLoad10.Text = "Load 10";
            this.bLoad10.UseVisualStyleBackColor = true;
            this.bLoad10.Click += new System.EventHandler(this.bLoad10_Click);
            // 
            // SwapBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.bLoad10);
            this.Controls.Add(this.bSave10);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bLoad50);
            this.Controls.Add(this.bSave50);
            this.Controls.Add(this.bGenerate10);
            this.Controls.Add(this.bSwap);
            this.Controls.Add(this.bGenerate50);
            this.Controls.Add(this.lbGenerate10);
            this.Controls.Add(this.lbGenerate50);
            this.Name = "SwapBox";
            this.Text = "Swap Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbGenerate50;
        private System.Windows.Forms.ListBox lbGenerate10;
        private System.Windows.Forms.Button bGenerate50;
        private System.Windows.Forms.Button bSwap;
        private System.Windows.Forms.Button bGenerate10;
        private System.Windows.Forms.Button bSave50;
        private System.Windows.Forms.Button bLoad50;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button bSave10;
        private System.Windows.Forms.Button bLoad10;
    }
}

