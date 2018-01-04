using System;

namespace snaken
{
    class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');

            p1.Draw(p1.x, p1.y, p1.sym);

            Point p2 = new Point(4, 5, '#');

            p2.Draw(p2.x, p2.y, p2.sym);
        }
    }
}