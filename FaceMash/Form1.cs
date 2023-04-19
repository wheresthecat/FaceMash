namespace FaceMash
{
    public partial class Form1 : Form
    {
        images img = new images();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            lblInfo.Text = img.GuessSambaLeft();
        }

        private void picLeft_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            lblInfo.Text = img.GuessSambaLeft();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            img.ShufflePics();
            picLeft.Image = Image.FromFile(img.getLeftImagePath());
            picRight.Image = Image.FromFile(img.getRightImagePath());

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            lblInfo.Text = img.GuessSambaRight();
        }

        private void picRight_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            lblInfo.Text = img.GuessSambaRight();
        }
    }
}