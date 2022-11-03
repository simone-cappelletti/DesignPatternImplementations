using System.Drawing;

namespace StrategyPattern.Strategies
{
    public class Road : IStrategy
    {
        public Point[] BuildRoute(Point start, Point end)
        {
            return new Point[]
            {
                new Point(start.X, start.Y),
                new Point(start.X + 4, start.Y + 5),
                new Point(end.X, end.Y)
            };
        }
}
}
