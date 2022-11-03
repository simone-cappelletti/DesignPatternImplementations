using System.Drawing;

namespace StrategyPattern
{
    public interface IStrategy
    {
        Point[] BuildRoute(Point start, Point end);
    }
}
