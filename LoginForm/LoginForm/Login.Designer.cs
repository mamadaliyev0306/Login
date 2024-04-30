namespace LoginForm
{
    partial class Login
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
            lbUserName = new Label();
            lbParol = new Label();
            txtUserName = new TextBox();
            txtParol = new TextBox();
            btnLogin = new Button();
            bntENTER = new Button();
            lbErrorLaber = new Label();
            lbErrorMess = new Label();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(81, 108);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(155, 38);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "UserName";
            lbUserName.Click += label1_Click;
            // 
            // lbParol
            // 
            lbParol.AutoSize = true;
            lbParol.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbParol.Location = new Point(81, 228);
            lbParol.Name = "lbParol";
            lbParol.Size = new Size(88, 38);
            lbParol.TabIndex = 1;
            lbParol.Text = "Parol";
            lbParol.Click += label2_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(272, 102);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(322, 31);
            txtUserName.TabIndex = 2;
            // 
            // txtParol
            // 
            txtParol.Location = new Point(272, 222);
            txtParol.Name = "txtParol";
            txtParol.Size = new Size(322, 31);
            txtParol.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(155, 332);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(521, 57);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // bntENTER
            // 
            bntENTER.BackColor = SystemColors.ControlDark;
            bntENTER.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntENTER.Location = new Point(526, 449);
            bntENTER.Name = "bntENTER";
            bntENTER.Size = new Size(216, 55);
            bntENTER.TabIndex = 5;
            bntENTER.Text = "ENTER";
            bntENTER.UseVisualStyleBackColor = false;
            // 
            // lbErrorLaber
            // 
            lbErrorLaber.AutoSize = true;
            lbErrorLaber.Location = new Point(238, 47);
            lbErrorLaber.Name = "lbErrorLaber";
            lbErrorLaber.Size = new Size(0, 25);
            lbErrorLaber.TabIndex = 6;
            // 
            // lbErrorMess
            // 
            lbErrorMess.AutoSize = true;
            lbErrorMess.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbErrorMess.ForeColor = Color.FromArgb(192, 0, 0);
            lbErrorMess.Location = new Point(272, 47);
            lbErrorMess.Name = "lbErrorMess";
            lbErrorMess.Size = new Size(0, 28);
            lbErrorMess.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 570);
            Controls.Add(lbErrorMess);
            Controls.Add(lbErrorLaber);
            Controls.Add(bntENTER);
            Controls.Add(btnLogin);
            Controls.Add(txtParol);
            Controls.Add(txtUserName);
            Controls.Add(lbParol);
            Controls.Add(lbUserName);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private Label lbParol;
        private TextBox txtUserName;
        private TextBox txtParol;
        private Button btnLogin;
        private Button bntENTER;
        private Label lbErrorLaber;
        private Label lbErrorMess;
    }
}