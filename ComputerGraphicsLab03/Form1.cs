using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphicsLab03
{
    public partial class Form1 : Form
    {
        List<Line> myLines = new List<Line>();
        Line _current = new Line();
        Bitmap bitmap;
        bool changeStartPoint;
        bool changeEndPoint;
        bool isDrawing;
        bool deleteLine;
        int index;
        int pixel =1;
        private Point _startPoint = Point.Empty;
        private Point _endPoint = Point.Empty;

        public class Line
        {
            public Point startPoint;
            public Point endPoint;
            public Color myColor;
            public int size;
            
            
            public Line(Point _startPoint, Point _endPoint, Color _myColor, int _size)
            {
                this.startPoint = _startPoint;
                this.endPoint = _endPoint;
                this.myColor = _myColor;
                this.size = _size;
            }

            public Line()
            {
            }
        }

        public Form1()
        {
            changeStartPoint = false;
            changeEndPoint = false;
            isDrawing = false;
            deleteLine = false;
            InitializeComponent();
            _current.startPoint = new Point(-1, -1);
            bitmap = new Bitmap(pictureBox_image.Width, pictureBox_image.Height);
            pictureBox_image.Image = bitmap;
            colorDialog1.Color = Color.BlueViolet;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_chooseColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                pictureBox2.BackColor = colorDialog1.Color;
        }



        void draw(Line line)
        {
            
         
            int d, dx, dy, ai, bi, xi, yi;
            int x = line.startPoint.X, y = line.startPoint.Y;
            int x1 = line.startPoint.X;
            int x2 = line.endPoint.X;
            int y1 = line.startPoint.Y;
            int y2 = line.endPoint.Y;
            int ddx = 0;
            int ddy = 0;
            // set drawing direction
            if (x1 < x2)
            {
                xi = 1;
                dx = line.endPoint.X - line.startPoint.X;
            }
            else
            {
                xi = -1;
                dx = line.startPoint.X - line.endPoint.X;
            }
            // set drawing direction
            if (y1 < y2)
            {
                yi = 1;
                dy = line.endPoint.Y - line.startPoint.Y;
            }
            else
            {
                yi = -1;
                dy = line.startPoint.Y - line.endPoint.Y;
            }
            // first pixel
            bitmap.SetPixel(x, y, line.myColor);
            // main OX
            if (dx > dy)
            {
                ai = (dy - dx) * 2;
                bi = dy * 2;
                d = bi - dx;
                // for next x's
                while (x != x2)
                {
                    // test coefficent
                    if (d >= 0)
                    {
                        x += xi;
                        y += yi;
                        d += ai;
                        ddy = line.size;

                    }
                    else
                    {
                        d += bi;
                        x += xi;
                        ddy = line.size;

                    }
                    bitmap.SetPixel(x, y, line.myColor);
                    if (ddy > 1)
                    {

                        for (int i = 0; i < ddy; i++)
                        {
                            if (line.startPoint.Y + i < 700)
                                bitmap.SetPixel(line.startPoint.X, line.startPoint.Y + i, line.myColor);
                            if (line.startPoint.Y - i >= 0)
                                bitmap.SetPixel(line.startPoint.X, line.startPoint.Y - i, line.myColor);
                            if (y + i < 700)
                                bitmap.SetPixel(x, y + i, line.myColor);
                            if (y - i >= 0)
                                bitmap.SetPixel(x, y - i, line.myColor);
                        }
                    }
                }
            }
            // main OY
            else
            {
                ai = (dx - dy) * 2;
                bi = dx * 2;
                d = bi - dy;
                //  for next y's
                while (y != y2)
                {
                    // test coefficent
                    if (d >= 0)
                    {
                        x += xi;
                        y += yi;
                        d += ai;
                        ddx = line.size;

                    }
                    else
                    {
                        d += bi;
                        y += yi;
                        ddx = line.size;

                    }
                    bitmap.SetPixel(x, y, line.myColor);
                    if (ddx > 1)
                    {

                        for (int i = 0; i < ddx; i++)
                        {
                            if (line.startPoint.X + i < 700)
                                bitmap.SetPixel(line.startPoint.X + i, line.startPoint.Y, line.myColor);
                            if (line.startPoint.X - i >= 0)
                                bitmap.SetPixel(line.startPoint.X - i, line.startPoint.Y, line.myColor);
                            if (x + i < 700)
                                bitmap.SetPixel(x + i, y, line.myColor);
                            if (x - i >= 0)
                                bitmap.SetPixel(x - i, y, line.myColor);
                        }
                    }

                }
            }
            pictureBox_image.Refresh();

        }


        private bool firstPoint(Line l)
        {
            if (l.startPoint.Equals(new Point(-1, -1)))
                return true;
            else
                return false;
        }

        void PutPixel(Graphics g, int x, int y, Color c, int p)
        {
            //p = pixel;
            Bitmap bm = new Bitmap(1,1);
            bm.SetPixel(0, 0, c);
            var result = new Bitmap(bm,p,p);
            g.DrawImageUnscaled(result, x, y);
        }

        private void DrawCircle(int x1, int y1, int x2, int y2)
        {
            Graphics g = Graphics.FromImage(pictureBox_image.Image);

            int R;
            double xd = x2 - x1;
            double yd = y2 - y1;
            R = Convert.ToInt32(Math.Sqrt((xd * xd) + (yd * yd)));

            int x = R, y = 0;//local coords     
            int cd2 = 0;    //current distance squared - radius squared

            PutPixel(g, x1 - R, y1, colorDialog1.Color, pixel);
            PutPixel(g, x1 + R, y1, colorDialog1.Color, pixel);
            PutPixel(g, x1, y1 - R, colorDialog1.Color, pixel);
            PutPixel(g, x1, y1 + R, colorDialog1.Color, pixel);

            while (x > y)
            {    //only formulate 1/8 of circle
                cd2 -= (--x) - (++y);
                if (cd2 < 0) cd2 += x++;
                //upper left left
                PutPixel(g, x1 - x, y1 - y, colorDialog1.Color, pixel);
                //upper upper left
                PutPixel(g, x1 - y, y1 - x, colorDialog1.Color, pixel);
                //upper upper right
                PutPixel(g, x1 + y, y1 - x, colorDialog1.Color, pixel);
                //upper right right
                PutPixel(g, x1 + x, y1 - y, colorDialog1.Color, pixel);
                //lower left left
                PutPixel(g, x1 - x, y1 + y, colorDialog1.Color, pixel);
                //lower lower left
                PutPixel(g, x1 - y, y1 + x, colorDialog1.Color, pixel);
                //lower lower right
                PutPixel(g, x1 + y, y1 + x, colorDialog1.Color, pixel);
                //lower right right
                PutPixel(g, x1 + x, y1 + y, colorDialog1.Color, pixel);
            }
            g.Dispose();
            this.pictureBox_image.Refresh();
            _current = new Line();
            _current.startPoint = new Point(-1, -1);
            isDrawing = false;
            changeEndPoint = false;
            changeStartPoint = false;
        }

        private void redrawLines()
        {
            bitmap = new Bitmap(pictureBox_image.Width, pictureBox_image.Height);
            pictureBox_image.Image = bitmap;

            foreach(Line myLine in myLines)
                draw(myLine);

            pictureBox_image.Refresh();
            return;
        }

        private bool endpointNear(Point _location)
        {
            for (int i = 0; i < myLines.Count; i++)
            {
                if ((Math.Abs(myLines[i].endPoint.X - _location.X) < 15 && Math.Abs(myLines[i].endPoint.Y - _location.Y) < 15))
                {
                    index = i;
                    if(!deleteLine)
                        changeEndPoint = true;
                    return true;
                }
                else if((Math.Abs(myLines[i].startPoint.X - _location.X) < 15 && Math.Abs(myLines[i].startPoint.Y - _location.Y) < 15))
                {
                    index = i;
                    if (!deleteLine)
                        changeStartPoint = true;
                    return true;
                }
            }
         return false;
        }

        private void pictureBox1_MouseClick(object sendPointer, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (deleteLine)
                {
                    deleteLine = false;
                    return;
                }

                _current.endPoint = e.Location;
                _current.myColor = colorDialog1.Color;
                _current.size = (int)numericUD_size.Value;
                if (check_circle.Checked==true)
                {
                    this.DrawCircle(_current.startPoint.X, _current.startPoint.Y, _current.endPoint.X, _current.endPoint.Y);
                    _startPoint = Point.Empty;
                    _endPoint = Point.Empty;
                }
                else
                {
                    draw(_current);
                    myLines.Add(new Line(_current.startPoint, _current.endPoint, colorDialog1.Color, _current.size));
                    _current.startPoint = new Point(-1, -1);
                    isDrawing = false;
                    return;
                }
            }
            else 
            {
                if (changeEndPoint)
                {
                    myLines[index].endPoint = new Point(e.Location.X, e.Location.Y);
                    changeEndPoint = false;
                    redrawLines();
                    return;
                }
                else if (changeStartPoint)
                {
                    myLines[index].startPoint = new Point(e.Location.X, e.Location.Y);
                    changeStartPoint = false;
                    redrawLines();
                    return;
                }

                if (!endpointNear(e.Location))
                {
                    if (deleteLine)
                    {
                        deleteLine = false;
                        return;
                    }

                    if (firstPoint(_current))
                    {
                        _current.startPoint = e.Location;
                        isDrawing = true;
                        return;
                    }
                }
                else
                {
                    if (deleteLine)
                    {
                        myLines.RemoveAt(index);
                        redrawLines();
                        deleteLine = false;
                        return;
                    }
                }
            } 
        }

        private void btn_deleteLine_Click(object sender, EventArgs e)
        {
            if (myLines.Count > 0)
            {
                deleteLine = true;
            }
        }

        private void numericUD_size_ValueChanged(object sender, EventArgs e)
        {
            pixel = (int)numericUD_size.Value;
        } 
    }
}
