using System.Drawing;

namespace StrategyPattern
{
    public class Navigator
    {
        private IStrategy _routeStrategy;

        public Navigator(IStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _routeStrategy = strategy;
        }

        public Point[] StartStrategy(Point start, Point end)
        {
            return _routeStrategy.BuildRoute(start, end);
        }
    }
}