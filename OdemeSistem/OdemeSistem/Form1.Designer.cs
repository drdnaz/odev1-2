namespace OdemeSistem
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
            cmbOdeme = new ComboBox();
            txtTutar = new TextBox();
            btnOde = new Button();
            lblSonuc = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // cmbOdeme
            // 
            cmbOdeme.FormattingEnabled = true;
            cmbOdeme.Location = new Point(310, 67);
            cmbOdeme.Name = "cmbOdeme";
            cmbOdeme.Size = new Size(182, 33);
            cmbOdeme.TabIndex = 0;
            cmbOdeme.SelectedIndexChanged += cmbOdeme_SelectedIndexChanged;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(310, 150);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(217, 31);
            txtTutar.TabIndex = 1;
            // 
            // btnOde
            // 
            btnOde.Location = new Point(332, 350);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(112, 34);
            btnOde.TabIndex = 2;
            btnOde.Text = "Ödeme Yap";
            btnOde.UseVisualStyleBackColor = true;
            btnOde.Click += btnOde_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(28, 295);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(61, 25);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "Sonuç";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            textBox1.Text = "ödeme şekli";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            textBox2.Text = "Tutar Giriniz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblSonuc);
            Controls.Add(btnOde);
            Controls.Add(txtTutar);
            Controls.Add(cmbOdeme);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOdeme;
        private TextBox txtTutar;
        private Button btnOde;
        private Label lblSonuc;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
