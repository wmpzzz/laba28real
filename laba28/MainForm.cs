namespace laba28
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetStyle(this);
        }

        public void SetStyle(Control element)
        {
            foreach (Control control in element.Controls)
            {
                if (control is Button button)
                {
                    button.Cursor = Cursors.Hand;
                }
                SetStyle(control);
            }
        }

        public void Navigate(Form formFrom, Form formTo)
        {
            formFrom.Hide();

            formTo.ShowDialog();

            formFrom.Show();
        }
        private void ToEx1Button_Click(object sender, EventArgs e)
        {
            Ex1Form form = new Ex1Form();
            Navigate(this, form);
        }

        private void ToEx2Button_Click(object sender, EventArgs e)
        {
            Ex2Form form = new Ex2Form();
            Navigate(this, form);
        }

        private void ToEx3Button_Click(object sender, EventArgs e)
        {
            Ex3Form form = new Ex3Form();
            Navigate(this, form);
        }
    }
}
