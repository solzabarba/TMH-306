namespace TMH306_AVMetot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.pictureBox1.Image = new Bitmap(ofile.FileName);

            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pictureBox1.Image);
            Processing.ConvertToGray(copy);
            this.pictureBox2.Image = copy;
        }
    }
}