namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực
{
    partial class MonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHoc));
            this.DGVMonHoc = new System.Windows.Forms.DataGridView();
            this.Button3 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextAddBoxMaMonHoc = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TinChi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaMon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonHoc)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMonHoc
            // 
            this.DGVMonHoc.AllowUserToAddRows = false;
            this.DGVMonHoc.AllowUserToDeleteRows = false;
            this.DGVMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMonHoc.Location = new System.Drawing.Point(3, 16);
            this.DGVMonHoc.Name = "DGVMonHoc";
            this.DGVMonHoc.ReadOnly = true;
            this.DGVMonHoc.Size = new System.Drawing.Size(277, 144);
            this.DGVMonHoc.TabIndex = 2;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(214, 389);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 16;
            this.Button3.Text = "&Đóng";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.DGVMonHoc);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(9, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(283, 163);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Danh sách môn học";
            // 
            // TextAddBoxMaMonHoc
            // 
            this.TextAddBoxMaMonHoc.Location = new System.Drawing.Point(97, 21);
            this.TextAddBoxMaMonHoc.Name = "TextAddBoxMaMonHoc";
            this.TextAddBoxMaMonHoc.Size = new System.Drawing.Size(173, 20);
            this.TextAddBoxMaMonHoc.TabIndex = 7;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button4.Location = new System.Drawing.Point(195, 47);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 23);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "Enter";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TextAddBoxMaMonHoc);
            this.GroupBox2.Controls.Add(this.Button4);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(9, 174);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(283, 81);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Sửa môn học";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(2, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Mã môn học:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TinChi);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxTenMon);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxMaMon);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 122);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sửa đổi";
            // 
            // TinChi
            // 
            this.TinChi.Location = new System.Drawing.Point(97, 74);
            this.TinChi.Name = "TinChi";
            this.TinChi.Size = new System.Drawing.Size(41, 20);
            this.TinChi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tín chỉ:";
            // 
            // textBoxTenMon
            // 
            this.textBoxTenMon.Location = new System.Drawing.Point(97, 48);
            this.textBoxTenMon.Name = "textBoxTenMon";
            this.textBoxTenMon.Size = new System.Drawing.Size(173, 20);
            this.textBoxTenMon.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên môn học:";
            // 
            // textBoxMaMon
            // 
            this.textBoxMaMon.Location = new System.Drawing.Point(97, 21);
            this.textBoxMaMon.Name = "textBoxMaMon";
            this.textBoxMaMon.Size = new System.Drawing.Size(173, 20);
            this.textBoxMaMon.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(195, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn học:";
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 416);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonHoc)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TinChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DGVMonHoc;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TextAddBoxMaMonHoc;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown TinChi;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox textBoxTenMon;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBoxMaMon;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label2;
    }
}