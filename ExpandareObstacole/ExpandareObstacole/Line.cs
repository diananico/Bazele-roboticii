namespace ExpandareObstacole
{
    public class Line
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }

        public Line(Point p1_, Point p2_)
        {
            p1 = p1_;
            p2 = p2_;
        }
    }
}