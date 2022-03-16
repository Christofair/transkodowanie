
namespace Transkodowanie
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
            this.btnPlikWej = new System.Windows.Forms.Button();
            this.btnPlikWyj = new System.Windows.Forms.Button();
            this.btnTranskoduj = new System.Windows.Forms.Button();
            this.tbKlatkiNaSekunde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWyborKodekaAudio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWyborKodekaWideo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWyborRozmiaruRamki = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPrzeplywnoscWideo = new System.Windows.Forms.NumericUpDown();
            this.nudPrzeplywnoscAudio = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelXX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrzeplywnoscWideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrzeplywnoscAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlikWej
            // 
            this.btnPlikWej.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlikWej.Location = new System.Drawing.Point(12, 198);
            this.btnPlikWej.Name = "btnPlikWej";
            this.btnPlikWej.Size = new System.Drawing.Size(80, 27);
            this.btnPlikWej.TabIndex = 0;
            this.btnPlikWej.Text = "Załaduj plik";
            this.btnPlikWej.UseVisualStyleBackColor = true;
            this.btnPlikWej.Click += new System.EventHandler(this.btnPlikWej_Click);
            // 
            // btnPlikWyj
            // 
            this.btnPlikWyj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlikWyj.Location = new System.Drawing.Point(253, 202);
            this.btnPlikWyj.Name = "btnPlikWyj";
            this.btnPlikWyj.Size = new System.Drawing.Size(97, 27);
            this.btnPlikWyj.TabIndex = 1;
            this.btnPlikWyj.Text = "Zapisz plik";
            this.btnPlikWyj.UseVisualStyleBackColor = true;
            this.btnPlikWyj.Click += new System.EventHandler(this.btnPlikWyj_Click);
            // 
            // btnTranskoduj
            // 
            this.btnTranskoduj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTranskoduj.Location = new System.Drawing.Point(500, 197);
            this.btnTranskoduj.Name = "btnTranskoduj";
            this.btnTranskoduj.Size = new System.Drawing.Size(80, 28);
            this.btnTranskoduj.TabIndex = 7;
            this.btnTranskoduj.Text = "Transkoduj";
            this.btnTranskoduj.UseVisualStyleBackColor = true;
            this.btnTranskoduj.Click += new System.EventHandler(this.btnTranskoduj_Click);
            // 
            // tbKlatkiNaSekunde
            // 
            this.tbKlatkiNaSekunde.Location = new System.Drawing.Point(160, 89);
            this.tbKlatkiNaSekunde.Name = "tbKlatkiNaSekunde";
            this.tbKlatkiNaSekunde.Size = new System.Drawing.Size(118, 23);
            this.tbKlatkiNaSekunde.TabIndex = 9;
            this.tbKlatkiNaSekunde.Text = "0";
            this.tbKlatkiNaSekunde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbKlatkiNaSekunde.Leave += new System.EventHandler(this.SprawdzFPS);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Liczba klatek na sekundę";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Przepływność audio (b/s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Przepływność wideo (b/s)";
            // 
            // cbWyborKodekaAudio
            // 
            this.cbWyborKodekaAudio.FormattingEnabled = true;
            this.cbWyborKodekaAudio.Items.AddRange(new object[] {
            "Bez zmian",
            "mp3",
            "a52"});
            this.cbWyborKodekaAudio.Location = new System.Drawing.Point(451, 9);
            this.cbWyborKodekaAudio.Name = "cbWyborKodekaAudio";
            this.cbWyborKodekaAudio.Size = new System.Drawing.Size(127, 23);
            this.cbWyborKodekaAudio.TabIndex = 3;
            this.cbWyborKodekaAudio.Text = "Bez zmian";
            this.cbWyborKodekaAudio.TextChanged += new System.EventHandler(this.ZmianaKodekaAudio);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kodek audio";
            // 
            // cbWyborKodekaWideo
            // 
            this.cbWyborKodekaWideo.Items.AddRange(new object[] {
            "Bez zmian",
            "mp1v",
            "h264",
            "WMV2"});
            this.cbWyborKodekaWideo.Location = new System.Drawing.Point(160, 9);
            this.cbWyborKodekaWideo.Name = "cbWyborKodekaWideo";
            this.cbWyborKodekaWideo.Size = new System.Drawing.Size(118, 23);
            this.cbWyborKodekaWideo.TabIndex = 1;
            this.cbWyborKodekaWideo.Text = "Bez zmian";
            this.cbWyborKodekaWideo.TextChanged += new System.EventHandler(this.ZmianaKodekaWideo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kodek wideo";
            // 
            // cbWyborRozmiaruRamki
            // 
            this.cbWyborRozmiaruRamki.FormattingEnabled = true;
            this.cbWyborRozmiaruRamki.Items.AddRange(new object[] {
            "Bez zmian",
            "Skalowanie",
            "Dokładne wymiary"});
            this.cbWyborRozmiaruRamki.Location = new System.Drawing.Point(190, 136);
            this.cbWyborRozmiaruRamki.Name = "cbWyborRozmiaruRamki";
            this.cbWyborRozmiaruRamki.Size = new System.Drawing.Size(123, 23);
            this.cbWyborRozmiaruRamki.TabIndex = 11;
            this.cbWyborRozmiaruRamki.Text = "Bez zmian";
            this.cbWyborRozmiaruRamki.TextChanged += new System.EventHandler(this.PokazPolaWejsciowe);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rodzaj zmiany wymiarów klatki";
            // 
            // nudPrzeplywnoscWideo
            // 
            this.nudPrzeplywnoscWideo.Location = new System.Drawing.Point(160, 46);
            this.nudPrzeplywnoscWideo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPrzeplywnoscWideo.Name = "nudPrzeplywnoscWideo";
            this.nudPrzeplywnoscWideo.Size = new System.Drawing.Size(120, 23);
            this.nudPrzeplywnoscWideo.TabIndex = 13;
            this.nudPrzeplywnoscWideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPrzeplywnoscAudio
            // 
            this.nudPrzeplywnoscAudio.Location = new System.Drawing.Point(458, 46);
            this.nudPrzeplywnoscAudio.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPrzeplywnoscAudio.Name = "nudPrzeplywnoscAudio";
            this.nudPrzeplywnoscAudio.Size = new System.Drawing.Size(120, 23);
            this.nudPrzeplywnoscAudio.TabIndex = 14;
            this.nudPrzeplywnoscAudio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Visible = false;
            this.textBox1.Leave += new System.EventHandler(this.SprawdzWartoscTb1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.Visible = false;
            this.textBox2.Leave += new System.EventHandler(this.SprawdzWartoscTb2);
            // 
            // labelXX
            // 
            this.labelXX.AutoSize = true;
            this.labelXX.Location = new System.Drawing.Point(451, 139);
            this.labelXX.Name = "labelXX";
            this.labelXX.Size = new System.Drawing.Size(14, 15);
            this.labelXX.TabIndex = 17;
            this.labelXX.Text = "X";
            this.labelXX.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 243);
            this.Controls.Add(this.labelXX);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nudPrzeplywnoscAudio);
            this.Controls.Add(this.nudPrzeplywnoscWideo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbWyborRozmiaruRamki);
            this.Controls.Add(this.btnTranskoduj);
            this.Controls.Add(this.btnPlikWyj);
            this.Controls.Add(this.tbKlatkiNaSekunde);
            this.Controls.Add(this.btnPlikWej);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWyborKodekaWideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbWyborKodekaAudio);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrzeplywnoscWideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrzeplywnoscAudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlikWej;
        private System.Windows.Forms.Button btnPlikWyj;
        private System.Windows.Forms.Button btnTranskoduj;
        private System.Windows.Forms.ComboBox cbWyborKodekaAudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWyborKodekaWideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKlatkiNaSekunde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbWyborRozmiaruRamki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPrzeplywnoscWideo;
        private System.Windows.Forms.NumericUpDown nudPrzeplywnoscAudio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelXX;
    }
}

