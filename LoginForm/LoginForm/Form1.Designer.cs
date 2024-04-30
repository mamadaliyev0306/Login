namespace LoginForm
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
            btnEnter = new Button();
            FIO = new Label();
            UserName = new Label();
            Password = new Label();
            FulName = new TextBox();
            lbPassword = new TextBox();
            lbUserName = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.BackColor = SystemColors.ScrollBar;
            btnEnter.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = SystemColors.ControlText;
            btnEnter.Location = new Point(243, 348);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(263, 47);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += button1_Click;
            // 
            // FIO
            // 
            FIO.AccessibleName = "";
            FIO.AutoSize = true;
            FIO.BackColor = Color.WhiteSmoke;
            FIO.Cursor = Cursors.SizeNESW;
            FIO.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FIO.ForeColor = Color.Black;
            FIO.Location = new Point(59, 49);
            FIO.Name = "FIO";
            FIO.Size = new Size(55, 31);
            FIO.TabIndex = 1;
            FIO.Text = "FIO";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.Location = new Point(59, 133);
            UserName.Name = "UserName";
            UserName.Size = new Size(139, 31);
            UserName.TabIndex = 2;
            UserName.Text = "UserName";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(59, 232);
            Password.Name = "Password";
            Password.Size = new Size(132, 31);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // FulName
            // 
            FulName.AccessibleName = "";
            FulName.BackColor = SystemColors.ButtonHighlight;
            FulName.Location = new Point(228, 51);
            FulName.Name = "FulName";
            FulName.Size = new Size(343, 31);
            FulName.TabIndex = 4;
            FulName.TextChanged += FulName_TextChanged;
            // 
            // lbPassword
            // 
            lbPassword.Location = new Point(228, 232);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(343, 31);
            lbPassword.TabIndex = 5;
            // 
            // lbUserName
            // 
            lbUserName.Location = new Point(228, 135);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(343, 31);
            lbUserName.TabIndex = 6;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 635);
            Controls.Add(lbUserName);
            Controls.Add(lbPassword);
            Controls.Add(FulName);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(FIO);
            Controls.Add(btnEnter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Label FIO;
        private Label UserName;
        private Label Password;
        private TextBox FulName;
        private TextBox lbPassword;
        private TextBox lbUserName;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
