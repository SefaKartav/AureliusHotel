namespace denemeiconfalan
{
    partial class FormAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            ButtonRezervasyonYapYonlendir = new Button();
            ButtonKullaniciBilgileri = new Button();
            ButtonRezervasonIslemleriYonlendir = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ButtonRezervasyonYapYonlendir
            // 
            ButtonRezervasyonYapYonlendir.BackColor = Color.FromArgb(200, 255, 200);
            ButtonRezervasyonYapYonlendir.FlatStyle = FlatStyle.Popup;
            ButtonRezervasyonYapYonlendir.Font = new Font("Century", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ButtonRezervasyonYapYonlendir.ForeColor = Color.DarkGreen;
            ButtonRezervasyonYapYonlendir.Location = new Point(0, 0);
            ButtonRezervasyonYapYonlendir.Name = "ButtonRezervasyonYapYonlendir";
            ButtonRezervasyonYapYonlendir.Size = new Size(279, 49);
            ButtonRezervasyonYapYonlendir.TabIndex = 4;
            ButtonRezervasyonYapYonlendir.Text = "Rezervasyon Yap";
            ButtonRezervasyonYapYonlendir.UseVisualStyleBackColor = false;
            ButtonRezervasyonYapYonlendir.UseWaitCursor = true;
            ButtonRezervasyonYapYonlendir.Click += ButtonRezervasyonYapYonlendir_Click_1;
            // 
            // ButtonKullaniciBilgileri
            // 
            ButtonKullaniciBilgileri.Anchor = AnchorStyles.Top;
            ButtonKullaniciBilgileri.BackColor = Color.FromArgb(200, 255, 200);
            ButtonKullaniciBilgileri.FlatStyle = FlatStyle.Popup;
            ButtonKullaniciBilgileri.Font = new Font("Century", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ButtonKullaniciBilgileri.ForeColor = Color.DarkGreen;
            ButtonKullaniciBilgileri.Location = new Point(572, 0);
            ButtonKullaniciBilgileri.Name = "ButtonKullaniciBilgileri";
            ButtonKullaniciBilgileri.Size = new Size(279, 49);
            ButtonKullaniciBilgileri.TabIndex = 6;
            ButtonKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            ButtonKullaniciBilgileri.UseVisualStyleBackColor = false;
            ButtonKullaniciBilgileri.UseWaitCursor = true;
            ButtonKullaniciBilgileri.Click += ButtonKullaniciBilgileri_Click_1;
            // 
            // ButtonRezervasonIslemleriYonlendir
            // 
            ButtonRezervasonIslemleriYonlendir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonRezervasonIslemleriYonlendir.BackColor = Color.FromArgb(200, 255, 200);
            ButtonRezervasonIslemleriYonlendir.FlatStyle = FlatStyle.Popup;
            ButtonRezervasonIslemleriYonlendir.Font = new Font("Century", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ButtonRezervasonIslemleriYonlendir.ForeColor = Color.DarkGreen;
            ButtonRezervasonIslemleriYonlendir.Location = new Point(1142, 0);
            ButtonRezervasonIslemleriYonlendir.Name = "ButtonRezervasonIslemleriYonlendir";
            ButtonRezervasonIslemleriYonlendir.Size = new Size(279, 49);
            ButtonRezervasonIslemleriYonlendir.TabIndex = 7;
            ButtonRezervasonIslemleriYonlendir.Text = "Rezervasyonlarım";
            ButtonRezervasonIslemleriYonlendir.UseVisualStyleBackColor = false;
            ButtonRezervasonIslemleriYonlendir.UseWaitCursor = true;
            ButtonRezervasonIslemleriYonlendir.Click += ButtonRezervasonIslemleriYonlendir_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1421, 663);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.BackColor = Color.DarkOliveGreen;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Constantia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.OldLace;
            label2.Location = new Point(1142, 61);
            label2.Name = "label2";
            label2.Size = new Size(279, 602);
            label2.TabIndex = 26;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOliveGreen;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(0, 61);
            label1.Name = "label1";
            label1.Size = new Size(279, 602);
            label1.TabIndex = 27;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // FormAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1421, 663);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(ButtonRezervasonIslemleriYonlendir);
            Controls.Add(ButtonKullaniciBilgileri);
            Controls.Add(ButtonRezervasyonYapYonlendir);
            Controls.Add(pictureBox2);
            Font = new Font("Century Gothic", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAnaSayfa";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "FormAnaSayfa";
            UseWaitCursor = true;
            WindowState = FormWindowState.Maximized;
            Load += FormAnaSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ButtonRezervasyonYapYonlendir;
        private Button ButtonKullaniciBilgileri;
        private Button ButtonRezervasonIslemleriYonlendir;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}