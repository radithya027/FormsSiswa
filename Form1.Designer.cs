namespace materi2
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
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnReset = new Button();
            btnDaftar = new Button();
            txtEmail = new TextBox();
            txtTempatlahir = new TextBox();
            cbTahun = new ComboBox();
            cbBulan = new ComboBox();
            cbTanggal = new ComboBox();
            rdcwe = new RadioButton();
            rdlaki = new RadioButton();
            txtHP = new TextBox();
            txtAlamat = new TextBox();
            txtNamaLengkap = new TextBox();
            txtPendaftaran = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            button2 = new Button();
            groupBox2 = new GroupBox();
            lblData = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnDaftar);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTempatlahir);
            groupBox1.Controls.Add(cbTahun);
            groupBox1.Controls.Add(cbBulan);
            groupBox1.Controls.Add(cbTanggal);
            groupBox1.Controls.Add(rdcwe);
            groupBox1.Controls.Add(rdlaki);
            groupBox1.Controls.Add(txtHP);
            groupBox1.Controls.Add(txtAlamat);
            groupBox1.Controls.Add(txtNamaLengkap);
            groupBox1.Controls.Add(txtPendaftaran);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 611);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlDark;
            btnClose.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(338, 543);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 21;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ControlDark;
            btnReset.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(205, 543);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 20;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = SystemColors.ButtonShadow;
            btnDaftar.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDaftar.Location = new Point(67, 543);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(94, 29);
            btnDaftar.TabIndex = 19;
            btnDaftar.Text = "DAFTAR";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 453);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtTempatlahir
            // 
            txtTempatlahir.Location = new Point(189, 413);
            txtTempatlahir.Name = "txtTempatlahir";
            txtTempatlahir.Size = new Size(297, 27);
            txtTempatlahir.TabIndex = 17;
            // 
            // cbTahun
            // 
            cbTahun.FormattingEnabled = true;
            cbTahun.Items.AddRange(new object[] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010" });
            cbTahun.Location = new Point(368, 353);
            cbTahun.Name = "cbTahun";
            cbTahun.Size = new Size(118, 28);
            cbTahun.TabIndex = 16;
            // 
            // cbBulan
            // 
            cbBulan.FormattingEnabled = true;
            cbBulan.Items.AddRange(new object[] { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus ", "September", "Oktober", "November", "Desember" });
            cbBulan.Location = new Point(244, 353);
            cbBulan.Name = "cbBulan";
            cbBulan.Size = new Size(118, 28);
            cbBulan.TabIndex = 15;
            // 
            // cbTanggal
            // 
            cbTanggal.FormattingEnabled = true;
            cbTanggal.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cbTanggal.Location = new Point(189, 353);
            cbTanggal.Name = "cbTanggal";
            cbTanggal.Size = new Size(47, 28);
            cbTanggal.TabIndex = 14;
            // 
            // rdcwe
            // 
            rdcwe.AutoSize = true;
            rdcwe.Location = new Point(328, 304);
            rdcwe.Name = "rdcwe";
            rdcwe.Size = new Size(104, 24);
            rdcwe.TabIndex = 13;
            rdcwe.TabStop = true;
            rdcwe.Text = "Perempuan";
            rdcwe.UseVisualStyleBackColor = true;
            // 
            // rdlaki
            // 
            rdlaki.AutoSize = true;
            rdlaki.Location = new Point(189, 304);
            rdlaki.Name = "rdlaki";
            rdlaki.Size = new Size(92, 24);
            rdlaki.TabIndex = 12;
            rdlaki.TabStop = true;
            rdlaki.Text = "Lak - Laki";
            rdlaki.UseVisualStyleBackColor = true;
            // 
            // txtHP
            // 
            txtHP.Location = new Point(189, 251);
            txtHP.Name = "txtHP";
            txtHP.Size = new Size(297, 27);
            txtHP.TabIndex = 11;
            txtHP.TextChanged += txtHP_TextChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(189, 132);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(297, 108);
            txtAlamat.TabIndex = 10;
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Location = new Point(189, 71);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(297, 27);
            txtNamaLengkap.TabIndex = 9;
            // 
            // txtPendaftaran
            // 
            txtPendaftaran.Location = new Point(189, 20);
            txtPendaftaran.Name = "txtPendaftaran";
            txtPendaftaran.Size = new Size(297, 27);
            txtPendaftaran.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 460);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 7;
            label9.Text = "Alamat E-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 361);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 6;
            label8.Text = "Tanggal Lahir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 416);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 5;
            label7.Text = "Tempat Lahir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 308);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 4;
            label6.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 258);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 3;
            label5.Text = "No Hp/WA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 74);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 2;
            label4.Text = "Nama Lengkap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 132);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 1;
            label3.Text = "Alamat Lengkap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 0;
            label2.Text = "No. Pendaftaran";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 14);
            label1.Name = "label1";
            label1.Size = new Size(474, 36);
            label1.TabIndex = 0;
            label1.Text = "Formulir Pendaftaran Siswa Baru Tahun 2023";
            label1.Click += label1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(525, 70);
            label10.Name = "label10";
            label10.Size = new Size(107, 20);
            label10.TabIndex = 1;
            label10.Text = "Tanggal Daftar";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(638, 66);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(149, 27);
            textBox7.TabIndex = 19;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(793, 64);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(525, 105);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 21;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(793, 105);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 22;
            button2.Text = "Hide";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblData);
            groupBox2.Location = new Point(525, 340);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 285);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data Pendaftar";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(6, 23);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 20);
            lblData.TabIndex = 22;
            lblData.Text = "Data";
            lblData.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 676);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(monthCalendar1);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPendaftaran;
        private Label label9;
        private Label label8;
        private Label label7;
        private RadioButton rdcwe;
        private RadioButton rdlaki;
        private TextBox txtHP;
        private TextBox txtAlamat;
        private TextBox txtNamaLengkap;
        private ComboBox cbBulan;
        private ComboBox cbTanggal;
        private ComboBox cbTahun;
        private TextBox txtEmail;
        private TextBox txtTempatlahir;
        private Label label10;
        private TextBox textBox7;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private Button button2;
        private GroupBox groupBox2;
        private Button btnClose;
        private Button btnReset;
        private Button btnDaftar;
        private Label lblData;
    }
}