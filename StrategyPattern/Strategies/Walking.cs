using System.Drawing;

namespace StrategyPattern.Strategies
{
    public class Walking : IStrategy
    {
        public Point[] BuildRoute(Point start, Point end)
        {
            return new Point[]
            {
                new Point(start.X, start.Y),
                new Point(start.X + 1, start.Y + 1),
                new Point(end.X, end.Y)
            };
        }
    }
}
