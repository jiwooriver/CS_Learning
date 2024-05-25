// 이미지를 표시한다
using System.Windows.Forms;
useing System.Drawing;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("c:||car.bmp");
        pb.parent = fm;

        Application.Run(fm);
    }
}