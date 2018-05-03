using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        ImageDrawer left;
        ImageDrawer right;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UpdateImage()
        {
            imageBox1.Image = left.image;
            imageBox2.Image = right.image;
        }

        private Point dot(Point a, Point b)
        {
            return new Point(a.X * b.X, a.Y * b.Y);
        }
        private double length(Point a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y);
        }
        BindingList<SupLine> list_left;
        BindingList<SupLine> list_right;
        private void button_run_Click(object sender, EventArgs e)
        {
            tab.SelectedIndex = 2;
            double a = (double)value_a.Value;
            double b = (double)value_b.Value;
            double p = (double)value_p.Value;
            double t = (double)value_t.Value;
            if (t == 0)
            {
                imageBox3.Image = left.origin;
                return;
            }
            else if (t == 1)
            {
                imageBox3.Image = right.origin;
                return;
            }
            list_left = left.LineList;
            list_right = right.LineList;
            List<SupLine> list_dest = new List<SupLine>();
            for (int i = 0; i < list_left.Count; i++)
            {
                list_dest.Add(SupLine.Interpolation(list_left[i], list_right[i], t));
            }
            Image<Bgr, byte> warp_left = left.Warp(list_dest, a, b, p);
            Image<Bgr, byte> warp_right = right.Warp(list_dest, a, b, p);
            imageBox3.Image = new Image<Bgr, byte>(warp_left.Size);
            CvInvoke.AddWeighted(warp_left, 1 - t, warp_right, t, 0, imageBox3.Image);

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            openFile.Title = b.Text;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (b == button_load1)
                {
                    left = new ImageDrawer(openFile.FileName);
                    imageBox1.Image = left.image;
                    left.update = () =>
                    {
                        //listBox1.DataSource = left.LineList;

                        imageBox1.Image = left.image;
                    };
                    left.Show();
                }
                else
                {
                    right = new ImageDrawer(openFile.FileName);
                    imageBox2.Image = right.image;
                    right.update = () =>
                    {
                        //list_right = right.LineList;
                        imageBox2.Image = right.image;
                    };
                    right.Show();
                }
                tab_SelectedIndexChanged(sender, e);
            }
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b == button_show1)
            {
                left.Show();
            }
            else
            {
                right.Show();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab.SelectedIndex)
            {
                case 0:
                    left?.RefreshLine(listBox1.SelectedIndex);
                    break;
                case 1:
                    right?.RefreshLine(listBox1.SelectedIndex);
                    break;
            }

        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab.SelectedIndex)
            {
                case 0:
                    listBox1.DataSource = left?.LineList;
                    break;
                case 1:
                    listBox1.DataSource = right?.LineList;
                    break;
                case 2:
                    listBox1.DataSource = null;
                    break;
            }
            listBox1.DisplayMember = "Detail";
        }

        private void button_up_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0 && tab.SelectedIndex != 2)
            {
                int index = listBox1.SelectedIndex;
                switch (tab.SelectedIndex)
                {
                    case 0:
                        left?.LineMoveUp(index);
                        break;
                    case 1:
                        right?.LineMoveUp(index);
                        break;
                }
                listBox1.SelectedIndex = index-1;
            }
        }
        private void button_down_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1 && tab.SelectedIndex != 2)
            {
                int index = listBox1.SelectedIndex;
                switch (tab.SelectedIndex)
                {
                    case 0:
                        left?.LineMoveDown(index);
                        break;
                    case 1:
                        right?.LineMoveDown(index);
                        break;
                }
                listBox1.SelectedIndex= index+1;
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (tab.SelectedIndex != 2)
            {
                switch (tab.SelectedIndex)
                {
                    case 0:
                        left?.LineRemove(listBox1.SelectedIndex);
                        break;
                    case 1:
                        right?.LineRemove(listBox1.SelectedIndex);
                        break;
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                imageBox3.Image.Save(saveFile.FileName);
            }
        }

        private void button_auto_Click(object sender, EventArgs e)
        {
            if (saveFolder.ShowDialog() == DialogResult.OK)
            {
                Thread t = new Thread(() =>
                      {
                          for (int i = 0; i <= 10; i++)
                          {
                              value_t.Value = (decimal)(i / 10.0);
                              button_run_Click(sender, e);
                              imageBox3.Refresh();
                              imageBox3.Image.Save(saveFolder.SelectedPath + @"\" + i.ToString() + ".jpg");
                              
                          }
                          imageBox3.Image = right.origin;
                          imageBox3.Refresh();
                      }
                );
                t.Start();

            }
        }
    }
}