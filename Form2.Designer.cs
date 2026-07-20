namespace SmallWindowPuzzle
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            notifyIcon1 = new NotifyIcon(components);
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            VerifyButton = new Button();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipText = "Hello again. :D";
            notifyIcon1.BalloonTipTitle = "awa";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "OneDrive";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += FakeOneDrivePressed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 192);
            label1.Name = "label1";
            label1.Size = new Size(126, 17);
            label1.TabIndex = 0;
            label1.Text = "There is no anything";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.AsciiOnly = true;
            maskedTextBox1.BeepOnError = true;
            maskedTextBox1.Location = new Point(146, 12);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PasswordChar = '*';
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(128, 17);
            label2.TabIndex = 2;
            label2.Text = "Input the password: ";
            label2.Visible = false;
            // 
            // VerifyButton
            // 
            VerifyButton.Location = new Point(252, 12);
            VerifyButton.Name = "VerifyButton";
            VerifyButton.Size = new Size(75, 23);
            VerifyButton.TabIndex = 3;
            VerifyButton.Text = "Verify";
            VerifyButton.UseVisualStyleBackColor = true;
            VerifyButton.Visible = false;
            VerifyButton.Click += Verify;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VerifyButton);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += onFormClosed;
            SizeChanged += sizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Button VerifyButton;
    }
}