namespace SmallWindowPuzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloToHeno(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "HeNOOO!";
        }

        private void HenoToHello(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Text = "Hello :D";
        }

        private void HelloClick(object sender, EventArgs e)
        {
            button1.Hide();
            this.Hide();
            label1.Show();
            HelpButton = true;
            Size = new System.Drawing.Size(128, 128);
            this.Show();
        }

        private void Help1(object sender, HelpEventArgs hlpevent)
        {
            label1.Text = "Hello :D";
            this.FormBorderStyle = FormBorderStyle.Sizable;
            Boom.Show();
        }

        private void boom1(object sender, EventArgs e)
        {
            if (Boom.Checked == true)
            {
                Boom.Text = "OHHHHHHHH";
                Boom.Enabled = false;
                IntoNextLevel.Show();
            }
        }

        private void WindowResize(object sender, EventArgs e)
        {
            Boom.Location = new Point(Width - Location.X, Height - Location.Y);
        }

        private void WindowMove(object sender, EventArgs e)
        {
            Boom.Location = new Point(Width - Location.X, Height - Location.Y);
        }

        private void IntoNextLevelPressed(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        protected override bool ProcessMnemonic(char charCode)
        {
            return true;
        }

    }
}
