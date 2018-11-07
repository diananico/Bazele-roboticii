using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpandareObstacole
{
    public partial class Form1 : Form
    {

        IList<Point> listp = new List<Point>();
        int listindex = 0;
        int panelPoints = 0;
        int panelValidPoints = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combocapete.SelectedIndex = 0;
            comboforma.SelectedIndex = 0;
            combouniform.SelectedIndex = 0;
            CheckComboVal();
        }

        private void CheckComboVal()
        {
            if (combouniform.SelectedIndex == 0)
            {
                txtdist.Visible = true;
                label2.Visible = true;

                txtdist1.Visible = false;
                txtdist2.Visible = false;
                txtdist3.Visible = false;
                txtdist4.Visible = false;
                txtdist5.Visible = false;
                txtdist6.Visible = false;
                txtdist7.Visible = false;
                txtdist8.Visible = false;
                txtdist9.Visible = false;
                txtdist10.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
            }
            else if (combouniform.SelectedIndex == 1)
            {
                txtdist.Visible = false;
                label2.Visible = false;

                txtdist1.Visible = true;
                txtdist2.Visible = true;
                txtdist3.Visible = true;
                txtdist4.Visible = true;
                txtdist5.Visible = true;
                txtdist6.Visible = true;
                txtdist7.Visible = true;
                txtdist8.Visible = true;
                txtdist9.Visible = true;
                txtdist10.Visible = true;

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
            }
            else
            {
                MessageBox.Show("Nu ati ales tipul uniform/neuniform !");
            }
        }

        private void combouniform_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboVal();
        }

        private void btnexpand_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            Pen blackpen = new Pen(Color.Black, 3);
            Pen p = new Pen(Color.DarkRed, 10f);
            Font font = new Font("Comic", 7);
            String raza = (txtraza.Text == "") ? "0" : txtraza.Text;
            float radius = float.Parse(raza);
            float xoffset = 4.5f;
            float yoffset = 6f;


            if (panelPoints == 1)
            {//it's a circle
                if (radius == 0)
                {
                    MessageBox.Show("Ati introdus un punct => cerc. \n Introduceti raza.");
                    lblraza.Visible = true;
                    txtraza.Visible = true;
                }
                else
                {
                    Compute.DrawCircle(g, blackpen, (float)listp[0].x + xoffset, (float)listp[0].y + yoffset, radius);                  
                    lblraza.Visible = false;
                    txtraza.Visible = false;
                }
            }
            else if (panelPoints > 1)
            {
                IList<Point> actual = ConvexHull.MakeHull(listp);
                IList<Point> expected = ConvexHullTest.MakeHullNaive(listp);

                ConvexHullTest.AssertEquals(expected, actual);

                int nr = expected.Count;

                if (nr > 2)
                {
                    txtnrpct.Text = nr.ToString();
                    
                    Brush br = new SolidBrush(System.Drawing.Color.DarkRed);

                    for (int index = 0; index < nr; index++)
                    {
                        g.DrawString("X", font, br, (float)expected[index].x, (float)expected[index].y);
                    }
                    System.Threading.Thread.Sleep(7000);

                    for (int index = 0; index < nr - 1; index++)
                    {
                        g.DrawLine(blackpen, (float)expected[index].x + xoffset, (float)expected[index].y + yoffset, (float)expected[index + 1].x + xoffset, (float)expected[index + 1].y + yoffset);
                    }
                    g.DrawLine(blackpen, (float)expected[nr - 1].x + xoffset, (float)expected[nr - 1].y + yoffset, (float)expected[0].x + xoffset, (float)expected[0].y + yoffset);

                }
                else
                {
                    Brush eraseBrush = new SolidBrush(System.Drawing.Color.WhiteSmoke);
                    MessageBox.Show("Numarul de puncte este: " + nr.ToString() + "\nSunt necesare minim 3 puncte pentru a genera o figura.");

                    for (int index = 0; index < nr; index++)
                    {
                        g.DrawString("X", font, eraseBrush, (float)expected[index].x, (float)expected[index].y);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Nu ati dat niciun punct.");
            }
            listp.Clear();
            panelPoints = 0;
            g.Dispose();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Font font = new Font("Comic", 7);
            Brush br = new SolidBrush(System.Drawing.Color.Olive);
            System.Drawing.Point point = panel1.PointToClient(Cursor.Position);
            g.DrawString("X", font, br, point.X, point.Y);


            //listp[listindex].x = point.X;
            //listp[listindex].y = point.y;
            listp.Add(new Point(point.X, point.Y));

            lblCoord.Text = point.ToString();

            panelPoints++;
        }
    }
}

