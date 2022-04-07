namespace Modou_TMH306_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(ofile.FileName);
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            averageMethod.ConvertToGray(copy);
            this.picResult.Image=copy;

        }
    }
}