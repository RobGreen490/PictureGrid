using System.Reflection.Emit;
using System.Windows.Forms;

namespace PictureGrid
{
    public partial class secretlyAGridBox : Form
    {
        public secretlyAGridBox()
        {
            InitializeComponent();
        }

        private void gridPictureBox_Click(object sender, EventArgs e)
        {
            Point mousePosition = gridPictureBox.PointToClient(MousePosition);
            float gridFloat = gridPictureBox.Height - mousePosition.Y;
            lbl_clickValueDisplayer.Text = $"{(gridFloat / 100):F2}";
        }


        private void gridPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = gridPictureBox.PointToClient(MousePosition);
            lbl_X.Text = $"X: {mousePosition.X}";
            // Flip the y-coordinate by subtracting it from the PictureBox's height
            lbl_Y.Text = $"Y: {gridPictureBox.Height - mousePosition.Y}";
        }
    }
}