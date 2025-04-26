namespace SerializationOrnek
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
            lblAd = new Label();
            lblTelefon = new Label();
            lblDepartman = new Label();
            lblDogumTarihi = new Label();
            lblMaas = new Label();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            txtDepartman = new TextBox();
            txtMaas = new TextBox();
            dtp1 = new DateTimePicker();
            btnSerializeEt = new Button();
            btnDeSerializeEt = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(118, 52);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(39, 25);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            lblAd.Click += lblAd_Click;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(118, 107);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(72, 25);
            lblTelefon.TabIndex = 1;
            lblTelefon.Text = "Telefon:";
            // 
            // lblDepartman
            // 
            lblDepartman.AutoSize = true;
            lblDepartman.Location = new Point(118, 162);
            lblDepartman.Name = "lblDepartman";
            lblDepartman.Size = new Size(105, 25);
            lblDepartman.TabIndex = 2;
            lblDepartman.Text = "Departman:";
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Location = new Point(118, 221);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(122, 25);
            lblDogumTarihi.TabIndex = 3;
            lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // lblMaas
            // 
            lblMaas.AutoSize = true;
            lblMaas.Location = new Point(118, 268);
            lblMaas.Name = "lblMaas";
            lblMaas.Size = new Size(58, 25);
            lblMaas.TabIndex = 4;
            lblMaas.Text = "Maaş:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(278, 46);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(162, 31);
            txtAd.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(278, 107);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(168, 31);
            txtTelefon.TabIndex = 6;
            // 
            // txtDepartman
            // 
            txtDepartman.Location = new Point(278, 162);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(168, 31);
            txtDepartman.TabIndex = 7;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(278, 279);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(168, 31);
            txtMaas.TabIndex = 8;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(278, 221);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(168, 31);
            dtp1.TabIndex = 9;
            // 
            // btnSerializeEt
            // 
            btnSerializeEt.Location = new Point(91, 358);
            btnSerializeEt.Name = "btnSerializeEt";
            btnSerializeEt.Size = new Size(172, 34);
            btnSerializeEt.TabIndex = 10;
            btnSerializeEt.Text = "SERİALİZE ET";
            btnSerializeEt.UseVisualStyleBackColor = true;
            btnSerializeEt.Click += btnSerializeEt_Click;
            // 
            // btnDeSerializeEt
            // 
            btnDeSerializeEt.Location = new Point(372, 358);
            btnDeSerializeEt.Name = "btnDeSerializeEt";
            btnDeSerializeEt.Size = new Size(175, 37);
            btnDeSerializeEt.TabIndex = 11;
            btnDeSerializeEt.Text = "DE SERİALİZE ET";
            btnDeSerializeEt.UseVisualStyleBackColor = true;
            btnDeSerializeEt.Click += btnDeSerializeEt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeSerializeEt);
            Controls.Add(btnSerializeEt);
            Controls.Add(dtp1);
            Controls.Add(txtMaas);
            Controls.Add(txtDepartman);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(lblMaas);
            Controls.Add(lblDogumTarihi);
            Controls.Add(lblDepartman);
            Controls.Add(lblTelefon);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblTelefon;
        private Label lblDepartman;
        private Label lblDogumTarihi;
        private Label lblMaas;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private TextBox txtDepartman;
        private TextBox txtMaas;
        private DateTimePicker dtp1;
        private Button btnSerializeEt;
        private Button btnDeSerializeEt;
    }
}
