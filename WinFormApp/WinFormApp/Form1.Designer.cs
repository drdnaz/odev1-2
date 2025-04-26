namespace WinFormApp
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
            lbladiniz = new Label();
            lblsoyadiniz = new Label();
            lblgozRengi = new Label();
            lblkulak = new Label();
            lblburun = new Label();
            txtAdiniz = new TextBox();
            txtSoyadiniz = new TextBox();
            cmbGozRengi = new ComboBox();
            cmbKulak = new ComboBox();
            cmbBurun = new ComboBox();
            btnKaydet = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lbladiniz
            // 
            lbladiniz.AutoSize = true;
            lbladiniz.Location = new Point(138, 55);
            lbladiniz.Name = "lbladiniz";
            lbladiniz.Size = new Size(65, 25);
            lbladiniz.TabIndex = 0;
            lbladiniz.Text = "Adınız:";
            lbladiniz.Click += adiniz_Click;
            // 
            // lblsoyadiniz
            // 
            lblsoyadiniz.AutoSize = true;
            lblsoyadiniz.Location = new Point(138, 110);
            lblsoyadiniz.Name = "lblsoyadiniz";
            lblsoyadiniz.Size = new Size(92, 25);
            lblsoyadiniz.TabIndex = 1;
            lblsoyadiniz.Text = "Soyadınız:";
            // 
            // lblgozRengi
            // 
            lblgozRengi.AutoSize = true;
            lblgozRengi.Location = new Point(138, 175);
            lblgozRengi.Name = "lblgozRengi";
            lblgozRengi.Size = new Size(96, 25);
            lblgozRengi.TabIndex = 2;
            lblgozRengi.Text = "Göz Rengi:";
            // 
            // lblkulak
            // 
            lblkulak.AutoSize = true;
            lblkulak.Location = new Point(138, 247);
            lblkulak.Name = "lblkulak";
            lblkulak.Size = new Size(58, 25);
            lblkulak.TabIndex = 3;
            lblkulak.Text = "Kulak:";
            // 
            // lblburun
            // 
            lblburun.AutoSize = true;
            lblburun.Location = new Point(141, 315);
            lblburun.Name = "lblburun";
            lblburun.Size = new Size(62, 25);
            lblburun.TabIndex = 4;
            lblburun.Text = "Burun:";
            // 
            // txtAdiniz
            // 
            txtAdiniz.Location = new Point(326, 55);
            txtAdiniz.Name = "txtAdiniz";
            txtAdiniz.Size = new Size(157, 31);
            txtAdiniz.TabIndex = 5;
            // 
            // txtSoyadiniz
            // 
            txtSoyadiniz.Location = new Point(326, 110);
            txtSoyadiniz.Name = "txtSoyadiniz";
            txtSoyadiniz.Size = new Size(150, 31);
            txtSoyadiniz.TabIndex = 6;
            // 
            // cmbGozRengi
            // 
            cmbGozRengi.FormattingEnabled = true;
            cmbGozRengi.Items.AddRange(new object[] { "seçiniz", "Kahverengi", "Siyah", "Yeşil", "mavi" });
            cmbGozRengi.Location = new Point(326, 172);
            cmbGozRengi.Name = "cmbGozRengi";
            cmbGozRengi.Size = new Size(182, 33);
            cmbGozRengi.TabIndex = 7;
            cmbGozRengi.SelectedIndexChanged += cmbGozRengi_SelectedIndexChanged;
            // 
            // cmbKulak
            // 
            cmbKulak.FormattingEnabled = true;
            cmbKulak.Items.AddRange(new object[] { "seçiniz", "büyük ", "yassı", "küçük" });
            cmbKulak.Location = new Point(326, 244);
            cmbKulak.Name = "cmbKulak";
            cmbKulak.Size = new Size(182, 33);
            cmbKulak.TabIndex = 8;
            cmbKulak.SelectedIndexChanged += cmbKulak_SelectedIndexChanged;
            // 
            // cmbBurun
            // 
            cmbBurun.FormattingEnabled = true;
            cmbBurun.Items.AddRange(new object[] { "seçiniz ", "kemerli", "düz", "geniş" });
            cmbBurun.Location = new Point(310, 312);
            cmbBurun.Name = "cmbBurun";
            cmbBurun.Size = new Size(198, 33);
            cmbBurun.TabIndex = 9;
            cmbBurun.SelectedIndexChanged += cmbBurun_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(602, 389);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(112, 49);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(60, 372);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(65, 25);
            lblSonuc.TabIndex = 11;
            lblSonuc.Text = "Sonuç:";
            lblSonuc.Click += lblSonuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnKaydet);
            Controls.Add(cmbBurun);
            Controls.Add(cmbKulak);
            Controls.Add(cmbGozRengi);
            Controls.Add(txtSoyadiniz);
            Controls.Add(txtAdiniz);
            Controls.Add(lblburun);
            Controls.Add(lblkulak);
            Controls.Add(lblgozRengi);
            Controls.Add(lblsoyadiniz);
            Controls.Add(lbladiniz);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbladiniz;
        private Label lblsoyadiniz;
        private Label lblgozRengi;
        private Label lblkulak;
        private Label lblburun;
        private TextBox txtAdiniz;
        private TextBox txtSoyadiniz;
        private ComboBox cmbGozRengi;
        private ComboBox cmbKulak;
        private ComboBox cmbBurun;
        private Button btnKaydet;
        private Label lblSonuc;
    }
}
