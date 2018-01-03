using System;
namespace snaken
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int v1, int v2, char v3)
        {
            this.x = v1;
            this.y = v2;
            this.sym = v3;
        }

        public void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
