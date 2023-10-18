namespace GraphicalPrograrammingEnvironment
{
    public partial class Form1 : Form
    {
        Bitmap mybitmap;
        Pen p;
        bool mousedown = false;
        private Color colour;

        public Form1()
        {
            InitializeComponent();
            mybitmap = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colour = colorDialog1.Color;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            p = new Pen(colour, 3);
            Graphics g = Graphics.FromImage(mybitmap);
            g.DrawLine(p, e.X, e.Y, e.X + 2, e.Y + 2);
            Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("paint Called");
            Graphics g = e.Graphics;//get graphics cotext of form(which is beingdisplayed)
            g.DrawImageUnscaled(mybitmap, 25, 25);

        }
    }
}


