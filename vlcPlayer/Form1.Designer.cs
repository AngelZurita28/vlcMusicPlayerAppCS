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
            this.components = new System.ComponentModel.Container();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.sbVolumen = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.btnMute = new System.Windows.Forms.Button();
            this.trackList = new System.Windows.Forms.ListBox();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(12, 12);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(696, 21);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            //this.vlcControl1.Visible = false;
            librarySetVlc();
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // btnGet
            // 
            this.btnGet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGet.Location = new System.Drawing.Point(136, 33);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Abrir";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.Location = new System.Drawing.Point(217, 33);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Reset";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.Location = new System.Drawing.Point(298, 33);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // txtSource
            // 
            this.txtSource.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSource.Location = new System.Drawing.Point(12, 34);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(118, 23);
            this.txtSource.TabIndex = 4;
            // 
            // sbVolumen
            // 
            this.sbVolumen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sbVolumen.Location = new System.Drawing.Point(457, 36);
            this.sbVolumen.Maximum = 200;
            this.sbVolumen.Name = "sbVolumen";
            this.sbVolumen.Size = new System.Drawing.Size(173, 18);
            this.sbVolumen.TabIndex = 5;
            this.sbVolumen.Value = 50;
            this.sbVolumen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVolume_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hScrollBar2.Location = new System.Drawing.Point(64, 62);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(592, 23);
            this.hScrollBar2.TabIndex = 6;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.White;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTime.Location = new System.Drawing.Point(12, 63);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(49, 21);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "00:00";
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.BackColor = System.Drawing.Color.White;
            this.lbTotalTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalTime.Location = new System.Drawing.Point(659, 64);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(49, 21);
            this.lbTotalTime.TabIndex = 8;
            this.lbTotalTime.Text = "00:00";
            // 
            // btnMute
            // 
            this.btnMute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMute.Location = new System.Drawing.Point(379, 33);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 23);
            this.btnMute.TabIndex = 10;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // trackList
            // 
            this.trackList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackList.FormattingEnabled = true;
            this.trackList.ItemHeight = 15;
            this.trackList.Location = new System.Drawing.Point(13, 92);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(696, 139);
            this.trackList.TabIndex = 11;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAleatorio.Location = new System.Drawing.Point(634, 92);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnAleatorio.TabIndex = 12;
            this.btnAleatorio.Text = "Shuffle";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSiguiente.Location = new System.Drawing.Point(634, 34);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(719, 240);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.lbTotalTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.sbVolumen);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.vlcControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Timer timer1;
        private Label lbTime;
        private Label lbTotalTime;
        private Button btnMute;
        private ListBox trackList;
        private Button btnAleatorio;
        private Button btnSiguiente;
    }
}