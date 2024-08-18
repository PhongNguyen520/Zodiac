namespace ZodiacGUI
{
    partial class ZodiacMain
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
            lblHeader = new Label();
            lblBirthday = new Label();
            lblCopyright = new Label();
            lblResult = new Label();
            lblBirthMonth = new Label();
            txtBirthDay = new TextBox();
            txtBirthMonth = new TextBox();
            btnCheck = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Crimson;
            lblHeader.Location = new Point(130, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(627, 62);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Your zodiac sign is your fate";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font(".VnArial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBirthday.ForeColor = Color.Crimson;
            lblBirthday.Location = new Point(62, 154);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(198, 33);
            lblBirthday.TabIndex = 1;
            lblBirthday.Text = "Your birthday";
            lblBirthday.Click += label1_Click;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font(".VnArial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCopyright.ForeColor = Color.Crimson;
            lblCopyright.Location = new Point(86, 512);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(134, 33);
            lblCopyright.TabIndex = 3;
            lblCopyright.Text = "phong.nt";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font(".VnArial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Crimson;
            lblResult.Location = new Point(39, 452);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(241, 33);
            lblResult.TabIndex = 4;
            lblResult.Text = "Your zodiac sign";
            // 
            // lblBirthMonth
            // 
            lblBirthMonth.AutoSize = true;
            lblBirthMonth.Font = new Font(".VnArial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBirthMonth.ForeColor = Color.Crimson;
            lblBirthMonth.Location = new Point(39, 254);
            lblBirthMonth.Name = "lblBirthMonth";
            lblBirthMonth.Size = new Size(234, 33);
            lblBirthMonth.TabIndex = 5;
            lblBirthMonth.Text = "Your birthmonth";
            // 
            // txtBirthDay
            // 
            txtBirthDay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthDay.Location = new Point(307, 144);
            txtBirthDay.Name = "txtBirthDay";
            txtBirthDay.Size = new Size(267, 47);
            txtBirthDay.TabIndex = 6;
            // 
            // txtBirthMonth
            // 
            txtBirthMonth.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthMonth.Location = new Point(307, 244);
            txtBirthMonth.Name = "txtBirthMonth";
            txtBirthMonth.Size = new Size(267, 47);
            txtBirthMonth.TabIndex = 7;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(222, 324);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(160, 59);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "Check zodiac";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(448, 324);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(157, 59);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // ZodiacMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(921, 595);
            Controls.Add(btnQuit);
            Controls.Add(btnCheck);
            Controls.Add(txtBirthMonth);
            Controls.Add(txtBirthDay);
            Controls.Add(lblBirthMonth);
            Controls.Add(lblResult);
            Controls.Add(lblCopyright);
            Controls.Add(lblBirthday);
            Controls.Add(lblHeader);
            ForeColor = Color.Crimson;
            Name = "ZodiacMain";
            Text = "Zodiac Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblBirthday;
        private Label lblCopyright;
        private Label lblResult;
        private Label lblBirthMonth;
        private TextBox txtBirthDay;
        private TextBox txtBirthMonth;
        private Button btnCheck;
        private Button btnQuit;
    }
}
