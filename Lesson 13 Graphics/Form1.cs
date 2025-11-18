/* Title:  Lesson 13 - Stationary Graphics
 * Date:   November 18 2025
 * Purpose:  To demonstrate how to add graphics objects
 * 
 */

namespace Lesson_13_Graphics
{
    public partial class Form1 : Form
    {
        //each font, fill colour (solidbrush) and line colour (pen)
        // must be created, best to do as global objects
        Font drawFont = new Font("Consolas", 16, FontStyle.Bold);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
       //SolidBrush is used for writing text and filling in objects
        Pen bluePen = new Pen(Color.Blue, 10);
        Pen blackPen = new Pen(Color.Black, 10);
        //Pens are used for drawing lines or shape outlines
        public Form1()
        {
            InitializeComponent();
        }
//This method is created by going to form-properties-lightning bold-paint and double clicking
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //always start with this!   This creates the graphics object
            Graphics g = e.Graphics;
            //sets the background colour
            g.Clear(Color.Blue);
            g.DrawString("This is 0,0", drawFont, greenBrush, 0, 0);
            //the number values are bottom left of string so have to adjust for the actual size
            g.DrawString("This is 'this.width, this.height'", drawFont, greenBrush, this.Width - 820, this.Height - 120);
            //Draw a yellow happy face in centre of screen  
            //diameter of face is 900 pixels
            //All dimensions based on this.width and this.height
            int faceSize = 900;
            int xFace = this.Width / 2 - faceSize / 2;
            int yFace = this.Height / 2 - faceSize / 2;

            //fill ellipse give a circle if width/height the same!
            g.FillEllipse(yellowBrush, xFace, yFace, faceSize, faceSize);

            //I chose to make all dimensions based on one face size
            // and location of centre of screen, but all arguments can be numbers!
            int yEye = yFace + faceSize / 4;
            int eyeSize = faceSize / 12;
            int xLeftEye = xFace + faceSize / 4 - eyeSize / 2;
            int xRightEye = this.Width / 2 + faceSize / 4 - eyeSize / 2;
            g.FillEllipse(blackBrush, xRightEye, yEye, eyeSize, eyeSize);
            g.FillEllipse(blackBrush, xLeftEye, yEye, eyeSize, eyeSize);
            //The smile is an arc
            //want the smile to travel from the right of the left eye to the 
            //left of the right eye...
            int xSmile = xLeftEye + eyeSize;
            int smileWidth = xRightEye - xLeftEye - eyeSize;
            int smileHeight = smileWidth / 2;
            int ySmile = yFace + faceSize / 2;
            g.DrawArc(blackPen, xSmile, ySmile, smileWidth, smileHeight, 0, 180);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            
            
           
        }
    }
}
