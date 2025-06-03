namespace denemeiconfalan
{
    partial class FormKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKayit));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ButtonKayitOl = new Button();
            ArtikolKullaniciAdi = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ArtikolSifre = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ArtikolTc = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ArtikolEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1478, 656);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.BackColor = Color.DarkOliveGreen;
            label3.Font = new Font("Century", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.OldLace;
            label3.Location = new Point(520, 257);
            label3.Name = "label3";
            label3.Size = new Size(83, 48);
            label3.TabIndex = 32;
            label3.Text = "Sifre :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.BackColor = Color.DarkOliveGreen;
            label4.Font = new Font("Century", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.OldLace;
            label4.Location = new Point(430, 194);
            label4.Name = "label4";
            label4.Size = new Size(173, 48);
            label4.TabIndex = 31;
            label4.Text = "Kullanici Adi :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.BackColor = Color.DarkOliveGreen;
            label5.Font = new Font("Century", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.OldLace;
            label5.Location = new Point(516, 317);
            label5.Name = "label5";
            label5.Size = new Size(87, 48);
            label5.TabIndex = 33;
            label5.Text = "TCNo :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.BackColor = Color.DarkOliveGreen;
            label6.Font = new Font("Century", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.OldLace;
            label6.Location = new Point(505, 379);
            label6.Name = "label6";
            label6.Size = new Size(98, 48);
            label6.TabIndex = 34;
            label6.Text = "EMail :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.UseWaitCursor = true;
            // 
            // ButtonKayitOl
            // 
            ButtonKayitOl.Anchor = AnchorStyles.Top;
            ButtonKayitOl.BackColor = Color.DarkOliveGreen;
            ButtonKayitOl.Font = new Font("Century", 9.75F, FontStyle.Bold | FontStyle.Italic);
            ButtonKayitOl.ForeColor = Color.OldLace;
            ButtonKayitOl.Location = new Point(658, 442);
            ButtonKayitOl.Name = "ButtonKayitOl";
            ButtonKayitOl.Size = new Size(223, 26);
            ButtonKayitOl.TabIndex = 39;
            ButtonKayitOl.Text = "Kayit Ol";
            ButtonKayitOl.UseVisualStyleBackColor = false;
            ButtonKayitOl.UseWaitCursor = true;
            ButtonKayitOl.Click += ButtonKayitOl_Click_1;
            // 
            // ArtikolKullaniciAdi
            // 
            ArtikolKullaniciAdi.AllowPromptAsInput = true;
            ArtikolKullaniciAdi.Anchor = AnchorStyles.Top;
            ArtikolKullaniciAdi.AnimateReadOnly = false;
            ArtikolKullaniciAdi.AsciiOnly = false;
            ArtikolKullaniciAdi.BackgroundImageLayout = ImageLayout.None;
            ArtikolKullaniciAdi.BeepOnError = false;
            ArtikolKullaniciAdi.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            ArtikolKullaniciAdi.Depth = 0;
            ArtikolKullaniciAdi.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ArtikolKullaniciAdi.HidePromptOnLeave = false;
            ArtikolKullaniciAdi.HideSelection = true;
            ArtikolKullaniciAdi.InsertKeyMode = InsertKeyMode.Default;
            ArtikolKullaniciAdi.LeadingIcon = null;
            ArtikolKullaniciAdi.Location = new Point(609, 194);
            ArtikolKullaniciAdi.Mask = "";
            ArtikolKullaniciAdi.MaxLength = 32767;
            ArtikolKullaniciAdi.MouseState = MaterialSkin.MouseState.OUT;
            ArtikolKullaniciAdi.Name = "ArtikolKullaniciAdi";
            ArtikolKullaniciAdi.PasswordChar = '\0';
            ArtikolKullaniciAdi.PrefixSuffixText = null;
            ArtikolKullaniciAdi.PromptChar = '_';
            ArtikolKullaniciAdi.ReadOnly = false;
            ArtikolKullaniciAdi.RejectInputOnFirstFailure = false;
            ArtikolKullaniciAdi.ResetOnPrompt = true;
            ArtikolKullaniciAdi.ResetOnSpace = true;
            ArtikolKullaniciAdi.RightToLeft = RightToLeft.No;
            ArtikolKullaniciAdi.SelectedText = "";
            ArtikolKullaniciAdi.SelectionLength = 0;
            ArtikolKullaniciAdi.SelectionStart = 0;
            ArtikolKullaniciAdi.ShortcutsEnabled = true;
            ArtikolKullaniciAdi.Size = new Size(317, 48);
            ArtikolKullaniciAdi.SkipLiterals = true;
            ArtikolKullaniciAdi.TabIndex = 40;
            ArtikolKullaniciAdi.TabStop = false;
            ArtikolKullaniciAdi.TextAlign = HorizontalAlignment.Left;
            ArtikolKullaniciAdi.TextMaskFormat = MaskFormat.IncludeLiterals;
            ArtikolKullaniciAdi.TrailingIcon = null;
            ArtikolKullaniciAdi.UseSystemPasswordChar = false;
            ArtikolKullaniciAdi.UseWaitCursor = true;
            ArtikolKullaniciAdi.ValidatingType = null;
            ArtikolKullaniciAdi.Click += ArtikolKullaniciAdi_Click;
            // 
            // ArtikolSifre
            // 
            ArtikolSifre.AllowPromptAsInput = true;
            ArtikolSifre.Anchor = AnchorStyles.Top;
            ArtikolSifre.AnimateReadOnly = false;
            ArtikolSifre.AsciiOnly = false;
            ArtikolSifre.BackgroundImageLayout = ImageLayout.None;
            ArtikolSifre.BeepOnError = false;
            ArtikolSifre.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            ArtikolSifre.Depth = 0;
            ArtikolSifre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ArtikolSifre.HidePromptOnLeave = false;
            ArtikolSifre.HideSelection = true;
            ArtikolSifre.InsertKeyMode = InsertKeyMode.Default;
            ArtikolSifre.LeadingIcon = null;
            ArtikolSifre.Location = new Point(609, 257);
            ArtikolSifre.Mask = "";
            ArtikolSifre.MaxLength = 32767;
            ArtikolSifre.MouseState = MaterialSkin.MouseState.OUT;
            ArtikolSifre.Name = "ArtikolSifre";
            ArtikolSifre.PasswordChar = '\0';
            ArtikolSifre.PrefixSuffixText = null;
            ArtikolSifre.PromptChar = '_';
            ArtikolSifre.ReadOnly = false;
            ArtikolSifre.RejectInputOnFirstFailure = false;
            ArtikolSifre.ResetOnPrompt = true;
            ArtikolSifre.ResetOnSpace = true;
            ArtikolSifre.RightToLeft = RightToLeft.No;
            ArtikolSifre.SelectedText = "";
            ArtikolSifre.SelectionLength = 0;
            ArtikolSifre.SelectionStart = 0;
            ArtikolSifre.ShortcutsEnabled = true;
            ArtikolSifre.Size = new Size(317, 48);
            ArtikolSifre.SkipLiterals = true;
            ArtikolSifre.TabIndex = 41;
            ArtikolSifre.TabStop = false;
            ArtikolSifre.TextAlign = HorizontalAlignment.Left;
            ArtikolSifre.TextMaskFormat = MaskFormat.IncludeLiterals;
            ArtikolSifre.TrailingIcon = null;
            ArtikolSifre.UseSystemPasswordChar = false;
            ArtikolSifre.UseWaitCursor = true;
            ArtikolSifre.ValidatingType = null;
            ArtikolSifre.Click += ArtikolSifre_Click;
            // 
            // ArtikolTc
            // 
            ArtikolTc.AllowPromptAsInput = true;
            ArtikolTc.Anchor = AnchorStyles.Top;
            ArtikolTc.AnimateReadOnly = false;
            ArtikolTc.AsciiOnly = false;
            ArtikolTc.BackgroundImageLayout = ImageLayout.None;
            ArtikolTc.BeepOnError = false;
            ArtikolTc.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            ArtikolTc.Depth = 0;
            ArtikolTc.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ArtikolTc.HidePromptOnLeave = false;
            ArtikolTc.HideSelection = true;
            ArtikolTc.InsertKeyMode = InsertKeyMode.Default;
            ArtikolTc.LeadingIcon = null;
            ArtikolTc.Location = new Point(609, 317);
            ArtikolTc.Mask = "";
            ArtikolTc.MaxLength = 32767;
            ArtikolTc.MouseState = MaterialSkin.MouseState.OUT;
            ArtikolTc.Name = "ArtikolTc";
            ArtikolTc.PasswordChar = '\0';
            ArtikolTc.PrefixSuffixText = null;
            ArtikolTc.PromptChar = '_';
            ArtikolTc.ReadOnly = false;
            ArtikolTc.RejectInputOnFirstFailure = false;
            ArtikolTc.ResetOnPrompt = true;
            ArtikolTc.ResetOnSpace = true;
            ArtikolTc.RightToLeft = RightToLeft.No;
            ArtikolTc.SelectedText = "";
            ArtikolTc.SelectionLength = 0;
            ArtikolTc.SelectionStart = 0;
            ArtikolTc.ShortcutsEnabled = true;
            ArtikolTc.Size = new Size(317, 48);
            ArtikolTc.SkipLiterals = true;
            ArtikolTc.TabIndex = 42;
            ArtikolTc.TabStop = false;
            ArtikolTc.TextAlign = HorizontalAlignment.Left;
            ArtikolTc.TextMaskFormat = MaskFormat.IncludeLiterals;
            ArtikolTc.TrailingIcon = null;
            ArtikolTc.UseSystemPasswordChar = false;
            ArtikolTc.UseWaitCursor = true;
            ArtikolTc.ValidatingType = null;
            ArtikolTc.Click += ArtikolTc_Click;
            // 
            // ArtikolEmail
            // 
            ArtikolEmail.AllowPromptAsInput = true;
            ArtikolEmail.Anchor = AnchorStyles.Top;
            ArtikolEmail.AnimateReadOnly = false;
            ArtikolEmail.AsciiOnly = false;
            ArtikolEmail.BackgroundImageLayout = ImageLayout.None;
            ArtikolEmail.BeepOnError = false;
            ArtikolEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            ArtikolEmail.Depth = 0;
            ArtikolEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ArtikolEmail.HidePromptOnLeave = false;
            ArtikolEmail.HideSelection = true;
            ArtikolEmail.InsertKeyMode = InsertKeyMode.Default;
            ArtikolEmail.LeadingIcon = null;
            ArtikolEmail.Location = new Point(609, 379);
            ArtikolEmail.Mask = "";
            ArtikolEmail.MaxLength = 32767;
            ArtikolEmail.MouseState = MaterialSkin.MouseState.OUT;
            ArtikolEmail.Name = "ArtikolEmail";
            ArtikolEmail.PasswordChar = '\0';
            ArtikolEmail.PrefixSuffixText = null;
            ArtikolEmail.PromptChar = '_';
            ArtikolEmail.ReadOnly = false;
            ArtikolEmail.RejectInputOnFirstFailure = false;
            ArtikolEmail.ResetOnPrompt = true;
            ArtikolEmail.ResetOnSpace = true;
            ArtikolEmail.RightToLeft = RightToLeft.No;
            ArtikolEmail.SelectedText = "";
            ArtikolEmail.SelectionLength = 0;
            ArtikolEmail.SelectionStart = 0;
            ArtikolEmail.ShortcutsEnabled = true;
            ArtikolEmail.Size = new Size(317, 48);
            ArtikolEmail.SkipLiterals = true;
            ArtikolEmail.TabIndex = 43;
            ArtikolEmail.TabStop = false;
            ArtikolEmail.TextAlign = HorizontalAlignment.Left;
            ArtikolEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            ArtikolEmail.TrailingIcon = null;
            ArtikolEmail.UseSystemPasswordChar = false;
            ArtikolEmail.UseWaitCursor = true;
            ArtikolEmail.ValidatingType = null;
            ArtikolEmail.Click += ArtikolEmail_Click;
            // 
            // FormKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1478, 656);
            Controls.Add(ArtikolEmail);
            Controls.Add(ArtikolTc);
            Controls.Add(ArtikolSifre);
            Controls.Add(ArtikolKullaniciAdi);
            Controls.Add(ButtonKayitOl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormKayit";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "FormKayit";
            UseWaitCursor = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKayitOlYonlendir;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBoxTc;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBoxEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBoxSifreKayit;
        private MaterialSkin.Controls.MaterialMaskedTextBox TextBoxKullaniciAdiKayit;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaterialSkin.Controls.MaterialTextBox2 KayittKullaniciAdi;
        private MaterialSkin.Controls.MaterialTextBox2 KayittSifree;
        private MaterialSkin.Controls.MaterialTextBox2 KayittTcc;
        private MaterialSkin.Controls.MaterialTextBox2 KayittEmaill;
        private Button ButtonKayitOl;
        private MaterialSkin.Controls.MaterialMaskedTextBox ArtikolKullaniciAdi;
        private MaterialSkin.Controls.MaterialMaskedTextBox ArtikolSifre;
        private MaterialSkin.Controls.MaterialMaskedTextBox ArtikolTc;
        private MaterialSkin.Controls.MaterialMaskedTextBox ArtikolEmail;
    }
}