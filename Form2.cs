using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace SmallWindowPuzzle
{
    public partial class Form2 : Form
    {
        int tt = 0;
        public Form2()
        {
            InitializeComponent();
            Timer t = new Timer();
            t.Interval = 1;
            t.Tick += (s, e) =>
            {
                TickUpdate();
                this.Invalidate();
            };
            t.Start();

        }
        private void TickUpdate()
        {
            if (label1.Text == "Oh, No!")
            {
                if (label1.Location.Y < 32767)
                {
                    label1.Location = new Point(label1.Location.X, label1.Location.Y + tt);
                    tt += (10 - tt) / 10;
                }
                else
                {
                    label1.Visible = false;
                }
            }
        }
        private void FakeOneDrivePressed(object sender, MouseEventArgs e)
        {
            label1.Text = "Oh, No!";
            label2.Show();
            maskedTextBox1.Show();
            VerifyButton.Show();
        }

        private void sizeChanged(object sender, EventArgs e)
        {
            if (label1.Text != "Oh, No!")
            {
                label1.Location = new Point(Width / 2 - label1.Width / 2, Height / 2 - label1.Height / 2);
            }
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        protected override bool ProcessMnemonic(char charCode)
        {
            return true;
        }

        private void Verify(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "Down")
            {
                MessageBox.Show("Password pass!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Password error!", "Down inputfield                                                                                                                                                                             (Tip: Label)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
