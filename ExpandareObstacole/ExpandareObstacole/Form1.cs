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

            if ((txtdist.Text).Equals("") || (((txtdist1.Text).Equals(""))))
            {
                MessageBox.Show("Nu ati introdus valoarea de Expandare!");
            }
            else if (!(txtdist.Text).Equals(""))
            {   
                //traseaza paralele
                IList<Point> newP = new List<Point>();
                newP = Parallel.GetEnlargedPolygon(listp, (float)Convert.ToUInt16(txtdist.Text), out Point close1);
                Graphics g3 = panel1.CreateGraphics();
                Point punct1;
                Point punct2;
                Pen p = new Pen(Color.Red, 3);

                int index = 2;
                while (index < (panelPoints * 4))
                {
                    punct1 = Parallel.parallelP[index];
                    punct2 = Parallel.parallelP[index + 1];
                    g3.DrawLine(p, (float)punct1.x, (float)punct1.y, (float)punct2.x, (float)punct2.y);
                    index += 4;
                }
            }
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
            panelPoints++; //incrementeaza numarul de puncte din panel

            if (Int32.Parse(txtnrpct.Text) >= panelPoints) // nu permite utilizatorului sa deseneze mai multe puncte decat trebuie pentru figura
            {
                Graphics g1 = panel1.CreateGraphics();
                Font font = new Font("Comic", 7);
                Brush br = new SolidBrush(System.Drawing.Color.Olive);
                System.Drawing.Point point = panel1.PointToClient(Cursor.Position);
                g1.DrawString("X", font, br, point.X, point.Y);
                listp.Add(new Point(point.X, point.Y));//adauga punctele din panel in lista
                lblCoord.Text = point.ToString(); //arata in label coordonatele fiecarui punct introdus.
            }

            if (Int32.Parse(txtnrpct.Text) == 1 && panelPoints == 1) //deseneaza cerc
            {
                Graphics g2 = panel1.CreateGraphics();
                Point punct = listp.Last();
                Pen p = new Pen(Color.Black);
                int raza = Int32.Parse(txtraza.Text);
                g2.DrawEllipse(p, Convert.ToSingle(punct.x) - raza / 2 + 5, Convert.ToSingle(punct.y) - raza / 2 + 5, raza, raza);
            }
            else if (Int32.Parse(txtnrpct.Text) == 2 || Int32.Parse(txtnrpct.Text) == 3)
                MessageBox.Show("Nu se pot crea obiecte folosind 2 sau 3 puncte");
            else
            {
                if (panelPoints >= 2)
                {
                    Graphics g3 = panel1.CreateGraphics();
                    Point punct1 = listp[listp.Count()-2];
                    Point punct2 = listp.Last();
                    Pen p = new Pen(Color.Black,2);
                    g3.DrawLine(p, Convert.ToSingle(punct1.x), Convert.ToSingle(punct1.y), Convert.ToSingle(punct2.x), Convert.ToSingle(punct2.y));
                }
            }
        }

        private void BtnDrawCircle(object sender, EventArgs e)
        {

        }

        private void BtnDeseneazaCerc_Click(object sender, EventArgs e)
        {
            panelPoints = 0;
            txtnrpct.Clear();
            txtraza.Clear();
            //listp.Clear();
            /*
            if((txtraza.Text!="")&&(listp.Count==1))
            {
                Graphics g = panel1.CreateGraphics();
                g.SmoothingMode = SmoothingMode.HighQuality;
                Pen blackpen = new Pen(Color.Black, 3);
                String raza = txtraza.Text;
                float razaCerc = float.Parse(raza);
                float xoffset = 4.5f;
                float yoffset = 6f;

                Compute.DrawCircle(g, blackpen, (float)listp[0].x + xoffset, (float)listp[0].y + yoffset, razaCerc);
               
                //razaCerc = 0; //reinitializare raza cerc
            }
            else if((txtraza.Text == "")&& (listp.Count != 1))
            {
                MessageBox.Show("Nu ati introdus raza cercului!\n Nu ati ales centrul cercului!");

            }
            else if((txtraza.Text == "") && (listp.Count == 1))
            {
                MessageBox.Show("Nu ati introdus raza cercului!");
            }
            else if((txtraza.Text != "") && (listp.Count != 1))
            {
                MessageBox.Show("Nu ati ales centrul cercului!");
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            /*
            Graphics g = panel1.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            Pen blackpen = new Pen(Color.Black, 3);
            Pen p = new Pen(Color.DarkRed, 10f);
            Font font = new Font("Comic", 7);
            String raza = (txtraza.Text == "") ? "0" : txtraza.Text;
            float razaCerc = float.Parse(raza);
            float xoffset = 4.5f;
            float yoffset = 6f;

            if (panelPoints > 2)
            {
                IList<Point> actual = ConvexHull.MakeHull(listp);
                IList<Point> expected = ConvexHullTest.MakeHullNaive(listp);

                ConvexHullTest.AssertEquals(expected, actual);

                int nr = expected.Count;

                if (nr > 2)
                {
                    txtnrpct.Text = nr.ToString();

                    Brush br = new SolidBrush(System.Drawing.Color.DarkRed);

                    //Deseneaza punctele din plan - printr'un x
                    for (int index = 0; index < nr; index++)
                    {
                        g.DrawString("X", font, br, (float)expected[index].x, (float)expected[index].y);
                    }
                    System.Threading.Thread.Sleep(7000);

                    //Traseaza figura in urma punctelor calculate a fi valide - prin converHullAlgorithm
                    for (int index = 0; index < nr - 1; index++)
                    {
                        g.DrawLine(blackpen, (float)expected[index].x + xoffset, (float)expected[index].y + yoffset, (float)expected[index + 1].x + xoffset, (float)expected[index + 1].y + yoffset);
                    }
                    //Traseaza ultima linie a figurii: uneste primul punct din lista cu ultimul
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
                MessageBox.Show("Numarul minim de puncte este 3. \n Ati introdus " + panelPoints.ToString() + " puncte.");
            }
            listp.Clear(); //initializare lista cu puncte din panel
            panelPoints = 0; //initializare numar de puncte din panel
            g.Dispose();*/
        }

        private void BtnClearPanel_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void BtnClearPanelData_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            listp.Clear();
        }

        private void txtnrpct_TextChanged(object sender, EventArgs e)
        {
            if (txtnrpct.Text == "1")
                MessageBox.Show("Alegeti centrul cercului si dati valoare razei!");
        }

        private void comboforma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboforma.SelectedIndex==1)
            {
                combocapete.Visible = true;
            }
            else if(comboforma.SelectedIndex == 0)
            {
                combocapete.Visible = false;
            }
        }
    }
}

