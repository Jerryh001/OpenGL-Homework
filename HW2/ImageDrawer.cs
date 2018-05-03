using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace HW2
{
    class ImageDrawer
    {
        public delegate void UpdateImage();
        public UpdateImage update { private get; set; }
        public BindingList<SupLine> LineList { get; private set; } = new BindingList<SupLine>();
        public Image<Bgr, byte> image { get; private set; }
        public Image<Bgr, byte> origin { get; private set; }
        public bool WindowOpened { get; private set; } = false;
        private bool draw_line = false;
        private Point begin;
        private ImageViewer viewer;
        //private Point end;
        public ImageDrawer(string filename)
        {
            origin = new Image<Bgr, byte>(filename);
            image = origin.Clone();
            viewer = new ImageViewer(image);
            viewer.ImageBox.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;

            viewer.ImageBox.MouseDown += (s, e) =>
            {
                RefreshLine();
                viewer.Image = image.Clone();
                draw_line = true;
                begin = e.Location;
            };
            viewer.ImageBox.MouseMove += (s, e) =>
            {
                ImageBox box = (ImageBox)s;
                if (draw_line)
                {
                    viewer.Image.Dispose();
                    viewer.Image = image.Clone();
                    double newX = (double)e.X * box.Image.Size.Width / box.Width;
                    double newY = (double)e.Y * box.Image.Size.Height / box.Height;
                    CvInvoke.Line(viewer.Image, begin, e.Location, new MCvScalar(255, 255, 0, 255));
                }
            };
            viewer.ImageBox.MouseUp += (s, e) =>
            {
                CvInvoke.Line(image, begin, e.Location, new MCvScalar(255, 255, 0, 255));
                CvInvoke.Circle(image, begin, 2, new MCvScalar(0, 255, 255, 255), 2);
                CvInvoke.Circle(image, e.Location, 2, new MCvScalar(255, 0, 255, 255), 2);
                LineList.Add(new SupLine((SupPoint)begin, (SupPoint)e.Location));
                viewer.Image = image.Clone();
                update();
                draw_line = false;
            };
        }
        public void Show()
        {
            if (WindowOpened == false)
            {
                WindowOpened = true;
                Thread t = new Thread(() =>
                {
                    viewer.ShowDialog();
                    WindowOpened = false;
                });
                t.IsBackground = true;
                t.Start();
            }
        }
        public Image<Bgr, byte> Warp(List<SupLine> list_dest, double a = 1, double b = 2, double p = 0)
        {
            Image<Bgr, byte> ans = new Image<Bgr, byte>(origin.Size);
            for (int i = 0; i < ans.Width; i++)
            {
                for (int j = 0; j < ans.Height; j++)
                {
                    SupPoint dest = new SupPoint(i, j);
                    SupPoint sour = new SupPoint(0, 0);
                    List<double> weight = new List<double>();
                    double weight_sum = 0;
                    List<SupPoint> loc = new List<SupPoint>();
                    for (int k = 0; k < list_dest.Count; k++)
                    {

                        double u = list_dest[k].GetProjectionScale(dest);
                        double v = list_dest[k].GetPerpendicularLength(dest);
                        SupPoint temp = LineList[k].Begin + u * LineList[k].Vector + v * new SupPoint(LineList[k].Vector.Y, -LineList[k].Vector.X) / LineList[k].Vector.Length;
                        double dist = Math.Abs(u < 0 ? (temp - LineList[k].Begin).Length : (u > 1 ? (temp - LineList[k].End).Length : LineList[k].GetPerpendicularLength(temp)));
                        double w = Math.Pow(Math.Pow(list_dest[k].Vector.Length, p) / (a + dist), b);
                        weight_sum += w;
                        weight.Add(w);
                        loc.Add(temp);
                    }
                    for (int k = 0; k < weight.Count; k++)
                    {
                        sour += (weight[k] / weight_sum) * loc[k];
                    }
                    Point SP = new Point((int)Math.Round(sour.X), (int)Math.Round(sour.Y));
                    if (SP.X < 0) SP.X = 0;
                    if (SP.Y < 0) SP.Y = 0;
                    if (SP.X >= ans.Width) SP.X = ans.Width - 1;
                    if (SP.Y >= ans.Height) SP.Y = ans.Height - 1;
                    ans[new Point(i, j)] = Bilinear((SupPoint)SP);
                }
            }
            return ans;
        }
        private Bgr Bilinear(SupPoint p)
        {
            MCvScalar result = new MCvScalar(0, 0, 0);
            SupPoint basep = new SupPoint(Math.Floor(p.X), Math.Floor(p.Y));
            if(basep.X>=origin.Width-1||basep.Y>=origin.Height-1)
            {
                return origin[(int)basep.Y, (int)basep.X];
            }
            double a = p.X - basep.X;
            double b = p.Y - basep.Y;
            Bgr lt = origin[(int)basep.Y, (int)basep.X];
            Bgr lb = origin[(int)basep.Y+1, (int)basep.X];
            Bgr rt = origin[(int)basep.Y, (int)basep.X+1];
            Bgr rb = origin[(int)basep.Y+1, (int)basep.X+1];
            double blue = (1 - a) * (1 - b) * lt.Blue + (1 - a) * b * lb.Blue + a * (1 - b) * rt.Blue + a * b * rb.Blue;
            double green = (1 - a) * (1 - b) * lt.Green + (1 - a) * b * lb.Green + a * (1 - b) * rt.Green + a * b * rb.Green;
            double red = (1 - a) * (1 - b) * lt.Red + (1 - a) * b * lb.Red + a * (1 - b) * rt.Red + a * b * rb.Red;
            return new Bgr(blue,green,red);
        }
        public void RefreshLine(int index = -1)
        {
            image = origin.Clone();
            for (int i = 0; i < LineList.Count; i++)
            {
                Point begin = new Point((int)LineList[i].Begin.X, (int)LineList[i].Begin.Y);
                Point end = new Point((int)LineList[i].End.X, (int)LineList[i].End.Y);
                if (index == i)
                {
                    CvInvoke.Line(image, begin, end, new MCvScalar(0, 0, 255, 255));
                    CvInvoke.Circle(image, begin, 2, new MCvScalar(0, 0, 255, 255), 2);
                    CvInvoke.Circle(image, end, 2, new MCvScalar(0, 0, 255, 255), 2);
                }
                else
                {
                    CvInvoke.Line(image, begin, end, new MCvScalar(255, 255, 0, 255));
                    CvInvoke.Circle(image, begin, 2, new MCvScalar(0, 255, 255, 255), 2);
                    CvInvoke.Circle(image, end, 2, new MCvScalar(255, 0, 255, 255), 2);
                }
            }
            viewer.Image = image.Clone();
            update();
        }
        public void LineRemove(int index)
        {
            LineList.RemoveAt(index);
            RefreshLine();
        }
        public void LineMoveUp(int index)
        {
            if(index>0)
            {
                SupLine temp = LineList[index];
                LineList.RemoveAt(index);
                LineList.Insert(index-1, temp);
            }
        }
        public void LineMoveDown(int index)
        {
            if(index<LineList.Count-1)
            {
                SupLine temp = LineList[index];
                LineList.RemoveAt(index);
                LineList.Insert(index+1, temp);
            }
        }
    }
}
