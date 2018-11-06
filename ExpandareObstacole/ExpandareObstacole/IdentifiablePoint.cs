using System.Drawing;

public class IdentifiablePoint
{
    public int ID { get; set; }
    public PointF CenterPoint { get; set; }
    public Color ForeColor { get; set; }

    public IdentifiablePoint()
    {
        this.ForeColor = Color.Red;
    }

    public void Render(Graphics g)
    {
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        using (SolidBrush sb = new SolidBrush(this.ForeColor))
            g.FillEllipse(sb, new RectangleF(CenterPoint.X - 5, CenterPoint.Y - 5, 10, 10));
    }

    public bool HitTest(float x, float y)
    {
        bool b = false;
        using (System.Drawing.Drawing2D.GraphicsPath gP = new System.Drawing.Drawing2D.GraphicsPath())
        {
            gP.AddEllipse(new RectangleF(CenterPoint.X - 5, CenterPoint.Y - 5, 10, 10));

            if (gP.IsVisible(x, y))
                b = true;
        }

        return b;
    }
}