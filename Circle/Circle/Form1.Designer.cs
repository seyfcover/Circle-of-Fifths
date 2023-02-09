namespace Circle
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Positions = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowBut = new System.Windows.Forms.Button();
            this.Scales = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notalar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Chords = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.Label();
            this.potenchord = new System.Windows.Forms.Label();
            this.option = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.f2 = new System.Windows.Forms.ComboBox();
            this.f3 = new System.Windows.Forms.ComboBox();
            this.f4 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Positions)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Linen;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
            this.listBox1.Location = new System.Drawing.Point(46, 90);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 228);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scales :";
            // 
            // Positions
            // 
            this.Positions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Positions.BackgroundImage")));
            this.Positions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Positions.Location = new System.Drawing.Point(481, 90);
            this.Positions.Name = "Positions";
            this.Positions.Size = new System.Drawing.Size(871, 194);
            this.Positions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Positions.TabIndex = 5;
            this.Positions.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1229, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Guitar Positions";
            // 
            // ShowBut
            // 
            this.ShowBut.BackColor = System.Drawing.SystemColors.Control;
            this.ShowBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowBut.Location = new System.Drawing.Point(46, 340);
            this.ShowBut.Name = "ShowBut";
            this.ShowBut.Size = new System.Drawing.Size(139, 45);
            this.ShowBut.TabIndex = 6;
            this.ShowBut.Text = "Show";
            this.ShowBut.UseVisualStyleBackColor = false;
            this.ShowBut.Click += new System.EventHandler(this.ShowBut_Click);
            // 
            // Scales
            // 
            this.Scales.BackColor = System.Drawing.SystemColors.Control;
            this.Scales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Scales.FormattingEnabled = true;
            this.Scales.ItemHeight = 19;
            this.Scales.Location = new System.Drawing.Point(211, 90);
            this.Scales.Name = "Scales";
            this.Scales.Size = new System.Drawing.Size(112, 194);
            this.Scales.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(280, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notes :";
            // 
            // notalar
            // 
            this.notalar.BackColor = System.Drawing.Color.Transparent;
            this.notalar.ForeColor = System.Drawing.Color.Black;
            this.notalar.Location = new System.Drawing.Point(357, 290);
            this.notalar.Name = "notalar";
            this.notalar.Size = new System.Drawing.Size(90, 30);
            this.notalar.TabIndex = 9;
            this.notalar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(342, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Available Chords ";
            // 
            // Chords
            // 
            this.Chords.BackColor = System.Drawing.Color.SaddleBrown;
            this.Chords.ForeColor = System.Drawing.Color.White;
            this.Chords.FormattingEnabled = true;
            this.Chords.ItemHeight = 19;
            this.Chords.Location = new System.Drawing.Point(346, 90);
            this.Chords.Name = "Chords";
            this.Chords.Size = new System.Drawing.Size(112, 194);
            this.Chords.TabIndex = 10;
            this.Chords.SelectedIndexChanged += new System.EventHandler(this.Chords_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(207, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Scales";
            // 
            // pc
            // 
            this.pc.AutoSize = true;
            this.pc.BackColor = System.Drawing.Color.Transparent;
            this.pc.ForeColor = System.Drawing.Color.Black;
            this.pc.Location = new System.Drawing.Point(477, 310);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(153, 19);
            this.pc.TabIndex = 13;
            this.pc.Text = "Chord Progressions";
            // 
            // potenchord
            // 
            this.potenchord.AutoSize = true;
            this.potenchord.BackColor = System.Drawing.Color.Transparent;
            this.potenchord.Location = new System.Drawing.Point(636, 310);
            this.potenchord.Name = "potenchord";
            this.potenchord.Size = new System.Drawing.Size(0, 19);
            this.potenchord.TabIndex = 14;
            // 
            // option
            // 
            this.option.FormattingEnabled = true;
            this.option.Items.AddRange(new object[] {
            "Major",
            "Minör",
            "Harmonic Minör",
            "Melodic Minör"});
            this.option.Location = new System.Drawing.Point(46, 55);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(139, 27);
            this.option.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(200, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Backing Track:";
            // 
            // f1
            // 
            this.f1.FormattingEnabled = true;
            this.f1.Items.AddRange(new object[] {
            "A",
            "Am",
            "B",
            "Bm",
            "C",
            "Cm",
            "D",
            "Dm",
            "E",
            "Em",
            "F",
            "Fm",
            "G",
            "Gm",
            "Bb",
            "Bbm",
            "Cm",
            "Dbm",
            "Gb",
            "Gbm"});
            this.f1.Location = new System.Drawing.Point(329, 350);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(52, 27);
            this.f1.TabIndex = 17;
            // 
            // Start
            // 
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(608, 346);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(118, 39);
            this.Start.TabIndex = 21;
            this.Start.Text = "Play";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // f2
            // 
            this.f2.FormattingEnabled = true;
            this.f2.Items.AddRange(new object[] {
            "A",
            "Am",
            "B",
            "Bm",
            "C",
            "Cm",
            "D",
            "Dm",
            "E",
            "Em",
            "F",
            "Fm",
            "G",
            "Gm",
            "Bb",
            "Bbm",
            "Cm",
            "Dbm",
            "Gb",
            "Gbm"});
            this.f2.Location = new System.Drawing.Point(395, 350);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(52, 27);
            this.f2.TabIndex = 22;
            // 
            // f3
            // 
            this.f3.FormattingEnabled = true;
            this.f3.Items.AddRange(new object[] {
            "A",
            "Am",
            "B",
            "Bm",
            "C",
            "Cm",
            "D",
            "Dm",
            "E",
            "Em",
            "F",
            "Fm",
            "G",
            "Gm",
            "Bb",
            "Bbm",
            "Cm",
            "Dbm",
            "Gb",
            "Gbm"});
            this.f3.Location = new System.Drawing.Point(463, 350);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(52, 27);
            this.f3.TabIndex = 23;
            // 
            // f4
            // 
            this.f4.FormattingEnabled = true;
            this.f4.Items.AddRange(new object[] {
            "A",
            "Am",
            "B",
            "Bm",
            "C",
            "Cm",
            "D",
            "Dm",
            "E",
            "Em",
            "F",
            "Fm",
            "G",
            "Gm",
            "Bb",
            "Bbm",
            "Cm",
            "Dbm",
            "Gb",
            "Gbm"});
            this.f4.Location = new System.Drawing.Point(531, 350);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(52, 27);
            this.f4.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Interval = 2350;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1402, 453);
            this.Controls.Add(this.f4);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.option);
            this.Controls.Add(this.potenchord);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chords);
            this.Controls.Add(this.notalar);
            this.Controls.Add(this.Scales);
            this.Controls.Add(this.ShowBut);
            this.Controls.Add(this.Positions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Positions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Positions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowBut;
        private System.Windows.Forms.ListBox Scales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label notalar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Chords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pc;
        private System.Windows.Forms.Label potenchord;
        private System.Windows.Forms.ComboBox option;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox f1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ComboBox f2;
        private System.Windows.Forms.ComboBox f3;
        private System.Windows.Forms.ComboBox f4;
        private System.Windows.Forms.Timer timer1;
    }
}

