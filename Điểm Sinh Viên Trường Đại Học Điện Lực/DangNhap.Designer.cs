namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.PassWordBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EntryButton = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.PassWordBox);
            this.Panel1.Controls.Add(this.IdBox);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(13, 46);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(271, 81);
            this.Panel1.TabIndex = 18;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Yu Gothic Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(20, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 18);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Mật khẩu:";
            // 
            // PassWordBox
            // 
            this.PassWordBox.Location = new System.Drawing.Point(124, 46);
            this.PassWordBox.MaxLength = 50;
            this.PassWordBox.Name = "PassWordBox";
            this.PassWordBox.PasswordChar = '*';
            this.PassWordBox.Size = new System.Drawing.Size(126, 20);
            this.PassWordBox.TabIndex = 1;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(124, 9);
            this.IdBox.MaxLength = 50;
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(126, 20);
            this.IdBox.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Yu Gothic Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(20, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 18);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Tài khoản:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Maroon;
            this.Label1.Location = new System.Drawing.Point(102, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(101, 22);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Đăng Nhập";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(190, 133);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(93, 26);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EntryButton
            // 
            this.EntryButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryButton.Location = new System.Drawing.Point(91, 133);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(93, 26);
            this.EntryButton.TabIndex = 19;
            this.EntryButton.Text = "Đăng nhập";
            this.EntryButton.UseVisualStyleBackColor = false;
            this.EntryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 171);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EntryButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox PassWordBox;
        internal System.Windows.Forms.TextBox IdBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EntryButton;
    }
}

