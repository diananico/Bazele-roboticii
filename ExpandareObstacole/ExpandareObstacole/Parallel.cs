
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExpandareObstacole
{
    class Parallel
    {

        // Return points representing an enlarged polygon.
        public static IList<Point> parallelP = new List<Point>();

        public static IList<Point> GetEnlargedPolygon(
            IList<Point> old_points, float offset, out Point close1)
        {
            close1.x = 0;
            close1.y = 0;


            IList<Point> enlarged_points = new List<Point>();
            int num_points = old_points.Count;
            for (int j = 0; j < num_points; j++)
            {
                // Find the new location for point j.
                // Find the points before and after j.
                int i = (j - 1);
                if (i < 0) i += num_points;
                int k = (j + 1) % num_points;

                // Move the points by the offset.
                Vector v1 = new Vector(
                    old_points[j].x - old_points[i].x,
                    old_points[j].y - old_points[i].y);
                v1.Normalize();
                v1 *= offset;
                Vector n1 = new Vector(-v1.Y, v1.X);

                Point pij1 = new Point(
                    (float)(old_points[i].x + n1.X),
                    (float)(old_points[i].y + n1.Y));
                Point pij2 = new Point(
                    (float)(old_points[j].x + n1.X),
                    (float)(old_points[j].y + n1.Y));

                Vector v2 = new Vector(
                    old_points[k].x - old_points[j].x,
                    old_points[k].y - old_points[j].y);
                v2.Normalize();
                v2 *= offset;
                Vector n2 = new Vector(-v2.Y, v2.X);

                Point pjk1 = new Point(
                    (float)(old_points[j].x + n2.X),
                    (float)(old_points[j].y + n2.Y));
                Point pjk2 = new Point(
                    (float)(old_points[k].x + n2.X),
                    (float)(old_points[k].y + n2.Y));



                parallelP.Add(pij1);
                parallelP.Add(pij2);
                parallelP.Add(pjk1);
                parallelP.Add(pjk2);


                // See where the shifted lines ij and jk intersect.
                bool lines_intersect, segments_intersect;
                Point poi, /*close1,*/ close2;
               
                FindIntersection(pij1, pij2, pjk1, pjk2,
                    out lines_intersect, out segments_intersect,
                    out poi, out close1, out close2);

                enlarged_points.Add(poi);
            }

            return enlarged_points;
        }



        public static void FindIntersection(
    Point p1, Point p2, Point p3, Point p4,
    out bool lines_intersect, out bool segments_intersect,
    out Point intersection,
    out Point close_p1, out Point close_p2)
        {
            // Get the segments' parameters.
            float dx12 = (float)(p2.x - p1.x);
            float dy12 = (float)(p2.y - p1.y);
            float dx34 = (float)(p4.x - p3.x);
            float dy34 = (float)(p4.y - p3.y);

            // Solve for t1 and t2
            float denominator = (dy12 * dx34 - dx12 * dy34);

            float t1 = (float)
                ((p1.x - p3.x) * dy34 + (p3.y - p1.y) * dx34)
                    / denominator;
            if (float.IsInfinity(t1))
            {
                // The lines are parallel (or close enough to it).
                lines_intersect = false;
                segments_intersect = false;
                intersection = new Point(float.NaN, float.NaN);
                close_p1 = new Point(float.NaN, float.NaN);
                close_p2 = new Point(float.NaN, float.NaN);
                return;
            }
            lines_intersect = true;

            float t2 =(float)
                ((p3.x - p1.x) * dy12 + (p1.y - p3.y) * dx12)
                    / -denominator;

            // Find the point of intersection.
            intersection = new Point(p1.x + dx12 * t1, p1.y + dy12 * t1);

            // The segments intersect if t1 and t2 are between 0 and 1.
            segments_intersect =
                ((t1 >= 0) && (t1 <= 1) &&
                 (t2 >= 0) && (t2 <= 1));

            // Find the closest points on the segments.
            if (t1 < 0)
            {
                t1 = 0;
            }
            else if (t1 > 1)
            {
                t1 = 1;
            }

            if (t2 < 0)
            {
                t2 = 0;
            }
            else if (t2 > 1)
            {
                t2 = 1;
            }

            close_p1 = new Point(p1.x + dx12 * t1, p1.y + dy12 * t1);
            close_p2 = new Point(p3.x + dx34 * t2, p3.y + dy34 * t2);
        }
    }
}
