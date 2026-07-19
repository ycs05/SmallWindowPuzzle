namespace SmallWindowPuzzle
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
            button1 = new Button();
            label1 = new Label();
            Boom = new CheckBox();
            IntoNextLevel = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Hello :D";
            button1.UseVisualStyleBackColor = true;
            button1.Click += HelloClick;
            button1.MouseEnter += HelloToHeno;
            button1.MouseLeave += HenoToHello;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Help;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 1;
            label1.Text = "? HeNOOOOO!!!!!!";
            label1.Visible = false;
            label1.HelpRequested += Help1;
            // 
            // Boom
            // 
            Boom.AutoSize = true;
            Boom.Location = new Point(3, 41);
            Boom.Name = "Boom";
            Boom.Size = new Size(86, 21);
            Boom.TabIndex = 2;
            Boom.Text = "Boom!!!!!!";
            Boom.UseVisualStyleBackColor = true;
            Boom.Visible = false;
            Boom.CheckedChanged += boom1;
            // 
            // IntoNextLevel
            // 
            IntoNextLevel.Location = new Point(12, 12);
            IntoNextLevel.Name = "IntoNextLevel";
            IntoNextLevel.Size = new Size(107, 23);
            IntoNextLevel.TabIndex = 3;
            IntoNextLevel.Text = "Into next level";
            IntoNextLevel.UseVisualStyleBackColor = true;
            IntoNextLevel.Visible = false;
            IntoNextLevel.Click += IntoNextLevelPressed;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(120, 58);
            Controls.Add(IntoNextLevel);
            Controls.Add(Boom);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello";
            Move += WindowMove;
            Resize += WindowResize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckBox Boom;
        private Button IntoNextLevel;
    }
}
