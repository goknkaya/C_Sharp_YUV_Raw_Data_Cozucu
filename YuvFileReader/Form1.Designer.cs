namespace YuvFileReader
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
            this.cmbArraySize = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbYuv = new System.Windows.Forms.PictureBox();
            this.stickPlay = new System.Windows.Forms.HScrollBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timerScrool = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbYuv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbArraySize
            // 
            this.cmbArraySize.FormattingEnabled = true;
            this.cmbArraySize.Items.AddRange(new object[] {
            "4:2:0 qcif",
            "4:2:0 cif",
            "4:2:2",
            "4:4:4"});
            this.cmbArraySize.Location = new System.Drawing.Point(12, 12);
            this.cmbArraySize.Name = "cmbArraySize";
            this.cmbArraySize.Size = new System.Drawing.Size(348, 21);
            this.cmbArraySize.TabIndex = 0;
            this.cmbArraySize.Text = "Choose to Reference Array...";
            this.cmbArraySize.SelectedIndexChanged += new System.EventHandler(this.cmbArraySize_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(165, 39);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 46);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(59, 65);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(59, 39);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height :";
            // 
            // pbYuv
            // 
            this.pbYuv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbYuv.Location = new System.Drawing.Point(12, 91);
            this.pbYuv.Name = "pbYuv";
            this.pbYuv.Size = new System.Drawing.Size(563, 532);
            this.pbYuv.TabIndex = 6;
            this.pbYuv.TabStop = false;
            // 
            // stickPlay
            // 
            this.stickPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stickPlay.Location = new System.Drawing.Point(13, 626);
            this.stickPlay.Name = "stickPlay";
            this.stickPlay.Size = new System.Drawing.Size(562, 23);
            this.stickPlay.TabIndex = 7;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(232, 39);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 46);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timerScrool
            // 
            this.timerScrool.Tick += new System.EventHandler(this.timerScrool_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 46);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 664);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.stickPlay);
            this.Controls.Add(this.pbYuv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmbArraySize);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YUV PLAYER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbYuv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbArraySize;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbYuv;
        private System.Windows.Forms.HScrollBar stickPlay;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timerScrool;
        private System.Windows.Forms.Button btnClear;
    }
}

