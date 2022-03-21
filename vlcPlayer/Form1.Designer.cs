namespace vlcPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.sbVolumen = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(117, 47);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(197, 148);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = this.vlcControl1.VlcLibDirectory = new DirectoryInfo(Path.Combine(Name, @"C:\Users\af339\.nuget\packages\videolan.libvlc.windows\3.0.16\build\x64"));
            ;
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(50, 212);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "button1";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(169, 212);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "button2";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(290, 212);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "button3";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(50, 253);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(177, 23);
            this.txtSource.TabIndex = 4;
            // 
            // sbVolumen
            // 
            this.sbVolumen.Location = new System.Drawing.Point(276, 259);
            this.sbVolumen.Name = "sbVolumen";
            this.sbVolumen.Size = new System.Drawing.Size(122, 17);
            this.sbVolumen.TabIndex = 5;
            this.sbVolumen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVolume_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(50, 314);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(378, 23);
            this.hScrollBar2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 393);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.sbVolumen);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.vlcControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private Button btnGet;
        private Button btnPlay;
        private Button btnPause;
        private TextBox txtSource;
        private HScrollBar sbVolumen;
        private HScrollBar hScrollBar2;
    }
}